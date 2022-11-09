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
    /// Interaction logic for Popper.xaml
    /// </summary>
    public partial class PopperCC : UserControl
    {
        MainWindow mWindow = (MainWindow)Application.Current.MainWindow;

        IMenuItem popp;

        public PopperCC(string name, string action)
        {
            InitializeComponent();
            if(action == "Add")
            {
                chooseCorrectPopper(name);
            }            
            //Use helper method create the new instance of each class
            //Size.DataContext = new Popper();
        }

        //Make helper method
        /// <summary>
        /// Customizes the Menu Control based on the Tag of the BUtton presssed for each popper
        /// </summary>
        /// <param name="name">The type of popper passed in</param>
        public void chooseCorrectPopper(string name)
        {
            switch (name)
            {
                case "AppleFritters":
                    typePopper.Content = "Customize Apple Fritters";
                    popp = new AppleFritters();
                    Size.DataContext = popp;
                    GlazedCheck.DataContext = popp;
                    mWindow.customerOrder.Add(popp);
                    break;
                case "FriedBananas":
                    typePopper.Content = "Customize Fried Bananas";
                    popp = new FriedBananas();
                    Size.DataContext = popp;
                    GlazedCheck.DataContext = popp;
                    mWindow.customerOrder.Add(popp);
                    break;
                case "FriedCheesecake":
                    typePopper.Content = "Customize Fried Cheesecake";
                    popp = new FriedCheesecake();
                    Size.DataContext = popp;
                    GlazedCheck.DataContext = popp;
                    mWindow.customerOrder.Add(popp);
                    break;
                case "FriedOreos":
                    typePopper.Content = "Customize Fried Oreos";
                    popp = new FriedOreos();
                    Size.DataContext = popp;
                    GlazedCheck.DataContext = popp;
                    mWindow.customerOrder.Add(popp);
                    break;
                default:
                    typePopper.Content = "Customize Popper Platter";
                    popp = new PopperPlatter();
                    Size.DataContext = popp;
                    GlazedCheck.DataContext = popp;
                    mWindow.customerOrder.Add(popp);
                    break;
            }
        }
    }
}
