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
    public partial class OmiljeniIgraci : Form
    {
        public OmiljeniIgraci()
        {
            InitializeComponent();
        }

        private async void OmiljeniIgraci_Load(object sender, EventArgs e)
        {
            List<ApiCollector.SkupIgraca> list = await ApiCollector.PrepareForForm.DohvatiImenaIgraca();
            foreach (var igrac in list)
            {
                flpSviIgraci.Controls.Add(new IgracInfo(igrac));
            }
            if (ApiCollector.PrepareForForm.favourites == null)
            {
                return;
            }
            foreach (var item in ApiCollector.PrepareForForm.favourites)
            {
                flpFavoritIgraci.Controls.Add(new IgracInfo(item));
            }
        }

        private void flpFavoritIgraci_DragDrop(object sender, DragEventArgs e)
        {
            Control.ControlCollection ctrlCollection = this.flpFavoritIgraci.Controls;
            int count = ctrlCollection.Count;

            if (count >= 3)
            {
                MessageBox.Show("You cant choose more than 3 favourite players!");
                return;
            }

            IgracInfo igrc = (IgracInfo)e.Data.GetData(typeof(IgracInfo));
            this.flpFavoritIgraci.Controls.Add(igrc);

            // deserializacija string -> objekt
            // serijalizacija objekt -> string

            // svi koji su dragndropani markiraj ih sa zvjezdom
            ApiCollector.PrepareForForm.favourites.Clear();

            foreach (IgracInfo c in this.flpFavoritIgraci.Controls)
            {
                c.setFavourite();
                ApiCollector.PrepareForForm.InsertInList(c.GetIgrac());
            }
        }

        private void flpFavoritIgraci_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void btnResetOmiljenihIgraca_Click(object sender, EventArgs e)
        {
            flpFavoritIgraci.Controls.Clear();
            ApiCollector.PrepareForForm.favourites.Clear();
        }
    }
}
