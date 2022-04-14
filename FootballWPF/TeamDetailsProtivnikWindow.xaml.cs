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
    /// Interaction logic for TeamDetailsProtivnikWindow.xaml
    /// </summary>
    public partial class TeamDetailsProtivnikWindow : Window
    {
        private ComboBox cb;
        public TeamDetailsProtivnikWindow(ComboBox cb)
        {
            InitializeComponent();
            this.cb = cb;
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<ApiCollector.Tim> list = await Collector.DohvatiMuskoPrvenstvo();

            var protivnik = this.cb.Text.Split('(', ')');
            var pro = protivnik[1];

            foreach (var x in list)
            {
                if (x.Fifa_code == pro)
                {
                    lblNaziv.Content = x.Country.ToString();
                    lblFifa.Content = x.Fifa_code;
                    lblOdigraniPobjede.Content = $"{x.Games_played}/{x.Wins}/{x.Losses}/{x.Draws}";
                    lblGoloviZabijeni.Content = $"{x.Goals_for}/{x.Goals_against}/{x.Goal_differential}";
                }
            }

        }
    }
}
