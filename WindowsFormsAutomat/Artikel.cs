using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsAutomat
{
    public class Artikel
    {
        private int bestand;

        public int Bestand
        {
            get { return bestand; }
            set { bestand = value; }
        }
        private string bezeichnung;

        public string Bezeichnung
        {
            get { return bezeichnung; }
            set { bezeichnung = value; }
        }
        private decimal preis;

        public decimal Preis
        {
            get { return preis; }
            set { preis = value; }
        }

        public Artikel()
        {
           
        }
        public Artikel(int bestand,String bezeichnung, decimal preis)
        {
            this.Bestand = bestand;
            this.Bezeichnung = bezeichnung;
            this.Preis = preis;
        }

        public int BestandAuffuellen(int menge)
        {
            this.Bestand += menge;
            return this.Bestand;
        }

        public bool BestandRunterzaehlen()
        {
            bool result = true;
            if (this.Bestand == 0) result = false;
            else this.Bestand--;
            return result;                 
        }
        public override string ToString()
        {
            return this.Bezeichnung;
        }
    }
}
