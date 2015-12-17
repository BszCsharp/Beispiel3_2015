using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAutomat
{
    public partial class Form1 : Form
    {
        Artikel[] artikelArray = new Artikel[5];
        Kauf k = null;
        Decimal gesamt = 0;
        Artikel selArticle;
        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            artikelArray[0] = new Artikel(20, "Gummibärchen", 0.8m);
            artikelArray[1] = new Artikel(20, "Orangensaft", 0.55m);
            artikelArray[2] = new Artikel(20, "Schokotafel", 0.95m);
            artikelArray[3] = new Artikel(20, "Schokoriegel", 0.85m);
            artikelArray[4] = new Artikel(0, "Käsewaffel", 1.20m);

            comboBoxArtikel.Items.Add(artikelArray[0].Bezeichnung);
            comboBoxArtikel.Items.Add(artikelArray[1].Bezeichnung);
            comboBoxArtikel.Items.Add(artikelArray[2].Bezeichnung);
            comboBoxArtikel.Items.Add(artikelArray[3].Bezeichnung);
            comboBoxArtikel.Items.Add(artikelArray[4].Bezeichnung);

        }

        private void comboBoxArtikel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxArtikel.SelectedIndex;
            selArticle = artikelArray[index];
            
            k = new Kauf(selArticle);

            labelPreis.Text = k.Artikel.Preis.ToString();
           
            labelMeldung.Text = "";
            if (k.Artikel.Bestand > 0) buttonZahlen.Enabled = true;
            else buttonZahlen.Enabled = false;
        }

        private void buttonMoney_Click(object sender, EventArgs e)
        {
            if (k.Artikel.Bestand > 0)
            {
                Button b = (Button)sender;
                //String txt = b.Tag;
                Decimal preis = Convert.ToDecimal(b.Tag);
                gesamt += preis;
                labelSumme.Text = gesamt.ToString();
            }
            else
            {
                labelMeldung.Text = k.Artikel.Bezeichnung + " ausverkauft";
            }

        }

        private void buttonZahlen_Click(object sender, EventArgs e)
        {
 
                if (k.Artikel.Preis <= gesamt)
                {
                    decimal rueck = k.Zahlen(gesamt);
                    labelRueck.Text = rueck.ToString();
                    labelMeldung.Text = "Danke für ihren " + k.Artikel.Bezeichnung + "-Einkauf";
                    labelSumme.Text = "0";
                    gesamt = 0;
                
                }
                else
                {
                    labelMeldung.Text = "Nicht genügend Geld eingeworfen";
                }
                     
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            labelSumme.Text = "0";
            gesamt = 0;
            labelRueck.Text = "0";
            labelMeldung.Text = "";
        }
    }
}
