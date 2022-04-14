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
using System.Windows.Shapes;

namespace FootballWPF
{
    /// <summary>
    /// Interaction logic for TeamDetailsWindow.xaml
    /// </summary>
    public partial class TeamDetailsWindow : Window
    {
        public TeamDetailsWindow()
        {
            InitializeComponent();
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<ApiCollector.Tim> list = await Collector.DohvatiMuskoPrvenstvo();

            foreach (var x in list)
            {
                if (x.Fifa_code == SaverLoader.tim.Fifa_code)
                {
                    lblNaziv.Content = x.Country.ToString();
                    lblFifa.Content = x.Fifa_code;
                    lblOdigraniPobjede.Content = $"{x.Games_played}/{x.Wins}/{x.Losses}/{x.Draws}";
                    lblGoloviZabijeni.Content = $"{x.Goals_for}/{x.Goals_against}/{x.Goal_differential}";
                }
            }

            //lblNaziv.Content = SaverLoader.tim.Country.ToString();
            //lblFifa.Content = SaverLoader.tim.Fifa_code.ToString();
        }
    }
}
