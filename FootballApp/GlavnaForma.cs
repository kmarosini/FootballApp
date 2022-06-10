using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApiCollector;

namespace FootballApp
{
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();

            
            if (!SaverLoader.CreateFile())
            {
                pnlGlavniPanel.Controls.Clear();
                PrikaziFormuUPanelu(new JezikPrvenstvoForma());
            }
            else
            {
                pnlGlavniPanel.Controls.Clear();
                PrikaziFormuUPanelu(new OmiljeniTim());
            }
            SaverLoader.NapraviOmiljeniIgraciFile();
            SaverLoader.LoadFavoritIgrace();
        }

        public void PrikaziFormuUPanelu(Form forma)
        {
            pnlGlavniPanel.Controls.Clear();
            forma.TopLevel = false;
            pnlGlavniPanel.Controls.Add(forma);
            forma.Show();
        }

        private void btnJezikPrvenstvo_Click(object sender, EventArgs e)
        {
            PrikaziFormuUPanelu(new JezikPrvenstvoForma());
        }

        private void btnOmiljeniTim_Click(object sender, EventArgs e)
        {
            PrikaziFormuUPanelu(new OmiljeniTim());

        }

        private void GlavnaForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaverLoader.SpremiJezikIPrvenstvo();
            SaverLoader.SpremiOmiljeneIgrace();
        }

        private void btnOmiljeniIgraci_Click(object sender, EventArgs e)
        {
            PrikaziFormuUPanelu(new OmiljeniIgraci());

        }

        private void btnRangLista_Click(object sender, EventArgs e)
        {
            PrikaziFormuUPanelu(new RangLista());
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            PrikaziFormuUPanelu(new InformacijeOUtakmici());
        }

        private void btnPostavke_Click(object sender, EventArgs e)
        {
            PrikaziFormuUPanelu(new Postavke());
        }
    }
}
