﻿using ApiCollector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballApp
{
    public partial class OmiljeniIgraci : Form
    {

        public static int counter = 0;

        public OmiljeniIgraci()
        {
            InitializeComponent();
        }

        private async void OmiljeniIgraci_Load(object sender, EventArgs e)
        {
            imgLoad.Visible = true;

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

            imgLoad.Visible = false;
        }

        private void LoadExcel()
        {
            // some work takes 5 sec
            Thread.Sleep(5000);
        }

        private void flpFavoritIgraci_DragDrop(object sender, DragEventArgs e)
        {
            Control.ControlCollection ctrlCollection = this.flpFavoritIgraci.Controls;
            int count = ctrlCollection.Count;
            List<IgracInfo> list = new List<IgracInfo>();

            if (count >= 3)
            {
                MessageBox.Show(Properties.Resources.ViseIgraca);
                return;
            }

            IgracInfo igrc = (IgracInfo)e.Data.GetData(typeof(IgracInfo));

            this.flpFavoritIgraci.Controls.Add(igrc);


            //Izbaci duplikata iz liste

            foreach (IgracInfo item in flpSviIgraci.Controls)
            {
               
                    if (item.Checked == true)
                    {
                        list.Add(item);
                    }
               
            }


            list.ForEach(item => this.flpFavoritIgraci.Controls.Add((IgracInfo)item));


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
            OmiljeniIgraci.counter = 0;
        }
    }
}
