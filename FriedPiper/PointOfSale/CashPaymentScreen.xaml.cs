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
using FriedPiper.Data;
using FriedPiper.Data.MenuItems;
using RoundRegister;

namespace FriedPiper.PointOfSale
{
    /// <summary>
    /// Interaction logic for CashPaymentScreen.xaml
    /// </summary>
    public partial class CashPaymentScreen : UserControl
    {
        MainWindow mWindow = (MainWindow)Application.Current.MainWindow;

        public CashPayment currentCashPayment;

        public CashPaymentScreen()
        {
            InitializeComponent();
            decimal total = mWindow.customerOrder.Total;
            currentCashPayment = new CashPayment() { Cost = Math.Round(total, 2, MidpointRounding.AwayFromZero) };
            this.DataContext = currentCashPayment;
            //AmountDue = Total;
            totalSale.Text = total.ToString("C");
            //amountDue.Text = AmountDue.ToString("C");
            //changeOwed.Text = ChangeOwed.ToString("C");
        } 
        
        /// <summary>
        /// Event Listener that executes when the Finalize Sale Button is Clciked
        /// </summary>
        /// <param name="sender">The control that sends t</param>
        /// <param name="e">The click event that occurs</param>
        void finishOrder(object sender, RoutedEventArgs e)
        {
            if (currentCashPayment.CustomerPayment.CompareTo(0.00m) <= 0)
            {
                RoundRegister.ReceiptPrinter.PrintLine("Order# " + mWindow.customerOrder.Number.ToString());
                RoundRegister.ReceiptPrinter.PrintLine("Ordered At: " + mWindow.customerOrder.PlacedAt.ToString());
                foreach (IMenuItem item in mWindow.customerOrder)
                {
                    RoundRegister.ReceiptPrinter.PrintLine(item.Name + item.Price);

                }
                RoundRegister.ReceiptPrinter.PrintLine("Subtotal: " + mWindow.customerOrder.SubTotal.ToString());
                RoundRegister.ReceiptPrinter.PrintLine("Tax: " + mWindow.customerOrder.Tax.ToString());
                RoundRegister.ReceiptPrinter.PrintLine("Total: " + mWindow.customerOrder.Total.ToString());
                RoundRegister.ReceiptPrinter.PrintLine("Payment Method: Cash");
                RoundRegister.ReceiptPrinter.PrintLine("Change Owed: " + currentCashPayment.ChangeOwed.ToString());
                RoundRegister.ReceiptPrinter.CutTape();
                var msc = new MenuSelectionControl();
                mWindow.toggle.Child = msc;
                mWindow.customerOrder = new Order();
                mWindow.orderSumCntrl.DataContext = mWindow.customerOrder;
                mWindow.completeOrderButton.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("You still owe $" + currentCashPayment.CustomerPayment);
            }
        }
    }
}
