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
    /// Interaction logic for LangChampPage.xaml
    /// </summary>
    public partial class LangChampPage : Page
    {
        public LangChampPage()
        {
            InitializeComponent();
            IspisPostavki();
            ResizeWindow();
        }

        private void IspisPostavki()
        {
            lblJezik.Content = $"ODABRANI JEZIK: {SaverLoader.Jezik}";
            lblPrvenstvo.Content = $"ODABRANO PRVENSTVO: {SaverLoader.Prvenstvo}";
            lblScreenSize.Content = $"ODABRANA REZOLUCIJA: {SaverLoader.Resolution}";
        }

        private void btnSpremi_Click(object sender, RoutedEventArgs e)
        {
            SaverLoader.Jezik = cbJezik.Text;
            SaverLoader.Prvenstvo = cbPrvenstvo.Text;
            SaverLoader.Resolution = cbResolution.Text;
            if (SaverLoader.Jezik == "" || SaverLoader.Prvenstvo == "" || SaverLoader.Resolution == "")
            {
                MessageBox.Show("Morate odabrati i jezik, prvenstvo i rezoluciju!", "Warning");
            }
            else
            {
                MessageBox.Show("Jezik i prvenstvo su spremljeni!", "Notification");
                SaverLoader.SpremiJezikIPrvenstvo();
                ResizeWindow();
            }
        }

        public static void ResizeWindow()
        {
            if (SaverLoader.Resolution == "Fullscreen")
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized; 
            }
            if (SaverLoader.Resolution == "Medium")
            {
                Application.Current.MainWindow.Height = 800;
                Application.Current.MainWindow.Width = 1200;
            }
            if (SaverLoader.Resolution == "Small")
            {
                Application.Current.MainWindow.Height = 500;
                Application.Current.MainWindow.Width = 500;
            }
        }
    }
}
