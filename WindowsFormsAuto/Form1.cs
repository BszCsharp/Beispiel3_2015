using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleAuto;
namespace WindowsFormsAuto
{
    public partial class FormStart : Form
    {
        List<Auto> lstAutos;
        public FormStart()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            lstAutos = new List<Auto>();
        }

        private void buttonAutoErzeugen_Click(object sender, EventArgs e)
        {
            Auto auto = new Auto(Convert.ToInt32(textBoxkmStand.Text));
            auto.Kennzeichen = textBoxKennzeichen.Text;
            auto.Verbrauch =   Convert.ToDouble( textBoxVerbrauch.Text);
            auto.MaxFuellmenge = Convert.ToDouble(textBoxMaxFuell.Text);
            lstAutos.Add(auto);
        }

        private void textBoxkmStand_Validating(object sender, CancelEventArgs e)
        {
            Int32 km  ;
            bool result;
            result = Int32.TryParse( textBoxkmStand.Text,out km);
            if(  !result || km < 0)
            {
                MessageBox.Show("km-Stand muss ganzahlig sein und > 0", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);             
                e.Cancel = true;
            }
            
        }

        private void buttonAutosAnzeigen_Click(object sender, EventArgs e)
        {
            //listBoxAutos.DataSource = lstAutos;
            //listBoxAutos.DisplayMember = "Kennzeichen";
            foreach(Auto a in lstAutos)
            {
                listBoxAutos.Items.Add(a.Kennzeichen);
            }
        }
    }
}
