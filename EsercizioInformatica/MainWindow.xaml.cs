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

namespace EsercizioInformatica
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

        private void btncalcola_Click(object sender, RoutedEventArgs e)
        {
            int rate = int.Parse(txtrate.Text);
            int perc = int.Parse(txtpercentuale.Text);
            int importo = int.Parse(txtimporto.Text);
            int impdr = int.Parse(txtimportodarestituire.Text);
            int impr = int.Parse(txtimportorata.Text);
            int calcoloperc = (perc * importo/100)+importo;
            lblimpdarestituire.Content = impdr;
            impr = impdr /rate;
            lblimportorata.Content = ;

        }
    }
}
