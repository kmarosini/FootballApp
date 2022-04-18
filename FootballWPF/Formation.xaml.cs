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
            List<ApiCollector.Tim> list = await Collector.DohvatiMuskoPrvenstvo();
            List<ApiCollector.SkupIgraca> list2 = await ApiCollector.PrepareForForm.DohvatiImenaIgraca();

            //foreach (var x in list)
            //{
            //    if (x.Fifa_code == SaverLoader.tim.Fifa_code)
            //    {
            //        foreach (var y in list2)
            //        {
            //            pnlIgraci.Children.Add(new Igrac());
            //        }
            //    }
            //}
        }
    }
}
