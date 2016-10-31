using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MWODati
{
    public partial class Form1 : Form
    {
        //public string[] fileSeason1 { get; set; } = null;
        //public string[] fileSeason2 { get; set; } = null;
        //public string[] fileSeason3 { get; set; } = null;

        

        public Form1()
        {
            InitializeComponent();
            try
            {
                string url = Config.Season3URL;
                Config.fileSeason3 = Funzioni.retriveData(url);

                url = Config.Season2URL;
                Config.fileSeason2 = Funzioni.retriveData(url);

                url = Config.Season1URL;
                Config.fileSeason1 = Funzioni.retriveData(url);
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string risultato = Funzioni.Ricerca(1, txtNomeRicerca.Text);
            risultato += Funzioni.Ricerca(2, txtNomeRicerca.Text);
            txtRisultato.Text = risultato;
            chart1.Series.Clear();
            chart1.Series.Add(xx);
        }

        private void chbGeneral_CheckedChanged(object sender, EventArgs e)
        {
            if(chbGeneral.Checked == true)
            {
                chbAssault.Enabled = false;
                chbAssault.Checked = false;
                chbHeavy.Enabled = false;
                chbHeavy.Checked = false;
                chbMedium.Enabled = false;
                chbMedium.Checked = false;
                chbLight.Enabled = false;
                chbLight.Checked = false;
            }
            else
            {
                chbAssault.Enabled = true;
                //chbAssault.Checked = true;
                chbHeavy.Enabled = true;
                //chbHeavy.Checked = true;
                chbMedium.Enabled = true;
                //chbMedium.Checked = true;
                chbLight.Enabled = true;
                //chbLight.Checked = true;
            }
        }

        private void chbLight_CheckedChanged(object sender, EventArgs e)
        {
            if(chbLight.Checked == true)
            {
                chbGeneral.Checked = false;
                chbGeneral.Enabled = false;
            }
            else
            {
                chbGeneral.Enabled = true;
            }
        }

        private void chbMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMedium.Checked == true)
            {
                chbGeneral.Checked = false;
                chbGeneral.Enabled = false;
            }
            else
            {
                chbGeneral.Enabled = true;
            }
        }

        private void chbHeavy_CheckedChanged(object sender, EventArgs e)
        {
            if (chbHeavy.Checked == true)
            {
                chbGeneral.Checked = false;
                chbGeneral.Enabled = false;
            }
            else
            {
                chbGeneral.Enabled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
