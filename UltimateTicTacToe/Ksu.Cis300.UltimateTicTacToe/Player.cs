/*Player.cs
 * Author: Emmanuel Adeniji
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.UltimateTicTacToe
{
    /// <summary>
    /// Assigns values to first, second, Draw, and none
    /// Helps in TicTacToeBoard class where values can be used as array indices
    /// </summary>
    public enum Player
    {
        /// <summary>
        /// Uderlying Value of Zero
        /// </summary>
        First,
        /// <summary>
        /// Underlying Value of 1
        /// </summary>
        Second,
        /// <summary>
        /// Underlying value of 2
        /// </summary>
        Draw,
        /// <summary>
        /// Underlying value of 3
        /// </summary>
        None 
        
    }
}
