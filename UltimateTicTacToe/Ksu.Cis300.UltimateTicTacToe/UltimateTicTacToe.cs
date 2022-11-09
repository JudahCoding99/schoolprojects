/*UltimateTicTacToe.cs
 * Author: Emmanuel Adeniji
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksu.Cis300.UltimateTicTacToe
{
    /// <summary>
    /// Implements all other classes to create the Tic Tac Toe game
    /// </summary>
    public partial class UltimateTicTacToe : Form
    {
        /// <summary>
        /// This will be the code representation of the board that is created by the FlowLayoutPanel
        /// </summary>
        private UltimateBoard _board = new UltimateBoard();

        private GameTreeNode _gtn = new GameTreeNode();
        /// <summary>
        /// Acts a the computer
        /// </summary>
        private string _computerPiece; 
        /// <summary>
        /// Acts as the human
        /// </summary>
        private string _humanPiece;
        /// <summary>
        /// Initializes the form and then the board
        /// </summary>
        public UltimateTicTacToe()
        {
            InitializeComponent();
            InitializeBoard();
        }
        /// <summary>
        /// Using a message box determines who goes first and who X and O is assigned to
        /// </summary>
        /// <param name="sender">gives button that was clicked</param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            
            if(MessageBox.Show("Would you like to play first ?","First Player",MessageBoxButtons.YesNo ) == DialogResult.Yes)
            {
                _humanPiece = "X";
                _computerPiece = "O";
                _gtn.AddChildren(_board);
                uxStatus.Text = "Your Turn";
            }
            else
            {
                _computerPiece = "X";
                _humanPiece = "O";
                ComputerPlay();
            }
        }
        /// <summary>
        /// Adds a control to the flow layout panel which will be a button
        /// </summary>
        /// <param name="c">contrl that will be added</param>
        /// <param name="flp">Flowlayout panel the control will be added to</param>
        /// <param name="width">Gives the width of the control</param>
        /// <param name="h">Height of the control</param>
        /// <param name="margin">amount of margin to leave around the control to separate it from other controls</param>
        private void AddControl(Control c, FlowLayoutPanel flp, int width, int h, int margin)
        {
            c.Size = new Size(width, h);
            c.Margin = new Padding(margin);
            flp.Controls.Add(c);
        }
        /// <summary>
        /// This will use mthe AddControl() method to actually create the board for the user to interface with
        /// </summary>
        private void InitializeBoard()
        {
            for (int i = 0; i < 3; i ++)
            {
                FlowLayoutPanel row = new FlowLayoutPanel();
                AddControl(row, uxBoard, uxBoard.Width, uxBoard.Height / 3, 0);
                for(int j = 0; j < 3; j++)
                {
                    FlowLayoutPanel col = new FlowLayoutPanel();
                    AddControl(col, row, (row.Width / 3) - 4, row.Height - 4, 2);
                    for (int k = 0; k < 3; k++)
                    {
                        FlowLayoutPanel sRow = new FlowLayoutPanel();
                        AddControl(sRow, col, col.Width, col.Height / 3, 0);
                        for (int l = 0; l < 3; l++)
                        {
                            Button btn = new Button();
                            btn.Tag = (i, j, k, l);
                            btn.Click += ButtonClick;
                            AddControl(btn, sRow, sRow.Width / 3, sRow.Height, 0);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Disables all of the control that have been created in the flowlayout panel
        /// </summary>
        private void DisableAllButtons()
        {
            foreach(Control ctrl in uxBoard.Controls)
            {
                foreach(Control ctr in ctrl.Controls)
                {
                    foreach(Control ct in ctr.Controls)
                    {
                        foreach(Control c in ct.Controls)
                        {
                            c.Enabled = false;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// This will check if the game is over
        ///  =>If it is it will check if someone one and tell which player one. If no one won the game is a draw. returns true
        ///  => IF it is not returns false
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private bool GameIsOver(string str)
        {
            if(_board.IsOver)
            {
                DisableAllButtons();
                if(_board.IsWon)
                {
                    uxStatus.Text = str + " Win!!!";
                }
                else{
                    uxStatus.Text = "The Game is a draw";
                }
                return true;
            }
            return false;
        }
        /// <summary>
        /// It will first disable all the buttons and notify that it is the computer's turn
        /// It will then run 25,000 simulatios and pick the best play for itself
        /// IF the game is not over then all the buttons will be reenabled
        /// </summary>
        private void ComputerPlay()
        {
            DisableAllButtons();
            uxStatus.Text = "My Turn!";
            Update();
            for (int i = 0; i < 25000; i++)
            {
                UltimateBoard uxc = new UltimateBoard(_board);
                _gtn.Simulate(uxc);
            }
            GameTreeNode gt = _gtn.GetBestChild();
            (int, int, int, int) iiii = gt.Play;
            _board.Play(iiii);
            uxBoard.Controls[iiii.Item1].Controls[iiii.Item2].Controls[iiii.Item3].Controls[iiii.Item4].Text = _computerPiece;
            uxStatus.Text = "Your Turn!";
            if(!GameIsOver("I"))
            {
                _gtn = gt;
                foreach((int, int, int, int) lp in _board.GetAvailablePlays())
                {
                    uxBoard.Controls[lp.Item1].Controls[lp.Item2].Controls[lp.Item3].Controls[lp.Item4].Enabled = true;
                }
            }
        }
        /// <summary>
        ///  Sets the text of the clicked button to the symbol used by the human.
        ///  Using the Tag Property the button's location can then be made to the UltimateBoard.
        ///  Determines whether the game is over. 
        ///  =>If not, updates the GameTreeNode to the child corresponding to the user's play, then calls the computer play.
        /// </summary>
        /// <param name="o">gives button that was clicked</param>
        /// <param name="e">Not significant in this context</param>
        private void ButtonClick(object o, EventArgs e)
        {
            Button btn = (Button) o;
            btn.Text = _humanPiece;
            (int, int, int, int) play = ((int, int, int, int)) btn.Tag;
            _board.Play(play);
            if(!GameIsOver("You"))
            {
                _gtn = _gtn.GetChild(play);
                ComputerPlay();
            }
        }

    }
}
