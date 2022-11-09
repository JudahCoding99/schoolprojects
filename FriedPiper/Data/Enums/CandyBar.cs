using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriedPiper.Data.Enums
{
    /// <summary>
    /// The possible candy bars a customer can choose from. The unsigned integer values
    /// assigned to each candy bar is the calories contained in the candy bar. 
    /// </summary>
    /// <remarks>
    /// For example 325 calories are in a Snickers candy bar. Additionally, the candy bar
    /// enumerator inherits from uint meaning each value can also be treated as an unsigned integer
    /// </remarks>
    public enum CandyBar : uint
    {
        Snickers = 325,
        MilkyWay = 213,
        Twix = 396,
        ThreeMusketeers = 350,
        ButterFingers = 385
    }
}
