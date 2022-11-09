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
    /// The class represents a fried candy bar, which is a candy bar dipped in breading
    /// and deep fried
    /// </summary>
    public class FriedCandyBar: IMenuItem
    {
        /// <summary>
        /// An event fired when a property of this object changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The name of the candy bar
        /// </summary>
        public string Name
        {
            get { 
                switch (CandyBar)
                {
                    case CandyBar.ButterFingers:
                        return "Fried Butter Fingers";
                    case CandyBar.ThreeMusketeers:
                        return "Fried Three Musketeers";
                    default:
                        return $"Fried {CandyBar}";
                }
            }
        }

        /// <summary>
        /// Private Backing Field for CandyBar property
        /// </summary>
        private CandyBar _candyBar = CandyBar.ButterFingers;

        /// <summary>
        /// Candy bar that will be fried
        /// </summary>
        public CandyBar CandyBar
        {
            get => _candyBar;
            set
            {
                if(_candyBar != value)
                {
                    _candyBar = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CandyBar"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }
            }
        }

        /// <summary>
        /// The price a customer will pay if they order a fried candy bar. Read-only property
        /// meaning they cannot only be returned and not set. The cost is $2.50
        /// </summary>
        public decimal Price
        {
            get
            {
                return 2.50m;
            }
        }

        /// <summary>
        /// The amount of calories in a pie. The value is based on the Ice cream flavor.
        /// </summary>
        /// <remarks>
        /// All though CandyBar is of CandyBar type, it can be cast as a uint because it 
        /// has inherited the uint class and values have been assigned to the different candy bar
        /// types in the CandyBar enum
        /// </remarks>
        public uint Calories
        {
            get
            {
                return (uint)  CandyBar; 
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
