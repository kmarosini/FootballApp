using ApiCollector;
using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballApp
{
    public partial class RangLista : Form
    {
       
        public RangLista()
        {
            InitializeComponent();
        }

        private async void RangLista_Load(object sender, EventArgs e)
        {
            List<ApiCollector.SkupIgraca> skupIgraca = await ApiCollector.PrepareForForm.DohvatiStatistikuIgraca();
            foreach (var igrac in skupIgraca)
            {
                flpStatistika.Controls.Add(new IgracStatistika(igrac));
            }


        }

        private void btnRangListPrint_Click_1(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

    }
}
