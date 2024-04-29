using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Apoteka
{
    public partial class PovecajZalihe : Form
    {
        public PovecajZalihe()
        {
            InitializeComponent();
        }
        List<Lek> lekovi;
        public PovecajZalihe(List<Lek> list)
        {
            InitializeComponent();
            lekovi = list;
        }

        OleDbConnection conn;
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Izabrati lek nad kojim se vrsi " + (radioButton1.Checked ? "dodavanje" : "smanjivanje") + " kolicine");
                return;
            }
            int n = listBox1.SelectedIndex - 1;
            if (n >= 0)
            {
                try
                {
                    int kol = Convert.ToInt32(textBox1.Text);
                    if (kol <= 0)
                    {
                        throw new Exception();
                    }
                    var DBPath = Application.StartupPath + "\\lekovi1.mdb";
                    conn = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + DBPath);
                    //conn.Open();
                    //System.Windows.Forms.MessageBox.Show("Connected successfully");
                    /*
                    string query = "select * from lekovi";
                    OleDbCommand command = new OleDbCommand(query, conn);
                    OleDbDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    */

                    conn.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = conn;
                    /*
                    string query = "update lekovi set Kolicina=" + (lekovi[n].Kolicina + kol);
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data Edit Successfully");
                    conn.Close();
                    */
                    /*
                    foreach (DataRow row in dataTable.Rows)
                    {
                        //string[] s = r.ReadLine().Split();
                        if ((int)row["Kolicina"] == lekovi[n].Kolicina)
                        {
                            (int)row[n]["Kolicina"] += kol;
                        }
                    }
                    */

                    if (radioButton1.Checked)
                    {
                        //dataTable.Rows[n]["Kolicina"] = lekovi[n].Kolicina + kol;
                        /*
                        foreach (DataRow row in dataTable.Rows)
                        {
                            if (row["Kolicina"].ToString() == lekovi[n].Kolicina.ToString())
                                row.SetField("Kolicina", (lekovi[n].Kolicina + kol).ToString());
                        }
                        */
                        string query = "update lekovi set Kolicina=" + (lekovi[n].Kolicina + kol) + " where kolicina = " + lekovi[n].Kolicina;
                        command.CommandText = query;
                        command.ExecuteNonQuery();
                        //MessageBox.Show("Data Edit Successfully");
                        conn.Close();

                        lekovi[n].Kolicina += kol;
                    }
                    else if (lekovi[n].Kolicina >= kol)
                    {
                        //dataTable.Rows[n]["Kolicina"] = lekovi[n].Kolicina - kol;
                        /*
                        foreach (DataRow row in dataTable.Rows)
                        {
                            if (row["Kolicina"].ToString() == lekovi[n].Kolicina.ToString())
                                row.SetField("Kolicina", (lekovi[n].Kolicina - kol).ToString());
                        }
                        */
                        string query = "update lekovi set Kolicina=" + (lekovi[n].Kolicina - kol) + " where kolicina = " + lekovi[n].Kolicina;
                        command.CommandText = query;
                        command.ExecuteNonQuery();
                        //MessageBox.Show("Data Edit Successfully");
                        conn.Close();

                        lekovi[n].Kolicina -= kol;
                    }
                    else
                    {
                        MessageBox.Show("Unesite odgovarajucu kolicinu za smanjenje!");
                    }
                    MessageBox.Show("Uspesno ste izmenili kolicinu!", "Obavestenje");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Unesite odgovarajucu kolicinu!");
                }
            }
            else
            {
                MessageBox.Show("Odaberite odgovarajuci lek!");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Text = "DODAJ";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Text = "ODUZMI";
        }

        private void PovecajZalihe_Load(object sender, EventArgs e)
        {
            List<Lek> lekovi = Apoteka.listaStanje;
            listBox1.Items.Add("IME | ŠIFRA | CENA | KOLIČINA");
            for (int i = 0; i < lekovi.Count; i++)
            {
                listBox1.Items.Add(lekovi[i].Ime + " | " + lekovi[i].Sifra + " | " + lekovi[i].Cena + " | " + lekovi[i].Kolicina);
            }
        }
    }
}
