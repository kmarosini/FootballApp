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
    public partial class Postavke : Form
    {
        public Postavke()
        {
            InitializeComponent();
        }

        private void btnSpremiPostavke_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(Properties.Resources.PostavkePromjena, Properties.Resources.Notifikacija, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                ApiCollector.SaverLoader.Jezik = cbJezik.GetItemText(this.cbJezik.SelectedItem);
                ApiCollector.SaverLoader.Prvenstvo = cbPrvenstvo.GetItemText(this.cbPrvenstvo.SelectedItem);

                if (SaverLoader.Jezik == "" || SaverLoader.Prvenstvo == "")
                {
                    MessageBox.Show(Properties.Resources.JezikUpozorenje, Properties.Resources.UpozorenjeUpozorenje);
                }
                else
                {
                    ChangeLanguage(cbJezik.GetItemText(this.cbJezik.SelectedItem));
                    MessageBox.Show(Properties.Resources.JezikPrvenstvoSpremljeni, Properties.Resources.Notifikacija);
                }

            }
            if (res == DialogResult.No)
            {
                return;
            }
        }

        private void ChangeLanguage(string v)
        {
            if (v == "Hrvatski")
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("hr-HR");
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("hr-HR");
            }
            else
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            }

            RefreshUserInterface();
        }

        private void RefreshUserInterface()
        {
            this.Controls.Clear();
            InitializeComponent();
        }

        private void Postavke_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApiCollector.SaverLoader.SpremiJezikIPrvenstvo();
        }
    }
}
