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
    public partial class IgracInfo : UserControl
    {
        private SkupIgraca igrac;
        public bool Checked { get; set; }
        public IgracInfo(SkupIgraca igrac)
        {
            InitializeComponent();
            this.igrac = igrac;
        }
        private bool IsFavourite { get; set; }

        public SkupIgraca GetIgrac()
        {
            return igrac;
        }

        public void setFavourite()
        {
            IsFavourite = true;
            this.lblFavorit.Text = IsFavourite ? "*" : "";
        }

        private void IgracInfo_Load(object sender, EventArgs e)
        {
            this.lblIme.Text = igrac.Name;
            this.lblPozicija.Text = igrac.Position;
            this.lblBroj.Text = igrac.Shirt_number.ToString();
            this.lblKapetan.Text = igrac.Captain ? "KAPETAN" : "NE";
        }

        private void IgracInfo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.DoDragDrop(this, DragDropEffects.All | DragDropEffects.Move);
            }
        }

        // postavljanje checkbox value-a
        private void cbOdaberiIgraca_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = new CheckBox();
            checkBox.Checked = true;
        }
    }
}
