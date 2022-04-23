using ApiCollector;
using System;
using System.Collections.Generic;
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

namespace FootballWPF
{
    /// <summary>
    /// Interaction logic for Formation.xaml
    /// </summary>
    public partial class Formation : Page
    {
        public Formation()
        {
            InitializeComponent();
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //List<ApiCollector.Games.Root> list = await PrepareForForm.DohvatiIgraca();
            //List<ApiCollector.SkupIgraca> igraci = await ApiCollector.PrepareForForm.DohvatiImenaIgraca();

            //foreach (var item in list)
            //{
            //    if (item.home_team.code == SaverLoader.tim.Fifa_code)
            //    {
            //        foreach (var igrac in item.home_team_statistics.starting_eleven)
            //        {
            //            if (igrac.Position == "Goalie")
            //            {
            //                this.Goalie.Children.Add(new Igrac(igrac));
            //            }
            //            if (igrac.Position == "Defender")
            //            {
            //                this.Defender.Children.Add(new Igrac(igrac));
            //            }
            //            if (igrac.Position == "Midfield")
            //            {
            //                this.Midfield.Children.Add(new Igrac(igrac));
            //            }
            //            if (igrac.Position == "Forward")
            //            {
            //                this.Forward.Children.Add(new Igrac(igrac));
            //            }
            //        }
            //    }
            //}
        }
    }
}
