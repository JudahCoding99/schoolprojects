using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriedPiper.Data.Enums
{
    /// <summary>
    /// The types of possible fillings contained in a Pie0 he unsigned integer values
    /// assigned to each Piefilling is the calories contained in that specific flavor.
    /// </summary>
    /// /// <remarks>
    /// For example 304 calories are in a Peach pie. Additionally, the Pie Filling
    /// enumerator inherits from uint meaning each value can also be treated as an unsigned integer
    /// </remarks>
    public enum PieFilling : uint
    {
        Cherry, 
        Peach, 
        Apricot, 
        Pineapple, 
        Blueberry, 
        Apple, 
        Pecan 
    }
}
