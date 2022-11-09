/*UltimateBoard.cs
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
    /// Creates an ultimate version of the TicTacToeBoard class
    /// </summary>
    public class UltimateBoard
    {
        /// <summary>
        /// Contains all the smaller tic tac toe boards
        /// A three by threee array for all the 9 small boards
        /// </summary>
        private TicTacToeBoard[,] _smallBoard = new TicTacToeBoard[3,3];
        /// <summary>
        /// represents the large board
        /// The board will be empty
        /// </summary>
        private TicTacToeBoard _largeBoard = new TicTacToeBoard();
        /// <summary>
        /// Does the Board represent a new game
        /// </summary>
        private bool _isNewGame = true;
        /// <summary>
        /// The location of the last play made
        /// </summary>
        private (int, int, int, int) _lastPlay;
        /// <summary>
        /// The turn of the player who's turn it is to play
        /// </summary>
        private Player _p = Player.First;
        /// <summary>
        /// Did a player win after a play. This property checks.
        /// if no one won then it is a draw
        /// </summary>
        public bool IsWon {
            get  => _largeBoard.IsWon;

        }
        /// <summary>
        /// Is the Game over? This property checks.
        /// if the gmae is over, then IsWon is checked next
        /// </summary>
        public bool IsOver {
            get  => _largeBoard.IsOver; }

        /// <summary>
        /// Constructs 9 new small Tic Tac Toe Boards
        /// </summary>
        public UltimateBoard()
        {
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    _smallBoard[i,j] = new TicTacToeBoard();
                }
            }
        }
        /// <summary>
        /// Copies the contents of one ultimate board , the properties fields and values, into
        /// the current instance of the ultimate board
        /// </summary>
        /// <param name="u">ultimate board that will be copied</param>
        public UltimateBoard(UltimateBoard u)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    _smallBoard[i, j] = new TicTacToeBoard(u._smallBoard[i,j]);
                }
            }
            _largeBoard = new TicTacToeBoard(u._largeBoard);
            _isNewGame = u._isNewGame;
            _lastPlay = u._lastPlay;
            _p = u._p;
        }
        /// <summary>
        /// Is a play legal?
        /// If so and the game is not over then calls the get available plays of 
        /// the TicTacToeBoard class
        /// If not legal?
        /// iterates through all nine smaller boards, and for each board that represents a game that isn't over,
        /// accumulate its available plays.
        /// </summary>
        /// <returns>returns the list of the legal plays made</returns>
        public List<(int, int, int, int)> GetAvailablePlays()
        {
            List < (int, int, int, int) > l = new List<(int, int, int, int)>();
            if (_isNewGame || _smallBoard[_lastPlay.Item3, _lastPlay.Item4].IsOver)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (!_smallBoard[i, j].IsOver)
                        {
                            _smallBoard[i, j].GetAvailablePlays(l, i, j);
                        }

                    }
                }
            }
            else
            {
                _smallBoard[_lastPlay.Item3, _lastPlay.Item4].GetAvailablePlays(l, _lastPlay.Item3, _lastPlay.Item4);                    
            }

            return l;
        }
        /// <summary>
        /// It will make the play for the current players to a location in one of the smaller board
        /// The location will be determined by the parameter passed in 
        /// Checks if the game is over on the small board after play is made
        /// if so then checks if the game is won
        /// if so it then either records a win or draw to the larger board
        /// if the game is not over new game is set to false
        /// the players turn is switched
        /// </summary>
        /// <param name="lp">gives the location of the play to be made</param>
        public void Play((int, int, int, int) lp)
        {
            TicTacToeBoard ttt = _smallBoard[lp.Item1, lp.Item2];
            ttt.Play(_p, lp.Item3, lp.Item4);
            if (ttt.IsOver)
            {
                if (ttt.IsWon)
                {
                    _largeBoard.Play(_p, lp.Item1, lp.Item2);
                }
                else
                {
                    _largeBoard.Play(Player.Draw, lp.Item1, lp.Item2);
                }
            }
            _isNewGame = false;
            _lastPlay = lp;
            _p = 1 - _p;
        }
    }
}
