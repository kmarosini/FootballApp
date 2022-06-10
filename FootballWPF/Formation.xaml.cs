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
            try
            {
                List<ApiCollector.Games.Root> list = await PrepareForForm.DohvatiIgraca();
                Games.Root specific = list.Find((x =>
                {
                    if (x.home_team.code == SaverLoader.tim.Fifa_code && x.away_team.code == SaverLoader.protivnik)
                    {
                        return true;
                    }
                    if (x.home_team.code == SaverLoader.protivnik && x.away_team.code == SaverLoader.tim.Fifa_code)
                    {
                        return true;
                    }
                    return false;
                }));


                foreach (var igrac in specific.home_team_statistics.starting_eleven)
                {
                    if (igrac.Position == "Goalie")
                    {
                        this.Goalie.Children.Add(new Igrac(igrac));
                    }
                    if (igrac.Position == "Defender")
                    {
                        this.Defender.Children.Add(new Igrac(igrac));

                    }
                    if (igrac.Position == "Midfield")
                    {
                        this.Midfield.Children.Add(new Igrac(igrac));
                    }
                    if (igrac.Position == "Forward")
                    {
                        this.Forward.Children.Add(new Igrac(igrac));
                    }
                }


                foreach (var item in specific.away_team_statistics.starting_eleven)
                {
                    if (item.Position == "Goalie")
                    {
                        this.AwayGoalie.Children.Add(new Igrac(item));
                    }
                    if (item.Position == "Defender")
                    {
                        this.AwayDefender.Children.Add(new Igrac(item));

                    }
                    if (item.Position == "Midfield")
                    {
                        this.AwayMidfield.Children.Add(new Igrac(item));
                    }
                    if (item.Position == "Forward")
                    {
                        this.AwayForward.Children.Add(new Igrac(item));
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Niste izabrali protivnika!");
            } 
        }
    }
}
    

