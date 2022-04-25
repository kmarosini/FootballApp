using ApiCollector;
using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            dgvRangLista.DataSource = skupIgraca;
            CheckForPicture();
        }

        private async void CheckForPicture()
        {
            List<ApiCollector.SkupIgraca> list = await ApiCollector.PrepareForForm.DohvatiImenaIgraca();
            
  
            foreach (var igrac in list)
            {
                var pic = $@"C:\Users\programer10.UCIONE.002\Desktop\km\FootballApp\MojiResursi\{igrac.Name}.jpg";
               
                if (File.Exists(pic))
                {
                    Bitmap img = (Bitmap)Bitmap.FromFile(pic);

                }
            }
            
        }

        private void btnRangListPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Karlo's Soccer App";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "KarloMarosini";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvRangLista);
        }


    }
}
