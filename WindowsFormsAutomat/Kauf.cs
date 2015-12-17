using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsAutomat
{
    public class Kauf
    {
        private Artikel artikel;

        public Artikel Artikel
        {
            get { return artikel; }
            set { artikel = value; }
        }
        private decimal rueckgeld;

        public Kauf(Artikel a)
        {
            this.Artikel = a;
        }

        public decimal Zahlen(decimal betrag)
        {
            this.rueckgeld = betrag - this.Artikel.Preis;
            return (rueckgeld);
        }
    }
}
