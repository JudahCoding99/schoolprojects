using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriedPiper.Data.Enums;
using System.ComponentModel;
namespace FriedPiper.Data.MenuItems
{
    /// <summary>
    /// dsf
    /// </summary>
    public abstract class Popper: INotifyPropertyChanged
    {
        /// <summary>
        /// An event fired when a property of this object changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The Name of the Popper ordered
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Private backing field of the Glazed property
        /// </summary>
        /// <remarks> Allows for the values to be changed, and also to attach
        /// a handler to the property</remarks>
        private bool _glazed = true;

        /// <summary>
        /// If the popper should be served with a frosting glaze. 
        /// </summary>
        /// <remarks>The default is true, which means a frosting glaze will be added</remarks>
        public bool Glazed {
            get => _glazed;
            set
            {
                if(_glazed != value)
                {
                    _glazed = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Glazed"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }
            }
        } 

        /// <summary>
        /// Private backing field of the Size property
        /// </summary>
        /// <remarks> Allows for the values to be changed, and also to attach
        /// a handler to the property</remarks>
        private ServingSize _size = ServingSize.Small;

        /// <summary>
        /// The size of the popper being served.
        /// </summary>
        /// <remarks> The size can be Small, Medium,or Large. There is also an Handler
        /// attached to the Size that notifies the program when its proeprt has been changed.</remarks>
        public ServingSize Size
        {
            get => _size;
            set
            {
                if (_size != value)
                {
                    _size = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }
            }
        }

        /// <summary>
        /// The price of the popper ordered
        /// </summary>
        public abstract decimal Price { get; }

        /// <summary>
        /// The calories in the popper ordered
        /// </summary>
        public abstract uint Calories { get; }

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
