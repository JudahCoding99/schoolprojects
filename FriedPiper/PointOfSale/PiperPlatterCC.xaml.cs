﻿using System;
using FriedPiper.Data.MenuItems;
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

namespace FriedPiper.PointOfSale
{
    /// <summary>
    /// Interaction logic for PiperPlatterCC.xaml
    /// </summary>
    public partial class PiperPlatterCC : UserControl
    {
        MainWindow mWindow = (MainWindow)Application.Current.MainWindow;

        //IMenuItem pipp;
        public PiperPlatterCC()
        {
            InitializeComponent();
        }
    }
}
