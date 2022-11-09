using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriedPiper.PointOfSale
{
    /// <summary>
    /// This class represents the Checked menu items
    /// </summary>
    public class CheckedItems : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// private backing field for MenuItem
        /// </summary>
        private string menuItem = "";

        /// <summary>
        /// The MenuItem this CheckedItems embodies
        /// </summary>
        public string MenuItem
        {
            get { return menuItem; }
            set
            {
                if (menuItem != value)
                {
                    menuItem = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Task"));
                }

            }
        }

        /// <summary>
        /// private backing field for CheckedItem
        /// </summary>
        private bool checkedItem = false;

        /// <summary>
        /// Indicates if this task has been completed
        /// </summary>
        public bool CheckedItem
        {
            get { return checkedItem; }
            set
            {
                if (checkedItem != value)
                {
                    checkedItem = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Complete"));
                }
            }
        }

        public CheckedItems(string mItem)
        {
            MenuItem = mItem;
        }
    }
}
