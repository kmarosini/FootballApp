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
        private Bitmap bmp;
        private List<Bitmap> bmpList = new List<Bitmap>();
        public RangLista()
        {
            InitializeComponent();
        }

        private async void RangLista_Load(object sender, EventArgs e)
        {
            imgLoad.Visible = true;

            List<ApiCollector.SkupIgraca> skupIgraca = await PrepareForForm.DohvatiStatistikuIgraca();
            foreach (var igrac in skupIgraca)
            {
                flpStatistika.Controls.Add(new IgracStatistika(igrac));
            }

            imgLoad.Visible = false;
        }

        private void btnRangListPrint_Click_1(object sender, EventArgs e)
        {
            foreach (IgracStatistika item in flpStatistika.Controls)
            {
                Bitmap testing = new Bitmap(item.Width, item.Height);
                item.DrawToBitmap(testing, new Rectangle(0, 0, item.Width, item.Height));
                bmpList.Add(testing);
            }
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int yGoUnder = 10;
            int xGoUnder = 10;
            foreach (Bitmap item in bmpList)
            {
                if (yGoUnder > 1100)
                {
                    yGoUnder= 10;
                    xGoUnder += 270;
                }
                e.Graphics.DrawImage(item, xGoUnder, yGoUnder);
                yGoUnder += 115;
            }
        }
    }
}
