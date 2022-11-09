using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using FriedPiper.Data.Enums;

namespace FriedPiper.Data.MenuItems
{
    /// <summary>
    /// The class represents fried ice cream, which is frozen ice cream dipped in breading
    /// and deep-fried
    /// </summary>
    public class FriedIceCream: IMenuItem
    {
        /// <summary>
        /// An event fired when a property of this object changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The name of the ice cream chosen. The name comes from the flavor chosen
        /// </summary>
        public string Name
        {
            get { return $"Fried {Flavor} Ice Cream"; }
        }

        /// <summary>
        /// Private backing field of the Flavor property
        /// </summary>
        /// <remarks>Allows for the values to be changed, and also to attach
        /// a handler to the property</remarks>
        private IceCreamFlavor _flavor = IceCreamFlavor.Chocolate;

        /// <summary>
        /// the flavor of the ice cream
        /// </summary>
        public IceCreamFlavor Flavor 
        {
            get => _flavor;
            set
            {
                if (_flavor != value)
                {
                    _flavor = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }
            }
        }

        /// <summary>
        /// The price a customer will pay if they order the fried Ice cream. Read-only property
        /// meaning they cannot only be returned and not set. The cost is $3.50
        /// </summary>
        public decimal Price
        {
            get
            {
                return 3.50m;
            }
        }

        /// <summary>
        /// The amount of calories in a pie. The value is based on the Ice cream flavor.
        /// </summary>
        /// <remarks>
        /// All though Flavor is of IceCream flavor type, it can be cast as a uint because it 
        /// has inherited the uint class and values have been assigned to the different Ice crean
        /// flavors in the IceCreamFlavor enum
        /// </remarks>
        public uint Calories
        {
            get
            {
                return (uint) Flavor;
            }
        }

        /// <summary>
        /// Overrides the default ToString() method to print out a more human-readable name
        /// </summary>
        /// <returns>The Name of the Class</returns>
        public override string ToString()
        {

            return Name;
        }
    }
}
