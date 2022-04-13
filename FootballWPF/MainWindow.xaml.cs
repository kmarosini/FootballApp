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
            SaverLoader.UcitajPostavke();
            ProvjeriRezoluciju();
            if (!SaverLoader.CreateFile())
            {
                Main.Content = new LangChampPage();
            }
            else
            {
                Main.Content = new ResultPage();
            }
        }

        private void ProvjeriRezoluciju()
        {
            if (SaverLoader.Resolution == "Fullscreen")
            {
                WindowState = WindowState.Maximized;
            }
            if (SaverLoader.Resolution == "Medium")
            {
                WindowState = WindowState.Normal;
            }
            if (SaverLoader.Resolution == "Small")
            {
                WindowState = WindowState.Minimized;
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
    }
}
