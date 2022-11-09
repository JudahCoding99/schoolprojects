using System;
using FriedPiper.Data.MenuItems;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriedPiper.Data
{

    /// <summary>
    /// Keeps a list of all the menu items ordered by a user
    /// </summary>
    public class Order : ObservableCollection<IMenuItem>, INotifyCollectionChanged, INotifyPropertyChanged
    {
        
        /// <summary>
        /// The sales tax rate for all the items ordered
        /// </summary>
        public decimal SalesTaxRate { get; set; } = 0.09m;

        /// <summary>
        /// The SubTotal of the order. This is the total cost of the order before
        /// the sales tax is applied
        /// </summary>
        public decimal SubTotal
        {
            get
            {
                decimal total = 0.0m;
                foreach(IMenuItem item in this)
                {
                    total += item.Price;
                }
                return total;
            }
        }

        /// <summary>
        /// The tax of the order. The tax is the sales tax rate applied on subtotal.
        /// </summary>
        public decimal Tax
        {
            get
            {
                return SubTotal * SalesTaxRate;
            }
        }

        /// <summary>
        /// The total of the order. The sm of the SubTotal and Tax proerties
        /// </summary>
        public decimal Total
        {
            get
            {
                return SubTotal + Tax;
            }
        }

        /// <summary>
        /// Property to keep track of the number of items ordered
        /// </summary>
        public uint Calories
        {
            get
            {
                uint totalCal = 0;
                foreach (IMenuItem item in this)
                {
                    totalCal += item.Calories;
                         
                }
                return totalCal;
            }
        }

        /// <summary>
        /// Property giving the current time the order is being placed
        /// </summary>
        public DateTime PlacedAt
        {
            get
            {
                return DateTime.Now;
            }
        }

        public int Number { get; }
          
        private static int nextOrderNumber = 1;
        public Order (){
            CollectionChanged += CollectionChangedListener;
            Number = nextOrderNumber;
            nextOrderNumber++;
        }


        /// <summary>
        /// sfgfsd
        /// </summary>
        /// <param name="sender">sdfg</param>
        /// <param name="e">sdfgfsdg</param>
        void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged( new PropertyChangedEventArgs("SubTotal"));
            OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
            OnPropertyChanged(new PropertyChangedEventArgs("Total"));
            OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (IMenuItem item in e.NewItems)
                    {
                        item.PropertyChanged += CollectionItemChangedListener;                   
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (IMenuItem item in e.OldItems)
                    {
                        item.PropertyChanged -= CollectionItemChangedListener;
                    }
                    break;
                case NotifyCollectionChangedAction.Reset:
                    throw new NotImplementedException("NotifyCollectionChangedAction.Reset not Supported");
            }
        }

        /// <summary>
        /// sdfgfsd
        /// </summary>
        /// <param name="sender">sdfgfsd</param>
        /// <param name="e">sdfgfsdg</param>
        void CollectionItemChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Price")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("SubTotal"));
                OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
                OnPropertyChanged(new PropertyChangedEventArgs("Total"));
            }

            if (e.PropertyName == "Calories")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
            }
        }
    }
}
