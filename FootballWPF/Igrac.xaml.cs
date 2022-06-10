using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ApiCollector;

namespace FootballWPF
{
    /// <summary>
    /// Interaction logic for Igrac.xaml
    /// </summary>
    public partial class Igrac : UserControl
    {
        private SkupIgraca igrac;
        public Igrac(SkupIgraca igrac)
        {
            InitializeComponent();
            this.igrac = igrac;
        }

        private void ucIgrac_Loaded(object sender, RoutedEventArgs e)
        {
            string picPath = $@"..\..\..\Slike\{igrac.Name}.jpg";
            if (File.Exists(picPath))
            {
                Bitmap bitmap = (Bitmap)System.Drawing.Image.FromFile(picPath);
                MemoryStream ms = new MemoryStream();
                bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                BitmapImage igrc = new BitmapImage();
                
                igrc.BeginInit();
                igrc.CacheOption = BitmapCacheOption.OnLoad;
                igrc.StreamSource = ms;
                igrc.EndInit();
                this.imgIgrac.Source = igrc;
            }
            else
            {
                this.imgIgrac.Source = null;
            }






            this.lblIgrac.Content = igrac.Name;
            this.lblNumber.Content = igrac.Shirt_number;

        }

        private void ucIgrac_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            PlayerWindow player = new PlayerWindow(igrac);
            player.Show();
        }
    }
}
