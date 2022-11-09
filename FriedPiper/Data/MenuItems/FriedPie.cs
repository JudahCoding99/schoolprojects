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
    /// The class is used to represent a fried pie, a deep-fried pastry with fruit-filling
    /// </summary>
    public class FriedPie : IMenuItem
    {
        /// <summary>
        /// An event fired when a property of this object changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The name of the Fried Pie. The name comes from the filling inside the pie
        /// </summary>
        public string Name
        {
            get { return $"Fried {Flavor} Pie"; }
        }

        /// <summary>
        /// Private backing field of the Flavor property
        /// </summary>
        /// <remarks>Allows for the values to be changed, and also to attach
        /// a handler to the property</remarks>
        private PieFilling _flavor = PieFilling.Cherry;

        /// <summary>
        /// The filling inside the pie
        /// </summary>
        public PieFilling Flavor
        {
            get => _flavor;
            set
            {
                if(_flavor != value)
                {
                    _flavor = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }

            }
        }

        /// <summary>
        /// The price a customer will pay if they order the fried pie. Read-only property
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
        /// The amount of calories in a pie. The value is based on the pie filling flavor.
        /// </summary>
        /// <remarks>
        /// All though Flavor is of PieFilling type, it can be cast as a uint because it 
        /// has inherited the uint class and values have been assigned to the different pie
        /// fillings in the PieFilling enum
        /// </remarks>
        public uint Calories
        {
            get
            {
                switch (Flavor)
                {
                    case PieFilling.Cherry:
                        return 287;
                    case PieFilling.Peach:
                        return 304;
                    case PieFilling.Apricot:
                        return 314;
                    case PieFilling.Pineapple:
                        return 302;
                    case PieFilling.Blueberry:
                        return 314;
                    case PieFilling.Apple:
                        return 289;
                    case PieFilling.Pecan:
                        return 314;
                    default:
                        throw new Exception("A Pie Filling was not Chosen");
                }
                
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
