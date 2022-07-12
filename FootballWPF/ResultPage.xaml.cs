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
    /// Interaction logic for ResultPage.xaml
    /// </summary>
    public partial class ResultPage : Page
    {
        public ResultPage()
        {
            InitializeComponent();
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            List<ApiCollector.Tim> list = await Collector.DohvatiMuskoPrvenstvo();
            Dictionary<string, string> dictionary = await PrepareForForm.DohvatiProtivnike();
            foreach (KeyValuePair<string,string> pair in dictionary)
            {
                this.cbProtivnik.Items.Add($"{pair.Value} ({pair.Key})");
            }

            cbOmiljenaReprezentacija.ItemsSource = list;
            try
            {
                lblIzabrana.Content = $"{Properties.Resources.Reprezentacija} {SaverLoader.tim.Fifa_code}";

            }
            catch (Exception ex)
            {

                MessageBox.Show(Properties.Resources.NisteOdabraliReprezentaciju);
            }

        }


        private void PromijeniReprezentaciju_OnClick(object sender, RoutedEventArgs e)
        {
            SaverLoader.tim = new ApiCollector.Tim();
            var tim = (Tim)cbOmiljenaReprezentacija.SelectedValue;
            if (cbOmiljenaReprezentacija.SelectedValue == null)
            {
                MessageBox.Show(Properties.Resources.NisteOdabraliReprezentaciju);
            }
            else
            {
                SaverLoader.tim.Fifa_code = tim.Fifa_code;
                SaverLoader.SpremiJezikIPrvenstvo();
                MessageBox.Show(Properties.Resources.TimPromjenjen);
            }
            
        }

        private async void btnSpremi_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var prviTim = SaverLoader.tim.Fifa_code;
                var drugiTim = cbProtivnik.Text.Split('(', ')');
                SaverLoader.protivnik = drugiTim[1];

                List<Games.Root> listaMeceva = await PrepareForForm.DohvatiIgraca();


                foreach (var item in listaMeceva)
                {
                    if (item.home_team.code == prviTim && item.away_team.code == SaverLoader.protivnik)
                    {
                        lblProtivnik.Content = item.away_team.goals.ToString();
                        lblFavorit.Content = item.home_team.goals.ToString();
                    }
                    if (item.away_team.code == prviTim && item.home_team.code == SaverLoader.protivnik)
                    {
                        lblFavorit.Content = item.away_team.goals.ToString();
                        lblProtivnik.Content = item.home_team.goals.ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Properties.Resources.Protivnik);
            }
        }

        private void btnFavoritDetalji_OnClick(object sender, RoutedEventArgs e)
        {
            TeamDetailsWindow favorit = new TeamDetailsWindow();
            favorit.Show();
        }

        private void btnProtivnikDetalji_OnClick(object sender, RoutedEventArgs e)
        {
            TeamDetailsProtivnikWindow protivnik = new TeamDetailsProtivnikWindow(this.cbProtivnik);
            protivnik.Show();
        }

    }
}
