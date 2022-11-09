using System;
using FriedPiper.Data;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// An order object to keep track of the menu items added to the current customer order
        /// </summary>
        public Order customerOrder; 

        public MainWindow()
        {
            InitializeComponent();
            customerOrder = new Order(); 
            orderSumCntrl.DataContext = customerOrder;
            completeOrderButton.IsEnabled = false;
            selectMoreButton.IsEnabled = false;
        }

        /// <summary>
        /// sdffsd
        /// </summary>
        /// <param name="sender">sdf</param>
        /// <param name="e">sdf</param>
        void onButtonPress(object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource is MenuItemButton button)
            {
                e.Handled = true;
                
                switch (button.Tag.ToString())
                {
                    case "FriedPie":                        
                        var fpcc = new FriedPieCustomizationControl();
                        IMenuItem fp = new FriedPie();
                        fpcc.DataContext = fp;
                        customerOrder.Add(fp);
                        toggle.Child = fpcc;
                        completeOrderButton.IsEnabled = true;
                        selectMoreButton.IsEnabled = true;
                        break;
                    case "FriedIceCream":
                        var ficcc = new FriedIceCreamCustomizationControl();
                        IMenuItem fic = new FriedIceCream();
                        ficcc.DataContext = fic;
                        customerOrder.Add(fic);
                        toggle.Child = ficcc;
                        completeOrderButton.IsEnabled = true;
                        selectMoreButton.IsEnabled = true;
                        break;
                    case "FriedCandyBar":
                        var fcbcc = new FriedCandyBarCC();
                        IMenuItem fc = new FriedCandyBar();
                        fcbcc.DataContext = fc;
                        customerOrder.Add(fc);
                        toggle.Child = fcbcc;
                        completeOrderButton.IsEnabled = true;
                        selectMoreButton.IsEnabled = true;
                        break;
                    case "FriedTwinkies":
                        var ftcc = new FriedTwinkieCC();
                        IMenuItem ft = new FriedTwinkie();
                        ftcc.DataContext = ft;
                        customerOrder.Add(ft);
                        toggle.Child = ftcc;
                        completeOrderButton.IsEnabled = true;
                        selectMoreButton.IsEnabled = true;
                        break;
                    case "PiperPlatter":
                        var pipcc = new PiperPlatterCC();
                        IMenuItem pipp = new PiperPlatter();
                        pipcc.DataContext = pipp;
                        customerOrder.Add(pipp);
                        toggle.Child = pipcc;
                        completeOrderButton.IsEnabled = true;
                        selectMoreButton.IsEnabled = true;
                        break;
                    case "Cash":
                        var cpc = new CashPaymentScreen();
                        toggle.Child = cpc;
                        break;
                    case "Credit":
                        var cdpc = new CardPaymentControl("Credit");
                        //toggle.Child = cdpc;
                        break;
                    case "Debit":
                        cdpc = new CardPaymentControl("Debit");
                        //toggle.Child = cdpc;
                        break;
                    default:
                        var pcc = new PopperCC(button.Tag.ToString(), "Add");
                        toggle.Child = pcc;
                        completeOrderButton.IsEnabled = true;
                        selectMoreButton.IsEnabled = true;
                        break;
                        
                }
            }
        }

        /*

        /// <summary>
        /// Action that is performed when a the glazed check box is checked or unchecked
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event that triggers the method</param>
        void onGlazedCheck(object sender, RoutedEventArgs e)
        {
            if(e.OriginalSource is CheckBox checker) { 
            
                e.Handled = true;

                if (checker.Tag.ToString() == "GlazedCheck")
                {
                    if ((bool) checker.IsChecked == true)
                    {
                        //orderSumCntrl.GlazedCheck;
                    }
                    else
                    {

                    }
                }
            }
        }*/

        /// <summary>
        /// Action that is performed when the "Remove" button is clicked on a specific menu item
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event that triggers the method</param>
        void RemoveItem(object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource is Button button)
            {
                e.Handled = true;
                if(button.Tag.ToString() == "Remove")
                {
                    customerOrder.Remove((IMenuItem) button.DataContext);
                    var msc = new MenuSelectionControl();
                    toggle.Child = msc;
                }
                if (button.Tag.ToString() == "Edit")
                {
                    var whatevs = (IMenuItem)button.DataContext;
                    switch (whatevs)
                    {
                        case FriedPie:
                            var fpcc = new FriedPieCustomizationControl();
                            IMenuItem fp = whatevs;
                            fpcc.DataContext = fp;
                            toggle.Child = fpcc;
                            completeOrderButton.IsEnabled = true;
                            selectMoreButton.IsEnabled = true;
                            break;
                        case FriedIceCream:
                            var ficcc = new FriedIceCreamCustomizationControl();
                            IMenuItem ficp = whatevs;
                            ficcc.DataContext = ficp;
                            toggle.Child = ficcc;
                            completeOrderButton.IsEnabled = true;
                            selectMoreButton.IsEnabled = true;
                            break;
                        case FriedCandyBar:
                            var fcbcc = new FriedCandyBarCC();
                            IMenuItem fcbp = whatevs;
                            fcbcc.DataContext = fcbp;
                            toggle.Child = fcbcc;
                            completeOrderButton.IsEnabled = true;
                            selectMoreButton.IsEnabled = true;
                            break;
                        case FriedTwinkie:
                            var ftcc = new FriedTwinkieCC();
                            IMenuItem ftp = whatevs;
                            ftcc.DataContext = ftp;
                            toggle.Child = ftcc;
                            completeOrderButton.IsEnabled = true;
                            selectMoreButton.IsEnabled = true;
                            break;
                        case PiperPlatter:
                            var pipcc = new PiperPlatterCC();
                            IMenuItem pip = whatevs;
                            pipcc.DataContext = pip;
                            toggle.Child = pipcc;
                            completeOrderButton.IsEnabled = true;
                            selectMoreButton.IsEnabled = true;
                            break;
                        case AppleFritters:
                            PopperCC popccA = new PopperCC("Apple Fritters", "Edit");
                            IMenuItem poppA = whatevs;
                            popccA.DataContext = poppA;
                            toggle.Child = popccA;
                            popccA.typePopper.Content = "Customize Apple Fritters";
                            break;
                        case FriedBananas:
                            PopperCC popccF = new PopperCC("Fried Bananas", "Edit");
                            IMenuItem poppF = whatevs;
                            popccF.DataContext = poppF;
                            toggle.Child = popccF;
                            popccF.typePopper.Content = "Customize Fried Bananas";
                            break;
                        case FriedCheesecake:
                            PopperCC popccFc = new PopperCC("Fried Cheesecake", "Edit");
                            IMenuItem poppFc = whatevs;
                            popccFc.DataContext = poppFc;
                            toggle.Child = popccFc;
                            popccFc.typePopper.Content = "Customize Fried Cheesecake";
                            break;
                        case FriedOreos:
                            PopperCC popccFo = new PopperCC("Fried Cheesecake", "Edit");
                            IMenuItem poppFo = whatevs;
                            popccFo.DataContext = poppFo;
                            toggle.Child = popccFo;
                            popccFo.typePopper.Content = "Customize Fried Oreos";
                            break;
                        default:
                            PopperCC popccpla = new PopperCC("Fried Cheesecake", "Edit");
                            IMenuItem popppla = whatevs;
                            popccpla.DataContext = popppla;
                            toggle.Child = popccpla;
                            popccpla.typePopper.Content = "Customize Popper Platter";
                            break;

                    }

                    Console.WriteLine("Debugging");
                }
            }
         }

        /// <summary>
        /// Action that is performed when the "Select More Items" button is clicked
        /// </summary>
        /// <param name="sender">The sender of the even</param>
        /// <param name="e">The event that triggers the method</param>
        void SelectMorePress(object sender, RoutedEventArgs e)
        {
            var msc = new MenuSelectionControl();
            toggle.Child = msc;
        }

        /// <summary>
        /// Action that is performed when the "Cancel Order" button is clicked
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event that triggers the method</param>
        void CancelPress(object sender, RoutedEventArgs e)
        {
            var msc = new MenuSelectionControl();
            toggle.Child = msc;
            customerOrder = new Order();
            orderSumCntrl.DataContext = customerOrder;
            completeOrderButton.IsEnabled = true;
        }

        /// <summary>
        /// Action that is performed when the "Complete Order" button is clicked
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event that triggers the method</param>
        void CompletePress(object sender, RoutedEventArgs e)
        {
            selectMoreButton.IsEnabled = false;
            var cpm = new ChoosePaymentMethod();
            completeOrderButton.IsEnabled = false;
            toggle.Child = cpm;
        }
    }
}

