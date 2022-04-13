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
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SaverLoader.Jezik = cbJezik.Text;
            SaverLoader.Prvenstvo = cbPrvenstvo.Text;
            SaverLoader.Resolution = cbResolution.Text;



            MessageBox.Show("Jezik i prvenstvo su spremljeni!");
            SaverLoader.SpremiJezikIPrvenstvo();
            ResizeWindow();
        }

        private void ResizeWindow()
        {
            if (SaverLoader.Resolution == "Fullscreen")
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized; 
            }
            if (SaverLoader.Resolution == "Medium")
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
            }
            if (SaverLoader.Resolution == "Small")
            {
                Application.Current.MainWindow.WindowState = WindowState.Minimized;
            }
        }
    }
}
