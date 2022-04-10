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

namespace FootballAppWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (cbResolution.Text == "Fullscreen")
            {
                WindowState = WindowState.Maximized;
            }
            if (cbResolution.Text == "Medium")
            {
                WindowState = WindowState.Normal;
            }
            if (cbResolution.Text == "Small")
            {
                WindowState = WindowState.Minimized;
            }

            SaverLoader.Jezik = cbJezik.Text;
            SaverLoader.Prvenstvo = cbPrvenstvo.Text;

            MessageBox.Show("Jezik i prvenstvo su spremljeni!");
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SaverLoader.SpremiJezikIPrvenstvo();
        }
    }
}
