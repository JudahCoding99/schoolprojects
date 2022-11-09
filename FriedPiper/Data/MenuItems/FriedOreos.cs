using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriedPiper.Data.Enums;

namespace FriedPiper.Data.MenuItems
{
    /// <summary>
    /// The class represents Fried oreos, an oreo cookie dipped in batter and deep-fried
    /// </summary>
    public class FriedOreos: Popper, IMenuItem
    {
        /// <summary>
        /// The Name of the fried oreos. The name is based on the size of the oreos
        /// </summary>
        public override string Name
        {
            get { return $"{Size} Fried Oreos"; }
        }

        /// <summary>
        /// The price of fried oreos in US dollars. The price is dependant on the size of
        /// the oreos ordered
        /// </summary>
        public override decimal Price
        {
            get
            {
                if (Size == ServingSize.Small) return 3.75m;
                else if (Size == ServingSize.Medium) return 4.50m;
                else return 5.25m;
            }
        }

        /// <summary>
        /// The calories of the fried oroes. The calories is dependant on the size of
        /// the oreos ordered
        /// </summary>
        public override uint Calories
        {
            get
            {
                uint temp = 0;
                if (Glazed)
                {
                    temp += 130;
                }

                if (Size == ServingSize.Small)
                {
                    temp += 500;
                }
                else if (Size == ServingSize.Medium)
                {
                    temp += 750;
                }
                else if (Size == ServingSize.Large)
                {
                    temp += 1000;
                }
                return temp;
            }
        }
    }
}
