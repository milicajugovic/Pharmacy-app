using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apoteka
{
    public partial class DodajNoviLek : Form
    {
        public DodajNoviLek()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ime = textBox1.Text;
            string sifra = textBox2.Text;
            int cena = int.Parse(textBox3.Text);
            int kolicina = int.Parse(textBox4.Text);
            int x = comboBox1.SelectedIndex;
            string tip = "";
            switch (x)
            {
                case 0:
                    tip = "ANTIBIOTIK";
                    break;
                case 1:
                    tip = "ANALGETIK";
                    break;
                case 2:
                    tip = "PROBIOTIK";
                    break;
                case 3:
                    tip = "ANTIPIRETIK";
                    break;
                case 4:
                    tip = "ANTIDIJABETIK";
                    break;
                case 5:
                    tip = "ANTIDIJAROIK";
                    break;
                case 6:
                    tip = "ANTIEMETIK";
                    break;
                case 7:
                    tip = "ANTIMIKOTIK";
                    break;
                case 8:
                    tip = "BENZODIAZEPIN";
                    break;
                case 9:
                    tip = "BRONHODILATOR";
                    break;
                case 10:
                    tip = "DIURETIK";
                    break;
                case 11:
                    tip = "KORTIKOSTEROID";
                    break;
            }
            OleDbConnection conn;
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                var DBPath = Application.StartupPath + "\\lekovi1.mdb";
                conn = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + DBPath);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO lekovi (Sifra, Ime, Cena, Kolicina, Tip)" + "VALUES ('" + sifra + "','" + ime + "'," + cena + "," + kolicina + ",'" + tip + "')";
                cmd.Parameters.AddWithValue("@Sifra", sifra);
                cmd.Parameters.AddWithValue("@Ime", ime);
                cmd.Parameters.AddWithValue("@Cena", cena);
                cmd.Parameters.AddWithValue("@Kolicina", kolicina);
                cmd.Parameters.AddWithValue("@Tip", tip);
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dodali ste novi lek u bazu.", "Obavestenje");
                this.Close();
            }
            catch (Exception ex)
            {
                textBox1.Text = ex.ToString();
            }

        }

        private void DodajNoviLek_Load(object sender, EventArgs e)
        {

        }
    }
}
