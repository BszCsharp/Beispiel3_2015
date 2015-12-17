using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAuto
{
    class Auto
    {
        Double verbrauch;
        private int kmStand;
        public Auto(int kmStand)
        {
            this.KmStand = kmStand;
        }
        public int KmStand
        {
            get { return kmStand; }
            private set { kmStand = value; }
        }
        private Double akuelleFuellung;

        public Double AkuelleFuellung
        {
            get { return akuelleFuellung; }
            set { akuelleFuellung = value; }
        }
        private Double maxFuellmenge;

        public Double MaxFuellmenge
        {
            get { return maxFuellmenge; }
            set { maxFuellmenge = value; }
        }

        public Double Verbrauch
        {
            get { return verbrauch; }  // Leserichtung
            set { verbrauch = value; } // Schreibrichtung
        }

        public int Fahren(int anzahlKm)
        {
            int reichweite = Convert.ToInt32( 100 / this.Verbrauch * this.AkuelleFuellung);
            int result;

            if( reichweite >= anzahlKm )
            {
                result = anzahlKm;
                this.KmStand += anzahlKm;
                this.AkuelleFuellung -= this.Verbrauch / 100 * anzahlKm;
            }
            else
            {
                result = reichweite;
                this.KmStand += reichweite;
                this.AkuelleFuellung = 0;
            }
            return result;
        }

        public double Tanken(double menge)
        {
            Double result = 0;
            Double maxLiter = this.MaxFuellmenge - this.AkuelleFuellung;
            if( maxLiter >= menge)
            {
                this.AkuelleFuellung += menge; ;
                result = menge;
            }
            else
            {
                this.AkuelleFuellung = this.MaxFuellmenge;
                result = maxLiter;
            }
            return result;
        }
        String kennzeichen;

        public String Kennzeichen
        {
            get { return kennzeichen; }
            set { kennzeichen = value; }
        }

    }
}
