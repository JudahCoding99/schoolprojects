using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;

namespace FriedPiper.Data.MenuItems
{
    /// <summary>
    /// sdf
    /// </summary>
    public class PiperPlatter: IMenuItem
    {
        /// <summary>
        /// An event fired when a property of this object changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Always called Piper Platter
        /// </summary>
        public string Name { get; } = "Piper Platter";

        /// <summary>
        /// Represents the first fried Pie
        /// </summary>
        public FriedPie LeftPie { get; } = new FriedPie();

        /// <summary>
        /// Represents the second pie
        /// </summary>
        public FriedPie RightPie { get; } = new FriedPie();

        /// <summary>
        /// Represents the first fried ice cream
        /// </summary>
        public FriedIceCream LeftIceCream { get; } = new FriedIceCream();

        /// <summary>
        /// Represents the second fried ice cream
        /// </summary>
        public FriedIceCream RightIceCream { get; } = new FriedIceCream();

        /// <summary>
        /// The cost of any platter ordered by the customer
        /// </summary>
        public decimal Price { get; } = 12.00m;

        /// <summary>
        /// The sum of all the calories of fried pies and ice cream in the platter
        /// </summary>
        public uint Calories { 
            get
            {
                return LeftPie.Calories + RightPie.Calories + LeftIceCream.Calories + RightIceCream.Calories;
            }
        }

        /// <summary>
        /// Constructs a new  piper platter
        /// </summary>
        public PiperPlatter()
        {
            LeftPie.PropertyChanged += HandleCalorieChange;
            RightPie.PropertyChanged += HandleCalorieChange;
            LeftIceCream.PropertyChanged += HandleCalorieChange;
            RightIceCream.PropertyChanged += HandleCalorieChange;
        }
        /// <summary>
        /// Overrides the default ToString() method to print out a more human-readable name
        /// </summary>
        /// <returns>The Name of the Class</returns>
        public override string ToString()
        {

            return Name;
        }

        /// <summary>
        /// AN event handler to listen for and respond to a propertychanged event on the different composing objects
        /// </summary>
        /// <param name="sender">The composing object that is changing</param>
        /// <param name="e">The event args describing the changing property</param>
        private void HandleCalorieChange(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "Calories")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }
    }
}
