using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApiCollector;


namespace FootballApp
{
    public partial class OmiljeniTim : Form
    {
        public OmiljeniTim()
        {
            InitializeComponent();
        }

        private async void OmiljeniTim_Load(object sender, EventArgs e)
        {
            List<ApiCollector.Tim> list = await Collector.DohvatiMuskoPrvenstvo();
            cbOmiljeniTim.DataSource = list;
            lblIzabraniTim.Text = SaverLoader.tim.Fifa_code;
        }

        private void btnSpremiOmiljeniTim_Click(object sender, EventArgs e)
        {
            SaverLoader.tim = new ApiCollector.Tim();
            var tim =(Tim)cbOmiljeniTim.SelectedValue;
            SaverLoader.tim.Fifa_code = tim.Fifa_code;
            

            MessageBox.Show("Omiljeni tim je spremljen!");

            RefreshUserInterface();
        }

        private void RefreshUserInterface()
        {
            this.Controls.Clear();
            InitializeComponent();
            OmiljeniTimIspis();
        }

        private void OmiljeniTimIspis()
        {
            this.lblIzabraniTim.Text = SaverLoader.tim.Fifa_code.ToString();
        }
    }
}
