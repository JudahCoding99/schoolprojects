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

namespace FriedPiper.PointOfSale
{
    /// <summary>
    /// Interaction logic for CashPaymentControl.xaml
    /// </summary>
    public partial class CashPaymentControl : UserControl
    {
        /// <summary>
        /// Identifies the NumberBox.Value XAML attached property
        /// </summary>
        public static DependencyProperty PayedProperty = DependencyProperty.Register("Payed", typeof(uint), typeof(CashPaymentControl));

        //new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, HandlePayedChanged)

        /// <summary>
        /// The NumberBox's displayed value
        /// </summary>
        public uint Payed
        {
            get { return (uint)GetValue(PayedProperty); }
            set { SetValue(PayedProperty, value); }
        }

        /// <summary>
        /// Identifies the NumberBox.Value XAML attached property
        /// </summary>
        public static DependencyProperty OwedProperty = DependencyProperty.Register("Owed", typeof(uint), typeof(CashPaymentControl));

        //new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, HandleOwedChanged)

        /// <summary>
        /// The NumberBox's displayed value
        /// </summary>
        public uint Owed
        {
            get { return (uint)GetValue(OwedProperty); }
            set { SetValue(OwedProperty, value); }
        }

        /// <summary>
        /// Identifies the NumberBox.Value XAML attached property
        /// </summary>
        public static DependencyProperty NotesPropety = DependencyProperty.Register("Notes", typeof(string), typeof(CashPaymentControl));

        //, new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault)

        /// <summary>
        /// The NumberBox's displayed value
        /// </summary>
        public string Notes
        {
            get { return (string)GetValue(NotesPropety); }
            set { SetValue(NotesPropety, value); }
        }

        

        public CashPaymentControl()
        {
            InitializeComponent();
        }
            

        /// <summary>
        /// Callback for the ValueProperty, which clamps the Value to the range 
        /// defined by MinValue and MaxValue
        /// </summary>
        /// <param name="sender">The NumberBox whose value is changing</param>
        /// <param name="e">The event args</param>
        void AddButton(object sender, RoutedEventArgs e)
        {
            Payed++;
        }

        /// <summary>
        /// Callback for the ValueProperty, which clamps the Value to the range 
        /// defined by MinValue and MaxValue
        /// </summary>
        /// <param name="sender">The NumberBox whose value is changing</param>
        /// <param name="e">The event args</param>
        void MinusButton(object sender, RoutedEventArgs e)
        {
            if (Payed > 0)
            {
                Payed--;
            }
           
        }
    }
}
