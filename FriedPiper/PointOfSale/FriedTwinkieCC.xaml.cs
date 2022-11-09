using System;
using System.Collections.Generic;
using FriedPiper.Data.MenuItems;
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
    /// Interaction logic for FriedTwinkie.xaml
    /// </summary>
    public partial class FriedTwinkieCC : UserControl
    {
        MainWindow mWindow = (MainWindow)Application.Current.MainWindow;

        //IMenuItem ft;
        public FriedTwinkieCC()
        {
            InitializeComponent();
            //ft = new FriedTwinkie();
            //mWindow.customerOrder.Add(ft);
        }
    }
}
