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
    public partial class IzmeniInventar : Form
    {
        public IzmeniInventar()
        {
            InitializeComponent();
        }
        List<Lek> lekovi;
        public IzmeniInventar(List<Lek> list)
        {
            InitializeComponent();
            lekovi = list;
        }

        int index;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = listBox1.SelectedIndex;
            if (--index > -1)
            {
                textBox1.Text = lekovi[index].Ime.Replace('|', ' ');
                textBox2.Text = lekovi[index].Sifra.Replace('|', ' ');
                textBox3.Text = lekovi[index].Cena.ToString().Replace('|', ' ');
                textBox4.Text = lekovi[index].Kolicina.ToString().Replace('|', ' ');
                comboBox1.SelectedIndex = (int)lekovi[index].TipLeka;
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                comboBox1.SelectedIndex = -1;
            }
        }

        private void IzmeniInventar_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("IME | ŠIFRA | CENA | KOLIČINA");
            for (int i = 0; i < lekovi.Count; i++)
            {
                listBox1.Items.Add(lekovi[i].Ime + " | " + lekovi[i].Sifra + " | " + lekovi[i].Cena + " | " + lekovi[i].Kolicina);
            }
        }

        OleDbConnection conn;
        private void button1_Click(object sender, EventArgs e)
        {
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

            string ime = textBox1.Text;
            string sifra = textBox2.Text;
            int cena = int.Parse(textBox3.Text);
            int kolicina = int.Parse(textBox4.Text);
            int tip = comboBox1.SelectedIndex;
            lekovi[index].Ime = ime;
            lekovi[index].Sifra = sifra;
            lekovi[index].Cena = cena;
            lekovi[index].Kolicina = kolicina;
            lekovi[index].TipLeka = (Lek.Tip)tip;
            /*
            dataTable.Rows[index]["Ime"] = ime;
            dataTable.Rows[index]["Sifra"] = sifra;
            dataTable.Rows[index]["Cena"] = cena;
            dataTable.Rows[index]["Kolicina"] = kolicina;
            */
            string query = "";
            switch (tip)
            {
                case 0:
                    //dataTable.Rows[index]["Tip"] = "ANTIBIOTIK";
                    query = "update lekovi set Sifra='" + sifra + "', Ime='" + ime + "', Cena =" + cena + ", Kolicina=" + kolicina + ", Tip='ANTIBIOTIK'" +
                " where Sifra = " + lekovi[index].Sifra;
                    break;
                case 1:
                    //dataTable.Rows[index]["Tip"] = "ANALGETIK";
                    query = "update lekovi set Sifra='" + sifra + "', Ime='" + ime + "', Cena =" + cena + ", Kolicina=" + kolicina + ", Tip='ANALGETIK'" +
                " where Sifra = " + lekovi[index].Sifra;
                    break;
                case 2:
                    //dataTable.Rows[index]["Tip"] = "PROBIOTIK";
                    query = "update lekovi set Sifra='" + sifra + "', Ime='" + ime + "', Cena =" + cena + ", Kolicina=" + kolicina + ", Tip='PROBIOTIK'" +
                " where Sifra = " + lekovi[index].Sifra;
                    break;
                case 3:
                    //dataTable.Rows[index]["Tip"] = "ANTIPIRETIK";
                    query = "update lekovi set Sifra='" + sifra + "', Ime='" + ime + "', Cena =" + cena + ", Kolicina=" + kolicina + ", Tip='ANTIPIRETIK'" +
                " where Sifra = " + lekovi[index].Sifra;
                    break;
                case 4:
                    //dataTable.Rows[index]["Tip"] = "ANTIDIJABETIK";
                    query = "update lekovi set Sifra='" + sifra + "', Ime='" + ime + "', Cena =" + cena + ", Kolicina=" + kolicina + ", Tip='ANTIDIJABETIK'" +
                " where Sifra = " + lekovi[index].Sifra;
                    break;
                case 5:
                    //dataTable.Rows[index]["Tip"] = "ANTIDIJAROIK";
                    query = "update lekovi set Sifra='" + sifra + "', Ime='" + ime + "', Cena =" + cena + ", Kolicina=" + kolicina + ", Tip='ANTIDIJAROIK'" +
                " where Sifra = " + lekovi[index].Sifra;
                    break;
                case 6:
                    //dataTable.Rows[index]["Tip"] = "ANTIEMETIK";
                    query = "update lekovi set Sifra='" + sifra + "', Ime='" + ime + "', Cena =" + cena + ", Kolicina=" + kolicina + ", Tip='ANTIEMETIK'" +
                " where Sifra = " + lekovi[index].Sifra;
                    break;
                case 7:
                    //dataTable.Rows[index]["Tip"] = "ANTIMIKOTIK";
                    query = "update lekovi set Sifra='" + sifra + "', Ime='" + ime + "', Cena =" + cena + ", Kolicina=" + kolicina + ", Tip='ANTIMIKOTIK'" +
                " where Sifra = " + lekovi[index].Sifra;
                    break;
                case 8:
                    //dataTable.Rows[index]["Tip"] = "BENZODIAZEPIN";
                    query = "update lekovi set Sifra='" + sifra + "', Ime='" + ime + "', Cena =" + cena + ", Kolicina=" + kolicina + ", Tip='BENZODIAZEPIN'" +
                " where Sifra = " + lekovi[index].Sifra;
                    break;
                case 9:
                    //dataTable.Rows[index]["Tip"] = "BRONHODILATOR";
                    query = "update lekovi set Sifra='" + sifra + "', Ime='" + ime + "', Cena =" + cena + ", Kolicina=" + kolicina + ", Tip='BRONHODILATOR'" +
                " where Sifra = " + lekovi[index].Sifra;
                    break;
                case 10:
                    //dataTable.Rows[index]["Tip"] = "DIURETIK";
                    query = "update lekovi set Sifra='" + sifra + "', Ime='" + ime + "', Cena =" + cena + ", Kolicina=" + kolicina + ", Tip='DIURETIK'" +
                " where Sifra = " + lekovi[index].Sifra;
                    break;
                case 11:
                    //dataTable.Rows[index]["Tip"] = "KORTIKOSTEROID";
                    query = "update lekovi set Sifra='" + sifra + "', Ime='" + ime + "', Cena =" + cena + ", Kolicina=" + kolicina + ", Tip='KORTIKOSTEROID'" +
                " where Sifra = " + lekovi[index].Sifra;
                    break;
            }
            //string query = "update lekovi set Sifra='" + sifra + "', Ime='" + ime + "', Cena =" + cena + ", Kolicina=" + kolicina + ", Tip='ANTIBIOTIK'" + 
                //" where Sifra = " + lekovi[index].Sifra;
            command.CommandText = query;
            command.ExecuteNonQuery();
            //MessageBox.Show("Data Edit Successfully");
            conn.Close();
            MessageBox.Show("Uspesno ste izmenili inventar!", "Obavestenje");
            this.Close();
        }
    }
}
