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
    /// Interaction logic for CardPaymentControl.xaml
    /// </summary>
    public partial class CardPaymentControl : UserControl
    {
        MainWindow mWindow = (MainWindow)Application.Current.MainWindow;

        public Order customerOrder;

        private string _cardType = "";

        public CardPaymentControl(string s)
        {
            InitializeComponent();
            transaction();
            _cardType = s;
        }

        /// <summary>
        /// Runs the Transaction
        /// </summary>
        public void transaction()
        {
            CardTransactionResult runCard = CardReader.RunCard();
            var cpm = new ChoosePaymentMethod();
            switch (runCard)
            {
                case CardTransactionResult.Approved:
                    Result.Text = "Approved";
                    Finish.IsEnabled = true;
                    mWindow.toggle.Child = this;
                    break;
                case CardTransactionResult.Declined:
                    //Result.Text = "Declined";
                    MessageBox.Show("Declined");
                    mWindow.toggle.Child = cpm;
                    break;
                case CardTransactionResult.ReadError:
                    //Result.Text = "ReadError";
                    MessageBox.Show("ReadError");
                    mWindow.toggle.Child = cpm;
                    break;
                case CardTransactionResult.InsufficientFunds:
                    //Result.Text = "InsufficientFunds";
                    MessageBox.Show("Declined");
                    mWindow.toggle.Child = cpm;
                    break;
                case CardTransactionResult.IncorrectPin:
                    //Result.Text = "IncorrectPin";
                    MessageBox.Show("Declined");
                    mWindow.toggle.Child = cpm;
                    break;
            }
        }
        /// <summary>
        /// sf
        /// </summary>
        /// <param name="sender">sdf</param>
        /// <param name="e">sdfd</param>
        void finishOrder(object sender, RoutedEventArgs e)
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
            Random rnd = new Random();
            int rnd4 = rnd.Next(1000, 9999);
            RoundRegister.ReceiptPrinter.PrintLine("Payment Type: "+ _cardType + ":XXXX-XXXX-XXXX-" + rnd4);
            RoundRegister.ReceiptPrinter.CutTape();
            var msc = new MenuSelectionControl();
            mWindow.toggle.Child = msc;
            mWindow.customerOrder = new Order();
            mWindow.orderSumCntrl.DataContext = mWindow.customerOrder;
            mWindow.completeOrderButton.IsEnabled = true;
        }
    }
}
