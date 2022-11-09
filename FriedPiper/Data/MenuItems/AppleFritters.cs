using System;
using FriedPiper.Data.Enums;

namespace FriedPiper.Data.MenuItems
{
    /// <summary>
    /// A class representing the AppleFritters menu item at FriedPiper
    /// </summary>
    public class AppleFritters: Popper, IMenuItem
    {
        /// <summary>
        /// The name of the Apple fritter. The name is based on the size of the 
        /// apple fritters ordered
        /// </summary>
        public override string Name
        {
            get { return $"{Size} Apple Fritters"; }
        }


        /// <summary>
        /// The price of a apple fritter in US dollars. The price is based on the size of
        /// the apple fritter ordered
        /// </summary>
        public override  decimal Price
        {
            get
            {
                if (Size == ServingSize.Small) return 3.00m;
                else if (Size == ServingSize.Medium) return 4.00m;
                else return 5.00m;
            }
        }

        /// <summary>
        /// The calories of in a fritter. The calories in a fritter is based on the size ordered
        /// </summary>
        public override  uint Calories
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
                    temp += 240;
                }
                else if (Size == ServingSize.Medium)
                {
                    temp += 360;
                }
                else if (Size == ServingSize.Large)
                {
                    temp += 480;
                }
                return temp;
            }
        }
    }
}
