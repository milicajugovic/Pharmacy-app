using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoteka
{
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

    //public List<Lek> listaInventar;
    //public List<Lek> listaKorpa;
    //public List<Lek> listaStanje;
}
