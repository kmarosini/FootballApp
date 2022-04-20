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
            this.textBox1.Visible = false;
           
            if (pbSlika.Image == null)
            {
                pbSlika.Image = Resursi.ikona;
            }
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

        private void PrikaziSliku()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = open.FileName;
                pbSlika.Image = new Bitmap(open.FileName);
            }
        }

        private void pbSlika_DoubleClick(object sender, EventArgs e)
        {
            PrikaziSliku();
        }

        private void SpremiSlike()
        {
            File.Copy(textBox1.Text, Path.Combine(@"C:\Users\programer10\Desktop\Karlo\FootballApp\MojiResursi\", Path.GetFileName(textBox1.Text)), true);
            MessageBox.Show("Uspjesno spremljena slika!", "Notification");
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            SpremiSlike();
        }
    }
}
