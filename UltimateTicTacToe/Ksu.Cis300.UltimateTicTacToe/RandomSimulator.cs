/*RandomSimulator.cs
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
    /// will run random simulations of the game given a board position
    /// </summary>
    public static class RandomSimulator
    {
        /// <summary>
        /// stores the random number generator that will be used
        ///</summary>        
        private static Random _randomNumbers = new Random();
        /// <summary>
        /// It will return a float gving the score of the simulation from the perspective of the 
        /// player who played just prior to the simulation starting
        /// O means player lost
        /// 0.5 means there was a draw
        /// 1 means the the player won
        /// </summary>
        /// <param name="u">board that will be simulated on</param>
        /// <returns>the score that determines the outcome of the simulation</returns>
        public static float Simulate(UltimateBoard u)
        {
            if(u.IsOver)
            {
                if(u.IsWon)
                {
                    return 1;
                }
                else
                {
                    return 0.5f;
                }
            }
            else
            {
                List<(int, int, int, int)> lpn = u.GetAvailablePlays();
                int count = _randomNumbers.Next(lpn.Count);
                u.Play(lpn[count]);
                return 1 - Simulate(u);
            }
        }
    }

   
}
