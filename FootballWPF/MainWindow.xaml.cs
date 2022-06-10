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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            if (!SaverLoader.CreateFile())
            {
                Main.Content = new LangChampPage();
            }
            else
            {
                Main.Content = new ResultPage();
            }
            SaverLoader.UcitajPostavke();
            ProvjeriRezoluciju();
            
        }

        private void ProvjeriRezoluciju()
        {
            if (SaverLoader.Resolution == "Fullscreen")
            {
                WindowState = WindowState.Maximized;
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

        private void btnJezikPrvenstvo_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new LangChampPage();
        }

        private void btnResultPage_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new ResultPage();
        }

        private void btnFormation_OnClick(object sender, RoutedEventArgs e)
        {
            Main.Content = new Formation();
        }

        private void btnSettings_OnClick(object sender, RoutedEventArgs e)
        {
            Main.Content = new Postavke();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = System.Windows.MessageBox.Show("Jeste li sigurni da želite izaći iz aplikacije?", "Upozorenje", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                return;
            }
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
