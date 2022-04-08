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
            foreach (ApiCollector.Tim tim in list)
            {
                this.cbOmiljeniTim.Items.Add($"{tim.Country} ({tim.Fifa_code})");
            }
        }

        private void btnSpremiOmiljeniTim_Click(object sender, EventArgs e)
        {
            SaverLoader.tim = new ApiCollector.Tim();
            string fifaCode = cbOmiljeniTim.GetItemText(this.cbOmiljeniTim.SelectedItem);
            SaverLoader.tim.Fifa_code = fifaCode.Remove(0, fifaCode.IndexOf(' ')).Replace('(', ' ').Replace(')', ' ').Trim();

            MessageBox.Show("Omiljeni tim je spremljen!");
        }
    }
}
