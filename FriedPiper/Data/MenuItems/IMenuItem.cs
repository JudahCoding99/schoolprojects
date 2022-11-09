using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;

namespace FriedPiper.Data.MenuItems
{
    /// <summary>
    /// Represents the common aspects of all menu items in the restaurant
    /// </summary>
    public interface IMenuItem : INotifyPropertyChanged
    {

        /// <summary>
        /// The Name of the Menu Item chosed
        /// </summary>
        string Name { get; }
        /// <summary>
        /// The price of the Menu item ordered
        /// </summary>
        decimal Price { get; }
        /// <summary>
        /// The Calories in the Menu Item ordered
        /// </summary>
        uint Calories { get;  }

    }
}
