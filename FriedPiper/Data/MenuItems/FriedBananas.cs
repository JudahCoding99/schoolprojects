using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriedPiper.Data.Enums;

namespace FriedPiper.Data.MenuItems
{
    /// <summary>
    /// The class represents Fried Bananas, Banana slices ddipped in batter and deep-fried
    /// </summary>
    public class FriedBananas: Popper, IMenuItem
    {

        /// <summary>
        /// The name of the fried Bananas. The name is based on the size of the fried bananas
        /// </summary>
        public override string Name
        {
            get { return $"{Size} Fried Bananas"; }
        }

        /// <summary>
        /// The price of a fried banana in US dollars. The price is based on the size of the
        /// fried banana ordered
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
        /// The calories of the fried banana. The calories in the banana is based on the size
        /// of banana orederd
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
                    temp += 160;
                }
                else if (Size == ServingSize.Medium)
                {
                    temp += 240;
                }
                else if (Size == ServingSize.Large)
                {
                    temp += 320;
                }
                return temp;
            }
        }
    }
}
