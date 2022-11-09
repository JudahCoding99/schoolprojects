using System;
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
    /// Interaction logic for FriedPieCustomizationControl.xaml
    /// </summary>
    public partial class FriedPieCustomizationControl : UserControl
    {
        /// <summary>
        /// An instance of the main window is made
        /// </summary>
        MainWindow mWindow = (MainWindow)Application.Current.MainWindow;

        /// <summary>
        /// An imenu item is created it will be used to create a fried pie
        /// </summary>
        IMenuItem fp;
        public FriedPieCustomizationControl()
        {
            InitializeComponent();
            //fp = new FriedPie();
            //pFills.DataContext = fp;
            //mWindow.customerOrder.Add(fp);
        }
    }
}
