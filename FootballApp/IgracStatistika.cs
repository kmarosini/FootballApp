using ApiCollector;
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
    public partial class IgracStatistika : UserControl
    {
        private SkupIgraca igrac;
        public IgracStatistika(SkupIgraca igrac)
        {
            InitializeComponent();
            this.igrac = igrac;
        }

        private void IgracStatistika_Load(object sender, EventArgs e)
        {
            this.lblNaziv.Text = igrac.Name;
            this.lblBrojZabijenih.Text = igrac.GoalNumber.ToString();
            this.lblBrojZutih.Text = igrac.YellowCard.ToString();

            string picPath = $@"C:\Users\Korsnik\Desktop\OOP V2\KarloMarosini_FootballApp\FootballApp\MojiResursi\{igrac.Name}.jpg";

            if (File.Exists(picPath))
            {
                pbSlika.Image = Image.FromFile(picPath);
            }
            else
            {
                pbSlika.Image = Resursi.ikona;
            }

        }
    }
}
