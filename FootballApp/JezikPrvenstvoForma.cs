using ApiCollector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballApp
{
    public partial class JezikPrvenstvoForma : Form
    {
        public JezikPrvenstvoForma()
        {
            InitializeComponent();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            SaverLoader.Jezik = cbJezik.GetItemText(this.cbJezik.SelectedItem);
            SaverLoader.Prvenstvo = cbPrvenstvo.GetItemText(this.cbPrvenstvo.SelectedItem);

            MessageBox.Show("Jezik i prvenstvo su spremljeni!");
        }

        private void JezikPrvenstvoForma_Load(object sender, EventArgs e)
        {
            this.lblIzabranoPrvenstvo.Text = SaverLoader.Prvenstvo;
            this.lblIzabraniJezik.Text = SaverLoader.Jezik;
        }
    }
}
