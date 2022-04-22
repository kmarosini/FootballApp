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
            string picPath = $@"C:\Users\Korsnik\Desktop\OOP V2\KarloMarosini_FootballApp\FootballApp\MojiResursi\{igrac.Name}.jpg";

            if (File.Exists(picPath))
            {
                pbSlika.Image = Image.FromFile(picPath);
            }
            else
            {
                pbSlika.Image = Resursi.ikona;
            }

           
            //if (pbSlika.Image == null)
            //{
            //    pbSlika.Image = Resursi.ikona;
            //}
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
            if (OmiljeniIgraci.counter < 3)
            {
                Checked = cbOdaberiIgraca.Checked;
                OmiljeniIgraci.counter++;
            }
            else
            {
                cbOdaberiIgraca.Checked = false;
                return;     
            }   
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
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "*.jpg; *.jpeg; *.gif; *.bmp)| *.jpg; *.jpeg; *.gif; *.bmp";
            save.FileName = igrac.Name;
            save.DefaultExt = "*.jpg";
            save.InitialDirectory = @"C:\Users\Korsnik\Desktop\OOP V2\KarloMarosini_FootballApp\FootballApp\MojiResursi\";

            if (save.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image.Save(save.FileName);
                MessageBox.Show("Uspjesno spremljena slika!", "Notification");
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            SpremiSlike();
        }
    }
}
