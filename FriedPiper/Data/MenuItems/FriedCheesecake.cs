using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriedPiper.Data.Enums;

namespace FriedPiper.Data.MenuItems
{
    /// <summary>
    /// The class represents Fried Cheesecake, a bite-sized cheesecake sqaure
    /// dipped in batter and deep-fried
    /// </summary>
    public class FriedCheesecake: Popper, IMenuItem
    {
        /// <summary>
        /// What is the Name of the Fried Cheesecake. The name comes from the size of the
        /// fried cheesecake ordered
        /// </summary>
        public override string Name
        {
            get { return $"{Size} Fried Cheesecake"; }
        }

        /// <summary>
        /// The price of a cheesecake in US dollars. The price is based on the size of the 
        /// cheesecake ordered
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
        /// The calories in a fried cheesecake. The amount of calories is based on
        /// the serving size ordered
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
                    temp += 310;
                } else if (Size == ServingSize.Medium)
                {
                    temp += 425;
                }else if(Size == ServingSize.Large)
                {
                     temp += 620;
                }
                return temp;
            }
        }
    }
}
