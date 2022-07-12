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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FootballWPF
{
    /// <summary>
    /// Interaction logic for Postavke.xaml
    /// </summary>
    public partial class Postavke : Page
    {
        public Postavke()
        {
            InitializeComponent();
            IspisPostavki();
        }

        private void IspisPostavki()
        {
            lblJezik.Content = $"{Properties.Resources.OdabraniJezik} {SaverLoader.Jezik}";
            lblPrvenstvo.Content = $"{Properties.Resources.OdabranoPrvenstvo} {SaverLoader.Prvenstvo}";
            lblScreenSize.Content = $"{Properties.Resources.OdabranaRezolucija} {SaverLoader.Resolution}";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = System.Windows.MessageBox.Show(Properties.Resources.PromjenaPostavkiMB, Properties.Resources.UpozorenjeMB, MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                SaverLoader.Jezik = cbJezik.Text;
                SaverLoader.Prvenstvo = cbPrvenstvo.Text;
                SaverLoader.Resolution = cbResolution.Text;
                if (SaverLoader.Jezik == "" || SaverLoader.Prvenstvo == "" || SaverLoader.Resolution == "")
                {
                    System.Windows.MessageBox.Show(Properties.Resources.JezikPrvenstvoRezolucijaWar, Properties.Resources.UpozorenjeMB);
                }
                else
                {
                    System.Windows.MessageBox.Show(Properties.Resources.JezikSpremljen, Properties.Resources.UpozorenjeMB);
                    SaverLoader.SpremiJezikIPrvenstvo();
                    LangChampPage.ResizeWindow();

                }
            }
            if (result == MessageBoxResult.No)
            {
                return;
            }      
        }
    }
}
