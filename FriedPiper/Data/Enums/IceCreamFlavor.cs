using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriedPiper.Data.Enums
{
    /// <summary>
    /// The possible ice cream flavors a customer can choose from. The unsigned integer values
    /// assigned to each Icecream flavor is the calories contained in that specific flavor.
    /// </summary>
    /// /// <remarks>
    /// For example 355 calories are in vanilla Icecream. Additionally, the Icecream flavor
    /// enumerator inherits from uint meaning each value can also be treated as an unsigned integer
    /// </remarks>
    public enum IceCreamFlavor : uint
    {
        Vanilla = 355,
        Chocolate = 353,
        Strawberry =321
    }
}
