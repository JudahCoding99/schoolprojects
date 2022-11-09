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
    /// The class represents a fried twinkie. Atwinkie dipped in breading and deep-fried
    /// </summary>
    public class FriedTwinkie : IMenuItem
    {
        /// <summary>
        /// An event fired when a property of this object changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The name if the snack which is always "Fried Twinkie"
        /// </summary>
        public string Name {
            get
            {
                return "Fried Twinkie";
            }
        }
        /// <summary>
        /// The price a customer will pay if they order the Fried Twinkie. Read-only property
        /// meaning they cannot only be returned and not set. The cost is $2.25
        /// </summary>
        public decimal Price
        {
            get
            {
                return 2.25m;
            }
        }

        /// <summary>
        /// The calories of the fried twinkie. The twinkie will always be 420 calories
        /// </summary>
        public uint Calories
        {
            get
            {
                return 420;
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
