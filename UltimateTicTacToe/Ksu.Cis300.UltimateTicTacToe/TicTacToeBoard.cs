/*TicTacToeBoards.cs
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
    /// THis classs will be used to represent the nine smaller Tic Tac Toe Boards
    /// It will also be used to represent the big TicTacToeBoard
    /// </summary>
    public class TicTacToeBoard
    {
        /// <summary>
        /// Will give the Content of each square on the board
        /// </summary>
        private Player[,] _board = new Player[3, 3];
        /// <summary>
        /// Value to keep track of number of plays made to the board
        /// </summary>
        private int _numberOfPlays = 0;
        /// <summary>
        /// Array of Arrays
        /// Keeps track of how many times each of the two actual players
        /// has played to each of the three rows
        /// </summary>
        private int[][] _numberOnRow = new int[3][];
        /// <summary>
        /// Array of Arrays
        /// Keeps track of how many times each of the two actual players
        /// has played to each of the three columns
        /// </summary>
        private int[][] _numberOnColumn = new int[3][];
        /// <summary>
        /// 2D Array
        /// Keeps track of how many times each of the two actual players
        /// has played to the major Diagonal
        /// </summary>
        private int[] _numberOnMajorDiagonal = new int[2];
        /// <summary>
        /// 2D Array
        /// Keeps track of how many times each of the two actual players
        /// has played to the minor diagonal
        /// </summary>
        private int[] _numberOnMinorDiagonal = new int[2];
        /// <summary>
        /// Did a player win after a play. This property checks.
        /// if no one won then it is a draw
        /// </summary>
        public bool IsWon { get; private set; }
        /// <summary>
        /// Is the Game over? This property checks.
        /// if the gmae is over, then IsWon is checked next
        /// </summary>
        public bool IsOver { get; private set; }
        /// <summary>
        /// COnstructs empty tic tac toe board
        /// Constructs two new 2 element arrays 
        /// one for _numberOnRow
        /// the other for _numberOnColumn
        /// </summary>
        public TicTacToeBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    _board[i, j] = Player.None;
                }
                _numberOnRow[i] = new int[2];
                _numberOnColumn[i] = new int[2];
            }
        }
        /// <summary>
        /// This constructor will create a copy of the TicTacToeBoard passed in
        /// The properties and fields of the passed in TicTacToeBoard is also copied
        /// </summary>
        /// <param name="ttt">TicTacToeBoard that will be copied</param>
        public TicTacToeBoard(TicTacToeBoard ttt)
        {            
            Array.Copy(ttt._board, _board, _board.Length);
            for (int i = 0; i < 3; i++)
            {
                _numberOnRow[i] = (int[]) ttt._numberOnRow[i].Clone();
                _numberOnColumn[i] = (int[])ttt._numberOnColumn[i].Clone();
            }
            ttt._numberOnMajorDiagonal.CopyTo(_numberOnMajorDiagonal,0);
            ttt._numberOnMinorDiagonal.CopyTo(_numberOnMinorDiagonal, 0);
            _numberOfPlays = ttt._numberOfPlays;
            IsOver = ttt.IsOver;
            IsWon = ttt.IsWon;
        }
        /// <summary>
        /// Iterates through the private field _board
        /// For any empty location it will add that location to the list 
        /// </summary>
        /// <param name="p">List to be added to</param>
        /// <param name="row">Gives the row cooardinate on the bigger TicTacToeBoard</param>
        /// <param name="col">Gives the col cooardinate on the bigger TicTacToeBoard</param>
        public void GetAvailablePlays(List<(int, int, int, int)> p, int row, int col)
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if(_board[i,j] == Player.None)
                    {
                        p.Add((row, col, i, j));
                    }
                }
            }
        }
        /// <summary>
        /// Updates the number of plays made to a given path
        /// IF a pattern of three is seen on the big board a player wins and the game is over
        /// </summary>
        /// <param name="nOP">The number of plays</param>
        /// <param name="p">The player who makes the play</param>
        private void PlayTo(int[] nOP, Player p)
        {
            nOP[(int)p] += 1;
            if(nOP[(int)p] == 3)
            {
                IsWon = true;
                IsOver = true;
            }
        }
        /// <summary>
        /// Updates _board by placing the given player at the given row and column
        /// increments the number of plays
        /// The game will be over when the number of plays hits 9
        /// If there is no draw the number of  plays made to the paths need to be updates 
        /// </summary>
        /// <param name="p">Player making the play</param>
        /// <param name="row">The row where the play will be made</param>
        /// <param name="col">Column where the play will be made</param>
        public void Play(Player p, int row, int col)
        {
            _board[row, col] = p;
            _numberOfPlays++;
            if(_numberOfPlays == 9)
            {
                IsOver = true;
            }
            if (p < Player.Draw)
            {
                PlayTo(_numberOnColumn[col], p);
                PlayTo(_numberOnRow[row], p);
                if (row == col)
                {
                    PlayTo(_numberOnMajorDiagonal, p);
                }
                if (row + col == 2)
                {
                    PlayTo(_numberOnMinorDiagonal, p);
                }
            }

        }
    }
}
