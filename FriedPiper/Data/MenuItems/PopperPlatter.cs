using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using FriedPiper.Data.Enums;

namespace FriedPiper.Data.MenuItems
{
    /// <summary>
    /// sdafas
    /// </summary>
    public class PopperPlatter: IMenuItem
    {
        /// <summary>
        /// An event fired when a property of this object changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// asdf
        /// </summary>
        public string Name {
            get { return $"{Size} Popper Platter"; } 
        }

        /// <summary>
        /// The backing field of the variable size
        /// </summary>
        public ServingSize _size = ServingSize.Small;

        /// <summary>
        /// The size of the Popper Platter chosen by the customer
        /// </summary>
        public ServingSize Size {
            get
            {
                return _size;
            } 
            set
            {
                if(_size != value)
                {
                    _size = value;
                    AppleFritters.Size = _size;
                    FriedBananas.Size = _size;
                    FriedCheesecake.Size = _size;
                    FriedOreos.Size = _size;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }                
            }
        }

        /// <summary>
        /// The backing field of the Glazed Variable
        /// </summary>
        public bool _glazed = true;
        /// <summary>
        /// Indicates if all poppers are glazed or not. The value defaults to false
        /// </summary>
        /// <remarks>Changing the Glazed property should change the 
        /// corresponding property of each poppers to match</remarks>
        public bool Glazed {
            get
            {
                return _glazed;
            }
            set
            {
                if(_glazed != value)
                {
                    _glazed = value;
                    AppleFritters.Glazed = _glazed;
                    FriedBananas.Glazed = _glazed;
                    FriedCheesecake.Glazed = _glazed;
                    FriedOreos.Glazed = _glazed;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Glazed"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }
                
            } 
        }

        /// <summary>
        /// An instance of the AppleFritters class that represents the apple Fritters in the platter
        /// </summary>
        public AppleFritters AppleFritters { get; } = new AppleFritters();

        /// <summary>
        /// An instance of the Fried Bananas class that represents the Fried Bananas in the platter
        /// </summary>
        public FriedBananas FriedBananas { get; } = new FriedBananas();

        /// <summary>
        /// An instance of the Fried Cheesecake class that represents the fried cheesecake in the platter
        /// </summary>
        public FriedCheesecake FriedCheesecake { get; } = new FriedCheesecake();

        /// <summary>
        /// An instance of the Fried Oreos class that represents the fried oreos in the platter
        /// </summary>
        public FriedOreos FriedOreos { get; } = new FriedOreos();

        /// <summary>
        /// The price of the platter ordered by the customer
        /// </summary>
        /// <remarks> The price of the platter is based on the size ordered by the customer</remarks>
        public decimal Price {
            get
            {
                if (Size == ServingSize.Small) return 12.00m;
                else if (Size == ServingSize.Medium) return 16.00m;
                else return 20.00m;
            }
        }

        /// <summary>
        /// The calories in the platter ordered by the customer
        /// </summary>
        public uint Calories
        {
            get
            {
                return AppleFritters.Calories + FriedBananas.Calories + FriedCheesecake.Calories + FriedOreos.Calories;
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
