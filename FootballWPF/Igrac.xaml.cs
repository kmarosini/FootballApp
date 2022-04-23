﻿using System;
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
using ApiCollector;

namespace FootballWPF
{
    /// <summary>
    /// Interaction logic for Igrac.xaml
    /// </summary>
    public partial class Igrac : UserControl
    {
        private SkupIgraca igrac;
        public Igrac(SkupIgraca igrac)
        {
            InitializeComponent();
            this.igrac = igrac;
        }

        private void ucIgrac_Loaded(object sender, RoutedEventArgs e)
        {
            this.lblIgrac.Content = igrac.Name;
        }
    }
}
