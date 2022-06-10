using ApiCollector;
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
using System.Windows.Shapes;

namespace FootballWPF
{
    /// <summary>
    /// Interaction logic for PlayerWindow.xaml
    /// </summary>
    public partial class PlayerWindow : Window
    {
        private SkupIgraca igrac;

        public PlayerWindow(SkupIgraca igrac)
        {
            InitializeComponent();
            this.igrac = igrac;
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //List<ApiCollector.SkupIgraca> skupIgraca = await ApiCollector.PrepareForForm.DohvatiStatistikuIgraca();
            List<SkupIgraca> skup = await  PrepareForForm.DohvatiImenaIgraca();
         

            foreach (var statistic in skup)
            {
                if (statistic.Name == igrac.Name)
                {
                    lblIme.Content = statistic.Name;
                    lblPozicija.Content = statistic.Position;
                    lblBrojZutih.Content = statistic.YellowCard;
                    lblBrojZabijenih.Content = statistic.GoalNumber;
                    lblKapetan.Content = statistic.Captain;
                    lblBroj.Content = statistic.Shirt_number;

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
                        this.imgSlika.Source = igrc;
                    }
                    else
                    {
                        this.imgSlika.Source = null;
                    }
                }
            }
        }
    }
}
