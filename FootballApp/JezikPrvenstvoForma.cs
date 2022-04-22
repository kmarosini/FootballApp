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
            if (SaverLoader.Jezik == "" || SaverLoader.Prvenstvo == "")
            {
                MessageBox.Show("Morate odabrati i jezik i prvenstvo!", "Warning");
            }
            else
            { 
                ChangeLanguage(cbJezik.GetItemText(this.cbJezik.SelectedItem));
                MessageBox.Show("Jezik i prvenstvo su spremljeni!", "Notification");
            } 
        }

        private void ChangeLanguage(string selectedItem)
        {
            if (selectedItem == "Hrvatski")
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
            JezikPrvenstvo();
        }

        private void JezikPrvenstvoForma_Load(object sender, EventArgs e)
        {
            JezikPrvenstvo();
        }

        private void JezikPrvenstvo()
        {
            this.lblIzabranoPrvenstvo.Text = SaverLoader.Prvenstvo;
            this.lblIzabraniJezik.Text = SaverLoader.Jezik;
        }
    }
}
