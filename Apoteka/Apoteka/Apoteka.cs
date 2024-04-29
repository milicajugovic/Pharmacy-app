using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace Apoteka
{
    public partial class Apoteka : Form
    {
        public Apoteka()
        {
            InitializeComponent();
        }

        /*
        public class Lek
        {
            #region Atributi
            
            public enum Tip
            {
                ANTIBIOTIK,
                ANTISEPTIK,
                ANALGETIK,
                PROBIOTIK,
                ANTIPIRETIK,
                ANTIDEPRESIV,
                ANTIDIJABETIK,
                ANTIDIJAROIK,
                ANTIEMETIK,
                ANTIMIKOTIK,
                BENZODIAZEPIN,
                BRONHODILATOR,
                DIURETIK,
                KORTIKOSTEROID
            }
            
            #endregion
            #region Svojstva
            public string Ime { get; set; }
            public string Sifra { get; set; }
            public double Cena { get; set; }
            public int Kolicina { get; set; }
            public Tip TipLeka { get; set; }
            public int KolicinaKorpa { get; set; }
            #endregion
            #region Konstruktori
            public Lek()
            {
                Ime = "";
                Sifra = "";
                Cena = 0;
                Kolicina = 0;
                TipLeka = 0;
                KolicinaKorpa = 0;
            }
            public Lek(string ime, string sifra, double cena, int kolicina, int tipLeka)
            {
                Ime = ime;
                Sifra = sifra;
                Cena = cena;
                Kolicina = kolicina;
                TipLeka = (Tip)tipLeka;
                KolicinaKorpa = 0;
            }
            public Lek(Lek l)
            {
                Ime = l.Ime;
                Sifra = l.Sifra;
                Cena = l.Cena;
                Kolicina = l.Kolicina;
                TipLeka = l.TipLeka;
                KolicinaKorpa = l.KolicinaKorpa;
            }
            #endregion
            #region Metode
            #endregion
        }
        */

        public List<Lek> listaInventar;
        public List<Lek> listaKorpa;
        public static List<Lek> listaStanje;

        public int Povezi(string ime)
        {
            for (int i = 0; i < listaInventar.Count; i++)
            {
                if (ime == listaInventar[i].Ime)
                {
                    return i;
                }
            }
            return -1;
        }

        public void resetStanja()
        {
            listaStanje.Clear();
            for (int i = 0; i < listaInventar.Count; i++)
            {
                Lek l = listaInventar[i];
                listaStanje.Add(l);
            }
        }

        public void azurirajListuStanje(List<Lek> listaStanje)
        {
            //listaStanje.Sort();
            //sort();
            int x = lbStanje.SelectedIndex;
            int brKol = lbStanje.Items.Count;
            lbStanje.Items.Clear();
            lbStanje.Items.Add("IME | ŠIFRA | CENA | KOLIČINA");
            for (int i = 0; i < listaStanje.Count; i++)
            {
                if (comboBox1.SelectedIndex == 6 || comboBox1.SelectedIndex == (int)listaStanje[i].TipLeka)
                {
                    Lek l = listaStanje[i];
                    string str = l.Ime.Replace('|', ' ') + l.Sifra.ToString() + " | "
                        + l.Cena.ToString("0.00") + " | " + (l.Kolicina - l.KolicinaKorpa).ToString();
                    lbStanje.Items.Add(str);
                }
            }
            if (lbStanje.Items.Count == brKol)
            {
                lbStanje.SelectedIndex = x;
            }
        }

        public void azurirajListuKorpa()
        {
            lbKorpa.Items.Clear();
            lbKorpa.Items.Add("IME | ŠIFRA | CENA | KOLIČINA | UKUPNO");
            double uk = 0;
            for (int i = 0; i < listaKorpa.Count; i++)
            {
                Lek l = listaKorpa[i];
                string str = l.Ime + " | " + l.Sifra + " | "
                    + l.Cena.ToString() + " | " + l.KolicinaKorpa.ToString()
                    + " | " + (l.Cena * l.KolicinaKorpa).ToString();
                lbKorpa.Items.Add(str);
                uk += l.Cena * l.KolicinaKorpa;
            }
            tbUkupno.Text = uk.ToString("0.00");
        }

        public void azurirajFajl()
        {
            if (listaKorpa.Count == 0)
            {
                StreamWriter w = new StreamWriter(@"Podaci\stanje.txt");
                for (int i = 0; i < listaInventar.Count; i++)
                {
                    Lek l = listaInventar[i];
                    string str = l.Ime + " " + l.Sifra + " " + l.Cena + " " + l.Kolicina + " " + (int)l.TipLeka;
                    w.WriteLine(str);
                }
                w.Close();
            }
        }

        public void stampajRacun()
        {
            try
            {
                if (listaKorpa.Count > 0)
                {
                    if (!Directory.Exists(@"Podaci\racuni"))
                    {
                        Directory.CreateDirectory(@"Podaci\racuni");
                    }
                    DateTime sad = DateTime.Now;
                    string put = @"Podaci\racuni\račun_" + sad.Year + "." + sad.Month + "."
                        + sad.Day + "_" + sad.Hour + "." + sad.Minute + "." + sad.Second + ".txt";
                    StreamWriter w = new StreamWriter(put);
                    w.WriteLine("APOTEKA ABCD - FISKALNI RAČUN");
                    w.WriteLine();
                    w.WriteLine("-----------------------------");
                    w.WriteLine("HVALA NA KUPOVINI!");
                    w.WriteLine("-----------------------------");
                    for (int i = 0; i < listaKorpa.Count; i++)
                    {
                        Lek l = listaKorpa[i];
                        w.WriteLine(l.Sifra.ToString() + " " + l.Ime.Replace('|', ' '));
                        w.WriteLine("     " + l.KolicinaKorpa.ToString() + "X    " + l.Cena.ToString("0.00")
                            + "      " + (l.Cena * l.KolicinaKorpa).ToString("0.00"));
                    }
                    w.WriteLine("-----------------------------");
                    w.WriteLine("UKUPNO: " + tbUkupno.Text);
                    w.WriteLine();
                    w.WriteLine("Datum: " + sad.Day + "." + sad.Month + "." + sad.Year);
                    w.WriteLine("Vreme: " + sad.Hour + ":" + sad.Minute + ":" + sad.Second);
                    w.Close();
                }
            }
            catch
            {
                MessageBox.Show("Greška! Hitno pozovite administratora!");
            }
        }

        public void sort()
        {
            if (opadajuceSortiranje.Checked)
            {
                if (radioButton2.Checked)
                {
                    listaStanje.Sort(delegate (Lek t1, Lek t2) { return (t2.Cena.CompareTo(t1.Cena)); });
                }
                else
                {
                    listaStanje.Sort(delegate (Lek t1, Lek t2) { return (t2.Ime.CompareTo(t1.Ime)); });
                }
            }
            else
            {
                if (radioButton2.Checked)
                {
                    listaStanje.Sort(delegate (Lek t1, Lek t2) { return (t1.Cena.CompareTo(t2.Cena)); });
                }
                else
                {
                    listaStanje.Sort(delegate (Lek t1, Lek t2) { return (t1.Ime.CompareTo(t2.Ime)); });
                }
            }
        }

        public void pretraga(string tekst, bool poImenu)
        {
            /*
            resetStanja();
            if (poImenu)
            {
                for (int i = 0; i < listaStanje.Count;)
                {
                    if (listaStanje[i].Ime.ToLower().StartsWith(tekst.ToLower()))
                    {
                        azurirajListuStanje(listaStanje);
                        lbStanje.Items.Add(listaStanje[i].Ime + " | " + listaStanje[i].Sifra + " | " + listaStanje[i].Cena + " | " + listaStanje[i].Kolicina);
                    }
                }
            }
            else
            {
                for (int i = 0; i < listaStanje.Count;)
                {
                    if (listaStanje[i].Sifra.ToString().StartsWith(tekst.ToLower()))
                    {
                        azurirajListuStanje(listaStanje);
                        lbStanje.Items.Add(listaStanje[i].Ime + " | " + listaStanje[i].Sifra + " | " + listaStanje[i].Cena + " | " + listaStanje[i].Kolicina);
                    }
                }
            }
            azurirajListuStanje(listaStanje);
            */
        }

        public void refreshListaStanje()
        {
            lbStanje.Items.Add("IME | ŠIFRA | CENA | KOLIČINA");
            for (int i = 0; i < listaInventar.Count; i++)
            {
                lbStanje.Items.Add(listaInventar[i].Ime + " | " + listaInventar[i].Sifra + " | " + listaInventar[i].Cena + " | " + listaInventar[i].Kolicina);
            }
        }

        OleDbConnection conn;
        private void Apoteka_Load(object sender, EventArgs e)
        {
            var DBPath = Application.StartupPath + "\\lekovi1.mdb";
            conn = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + DBPath);
            conn.Open();
            System.Windows.Forms.MessageBox.Show("Connected successfully");
            string query = "select * from lekovi";
            OleDbCommand command = new OleDbCommand(query, conn);
            OleDbDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            listaInventar = new List<Lek>();
            listaKorpa = new List<Lek>();
            listaStanje = new List<Lek>();
            //comboBox1.SelectedIndex = 6;
            /*
            if (!Directory.Exists("Podaci"))
            {
                Directory.CreateDirectory("Podaci");
            }
            if (!File.Exists(@"Podaci\stanje.txt"))
            {
                StreamWriter w = new StreamWriter(@"Podaci\stanje.txt");
                w.Close();
            }
            StreamReader r = new StreamReader(@"Podaci\stanje.txt");
            */
            foreach(DataRow row in dataTable.Rows)
            {
                //string[] s = r.ReadLine().Split();
                string sifra = row["Sifra"].ToString();
                string ime = row["Ime"].ToString();
                int cena = (int)row["Cena"];
                int kolicina = (int)row["Kolicina"];
                string tip = row["Tip"].ToString();
                /*
                KORTIKOSTEROID
                */
                switch (tip)
                {
                    case "ANTIBIOTIK":
                        listaInventar.Add(new Lek(ime, sifra, cena, kolicina, 0));
                        listaStanje.Add(new Lek(ime, sifra, cena, kolicina, 0));
                        break;
                    case "ANALGETIK":
                        listaInventar.Add(new Lek(ime, sifra, cena, kolicina, 1));
                        listaStanje.Add(new Lek(ime, sifra, cena, kolicina, 1));
                        break;
                    case "PROBIOTIK":
                        listaInventar.Add(new Lek(ime, sifra, cena, kolicina, 2));
                        listaStanje.Add(new Lek(ime, sifra, cena, kolicina, 2));
                        break;
                    case "ANTIPIRETIK":
                        listaInventar.Add(new Lek(ime, sifra, cena, kolicina, 3));
                        listaStanje.Add(new Lek(ime, sifra, cena, kolicina, 3));
                        break;
                    case "ANTIDIJABETIK":
                        listaInventar.Add(new Lek(ime, sifra, cena, kolicina, 4));
                        listaStanje.Add(new Lek(ime, sifra, cena, kolicina, 4));
                        break;
                    case "ANTIDIJAROIK":
                        listaInventar.Add(new Lek(ime, sifra, cena, kolicina, 5));
                        listaStanje.Add(new Lek(ime, sifra, cena, kolicina, 5));
                        break;
                    case "ANTIEMETIK":
                        listaInventar.Add(new Lek(ime, sifra, cena, kolicina, 6));
                        listaStanje.Add(new Lek(ime, sifra, cena, kolicina, 6));
                        break;
                    case "ANTIMIKOTIK":
                        listaInventar.Add(new Lek(ime, sifra, cena, kolicina, 7));
                        listaStanje.Add(new Lek(ime, sifra, cena, kolicina, 7));
                        break;
                    case "BENZODIAZEPIN":
                        listaInventar.Add(new Lek(ime, sifra, cena, kolicina, 8));
                        listaStanje.Add(new Lek(ime, sifra, cena, kolicina, 8));
                        break;
                    case "BRONHODILATOR":
                        listaInventar.Add(new Lek(ime, sifra, cena, kolicina, 9));
                        listaStanje.Add(new Lek(ime, sifra, cena, kolicina, 9));
                        break;
                    case "DIURETIK":
                        listaInventar.Add(new Lek(ime, sifra, cena, kolicina, 10));
                        listaStanje.Add(new Lek(ime, sifra, cena, kolicina, 10));
                        break;
                    case "KORTIKOSTEROID":
                        listaInventar.Add(new Lek(ime, sifra, cena, kolicina, 11));
                        listaStanje.Add(new Lek(ime, sifra, cena, kolicina, 11));
                        break;
                }
                //listaInventar.Add(new Lek(ime, sifra, cena, kolicina, tip));
                //listaStanje.Add(new Lek(ime, sifra, cena, kolicina, tip));
            }
            //r.Close();
            //azurirajListuStanje(listaStanje);
            azurirajListuKorpa();
            refreshListaStanje();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            int elementi = lbStanje.Items.Count, ind;
            int n = ind = lbStanje.SelectedIndex;
            int kol = -1;
            
            try
            {
                kol = Convert.ToInt32(tbKolicina.Text);
            }
            catch
            {
                kol = -1;
            }
            if (kol > 0)
            {
                if (n > 0)
                {
                    n--;
                    string ime = lbStanje.Items[lbStanje.SelectedIndex].ToString();
                    ime = ime.Substring(0, ime.IndexOf('|') - 1).Replace(' ', '|');
                    n = Povezi(ime);//index u listi inventar

                    if (listaInventar[n].Kolicina >= (kol + listaInventar[n].KolicinaKorpa))
                    {
                        int k = -1;
                        int i = 0;
                        for (; i < listaKorpa.Count; i++)
                        {
                            if (listaInventar[n].Sifra == listaKorpa[i].Sifra)
                            {
                                ime = listaKorpa[i].Ime;
                                k = Povezi(ime);
                                break;
                            }
                        }
                        if (k == -1)
                        {
                            listaInventar[n].KolicinaKorpa += kol;
                            listaKorpa.Add(listaInventar[n]);
                            listaInventar[n].Kolicina -= kol;
                            lbStanje.Items.Clear();
                            refreshListaStanje();
                            //listaKorpa[pom] = listaInventar[n];
                            //lbKorpa.Items.Add(listaKorpa[pom].Ime + " | " + listaKorpa[pom].Sifra + " | " + listaKorpa[pom].Cena + " | " + listaKorpa[pom].KolicinaKorpa + " | " + (listaKorpa[pom].KolicinaKorpa * listaKorpa[pom].Cena).ToString());

                        }
                        else
                        {
                            listaKorpa[i] = listaInventar[k];
                            listaInventar[k].KolicinaKorpa += kol;
                            listaInventar[k].Kolicina -= kol;
                            lbStanje.Items.Clear();
                            refreshListaStanje();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Izaberite odgovarajuci lek sa stanja!");
                    }
                }
                else
                {
                    MessageBox.Show("Unesite odgovarajucu kolicinu!");
                }
                pretraga(tbPretraga.Text, radioButton1.Checked);
                if (elementi == lbStanje.Items.Count)
                {
                    lbStanje.SelectedIndex = ind;
                }

                /*
                lbKorpa.Items.Add(listaInventar[n].Ime + " | " + listaInventar[n].Sifra + " | " + listaInventar[n].Cena + " | " + listaInventar[n].KolicinaKorpa + " | " + (listaInventar[n].KolicinaKorpa * listaInventar[n].Cena).ToString());
                for (int i = 0; i < listaKorpa.Count; i++)
                {
                    ukupno += listaInventar[n].KolicinaKorpa * listaInventar[n].Cena;
                }
                tbUkupno.Text = ukupno.ToString();
                */
                azurirajListuKorpa();
            }
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            int n = lbKorpa.SelectedIndex;
            if (--n >= 0)
            {
                int pom = Povezi(listaKorpa[n].Ime);
                listaStanje[pom].Kolicina += listaKorpa[n].KolicinaKorpa;
                listaKorpa[n].KolicinaKorpa = 0;
                listaKorpa.Remove(listaKorpa[n]);
                azurirajListuKorpa();
                //azurirajListuStanje(listaStanje);
                lbStanje.Items.Clear();
                refreshListaStanje();
            }
            else
            {
                MessageBox.Show("Izaberite odgovarajuci lek u korpi!");
            }
        }

        private void btnPromeniKolicinu_Click(object sender, EventArgs e)
        {
            int n = lbKorpa.SelectedIndex;
            if (--n >= 0)
            {
                int kol = Convert.ToInt32(tbKolicina.Text);
                if (kol <= listaKorpa[n].Kolicina && kol > 0)
                {
                    listaKorpa[n].KolicinaKorpa = kol;
                }
                else
                {
                    MessageBox.Show("Unesite odgovarajucu kolicinu!");
                }
                azurirajListuKorpa();
                //azurirajListuStanje(listaStanje);
                lbStanje.Items.Clear();
                refreshListaStanje();
            }
            else
            {
                MessageBox.Show("Izaberite odgovarajuci lek u korpi!");
            }
        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listaKorpa.Count; i++)
            {
                listaKorpa[i].KolicinaKorpa = 0;
            }
            listaKorpa.Clear();
            resetStanja();
            azurirajListuKorpa();
        }

        private void btnKupi_Click(object sender, EventArgs e)
        {
            if (listaKorpa.Count > 0)
            {
                stampajRacun();
                for (int i = 0; i < listaKorpa.Count; i++)
                {
                    listaKorpa[i].Kolicina -= listaKorpa[i].KolicinaKorpa;
                    listaKorpa[i].KolicinaKorpa = 0;
                }
                listaKorpa.Clear();
                azurirajListuKorpa();
                resetStanja();
                //azurirajListuStanje(listaStanje);
                refreshListaStanje();
                MessageBox.Show("Račun možete naći u folderu. Hvala Vam na kupovini!", "Kraj kupovine");
                //azurirajFajl();
            }
            else
            {
                MessageBox.Show("Korpa je prazna!");
            }
        }

        private void tbPretraga_TextChanged(object sender, EventArgs e)
        {
            //bool ime = radioButton1.Checked;
            //pretraga(tbPretraga.Text, ime);
        }

        public void pretragaPoTipu(int x)
        {
            for (int i = 0; i < listaInventar.Count; i++)
            {
                if ((int)listaInventar[i].TipLeka == x)
                {
                    lbStanje.Items.Add(listaInventar[i].Ime + " | " + listaInventar[i].Sifra + " | " + listaInventar[i].Cena + " | " + listaInventar[i].Kolicina);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = comboBox1.SelectedIndex;
            lbStanje.Items.Clear();
            lbStanje.Items.Add("IME | ŠIFRA | CENA | KOLIČINA");
            switch (x)
            {
                case 0:
                    pretragaPoTipu(x);
                    break;
                case 1:
                    pretragaPoTipu(x);
                    break;
                case 2:
                    pretragaPoTipu(x);
                    break;
                case 3:
                    pretragaPoTipu(x);
                    break;
                case 4:
                    pretragaPoTipu(x);
                    break;
                case 5:
                    pretragaPoTipu(x);
                    break;
                case 6:
                    pretragaPoTipu(x);
                    break;
                case 7:
                    pretragaPoTipu(x);
                    break;
                case 8:
                    pretragaPoTipu(x);
                    break;
                case 9:
                    pretragaPoTipu(x);
                    break;
                case 10:
                    pretragaPoTipu(x);
                    break;
                case 11:
                    pretragaPoTipu(x);
                    break;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //azurirajListuStanje(listaStanje);
            //sort();
            //lbStanje.Items.Clear();
            //refreshListaStanje();
            List<Lek> SortedList = listaStanje.OrderBy(o => o.Ime).ToList();
            lbStanje.Items.Clear();
            lbStanje.Items.Add("IME | ŠIFRA | CENA | KOLIČINA");
            for (int i = 0; i < SortedList.Count; i++)
            {
                lbStanje.Items.Add(SortedList[i].Ime + " | " + SortedList[i].Sifra + " | " + SortedList[i].Cena + " | " + SortedList[i].Kolicina);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //azurirajListuStanje(listaStanje);
            //sort();
            //lbStanje.Items.Clear();
            //refreshListaStanje();
            List<Lek> SortedList = listaStanje.OrderBy(o => o.Cena).ToList();
            lbStanje.Items.Clear();
            lbStanje.Items.Add("IME | ŠIFRA | CENA | KOLIČINA");
            for (int i = 0; i < SortedList.Count; i++)
            {
                lbStanje.Items.Add(SortedList[i].Ime + " | " + SortedList[i].Sifra + " | " + SortedList[i].Cena + " | " + SortedList[i].Kolicina);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            bool sifra = radioButton4.Checked;
            pretraga(tbPretraga.Text, sifra);
        }

        /*
        void otvoriFormu(int x, object sender, EventArgs e)
        {
            if (listaKorpa.Count == 0)
            {
                this.Hide();
                Form f2 = new Form2(x);
                f2.Show();
                f2.FormClosed += delegate { Apoteka_Load(sender, e); this.Show(); };
            }
            else
            {
                MessageBox.Show("Ispraznite korpu!");
            }
        }
        */

        private void dodajNoviLekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //otvoriFormu(1, sender, e);
            DodajNoviLek dodaj = new DodajNoviLek();
            //dodaj.ShowDialog();
            Hide();
            //Form2 form2 = new Form2();
            dodaj.ShowDialog();
            dodaj = null;
            Show();
        }

        private void promeniŠifruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //otvoriFormu(0, sender, e);
        }

        private void povećajZaliheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //otvoriFormu(2, sender, e);
            PovecajZalihe povecaj = new PovecajZalihe(listaStanje);
            //povecaj.ShowDialog();
            //povecaj.Show();
            //povecaj.FormClosed += new FormClosedEventHandler(delegate { Close(); });
            //this.Hide();
            Hide();
            //Form2 form2 = new Form2();
            povecaj.ShowDialog();
            povecaj = null;
            Show();
        }

        private void izmeniInventarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //otvoriFormu(3, sender, e);
        }

        private void opadajuceSortiranje_CheckedChanged(object sender, EventArgs e)
        {
            //azurirajListuStanje(listaStanje);
            sort();
            lbStanje.Items.Clear();
            refreshListaStanje();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tekst = tbPretraga.Text;
            lbStanje.Items.Clear();
            if (radioButton3.Checked == true)
            {
                for (int i = 0; i < listaStanje.Count;)
                {
                    if (listaStanje[i].Ime.ToLower().StartsWith(tekst.ToLower()))
                    {
                        //azurirajListuStanje(listaStanje);
                        lbStanje.Items.Add("IME | ŠIFRA | CENA | KOLIČINA");
                        lbStanje.Items.Add(listaStanje[i].Ime + " | " + listaStanje[i].Sifra + " | " + listaStanje[i].Cena + " | " + listaStanje[i].Kolicina);
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < listaStanje.Count;)
                {
                    if (listaStanje[i].Sifra.ToString().StartsWith(tekst.ToLower()))
                    {
                        //azurirajListuStanje(listaStanje);
                        lbStanje.Items.Add("IME | ŠIFRA | CENA | KOLIČINA");
                        lbStanje.Items.Add(listaStanje[i].Ime + " | " + listaStanje[i].Sifra + " | " + listaStanje[i].Cena + " | " + listaStanje[i].Kolicina);
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
        }

        private void izmeniInventarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            IzmeniInventar izmeni = new IzmeniInventar(listaStanje);
            //izmeni.ShowDialog();
            Hide();
            //Form2 form2 = new Form2();
            izmeni.ShowDialog();
            izmeni = null;
            Show();
        }
    }
}
