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
    public partial class Postavke : Form
    {
        public Postavke()
        {
            InitializeComponent();
        }

        private void btnSpremiPostavke_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Jeste li sigurni da želite promjeniti postavke?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                ApiCollector.SaverLoader.Jezik = cbJezik.GetItemText(this.cbJezik.SelectedItem);
                ApiCollector.SaverLoader.Prvenstvo = cbPrvenstvo.GetItemText(this.cbPrvenstvo.SelectedItem);

                MessageBox.Show("Postavke uspjesno promjenjene!");
            }
            if (res == DialogResult.No)
            {
                return;
            }
        }

        private void Postavke_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApiCollector.SaverLoader.SpremiJezikIPrvenstvo();
        }
    }
}
