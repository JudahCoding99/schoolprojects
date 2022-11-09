/*UserInterface.cs
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
using Ksu.Cis300.Graphs;

namespace Ksu.Cis300.WordLadders
{
    /// <summary>
    /// program that interacts with the user
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// where all the words taken from the file will be stored and related
        /// </summary>
        private DirectedGraph<string, bool> _wordGraph = new DirectedGraph<string, bool>();

        /// <summary>
        /// initializes the program
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Checks to se if the given word is in the list
        /// </summary>
        /// <param name="word">word that will be checked</param>
        /// <returns>true or false</returns>
        private bool isWord(string word)
        {
            if (_wordGraph.ContainsNode(word))
            {
                return true;
            }
            else
            {
                return false;
                
            }
        }

        /// <summary>
        /// Checks the two text boxes and if they are both non-empty adn they bith match enables 
        /// uxFindWordLadder button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxStartingWord_TextChanged(object sender, EventArgs e)
        {
            if ((uxEndingWord.Text.Trim().Length == uxStartingWord.Text.Trim().Length) && uxEndingWord.Text.Length > 0 && uxStartingWord.Text.Length > 0)
            {
                uxFindWordLadder.Enabled = true;
            }
            else
            {
                uxFindWordLadder.Enabled = false;
            }
        }

        /// <summary>
        /// clears all the textboxes and listbox
        /// Opens a file dialog for the user to retrieve the file
        /// creates a new DirectedGrpah
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOpenWordList_Click(object sender, EventArgs e)
        {
            try
            {
                if (uxOpenDialog.ShowDialog() == DialogResult.OK)
                {
                    uxStartingWord.Clear();
                    uxEndingWord.Clear();
                    uxWordLadder.Items.Clear();
                    _wordGraph = GraphBuilder.GetGraph(uxOpenDialog.FileName);
                    MessageBox.Show("Word list was succesfull read");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        } 
      
        /// <summary>
        /// Finds a wordladder between the two given words in the textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxFindWordLadder_Click(object sender, EventArgs e)
        {
            
            string start = uxStartingWord.Text.Trim().ToLower();
            string end = uxEndingWord.Text.Trim().ToLower();
            if(isWord(start) && isWord(end))
            {
                WordLadderFinder.GetWordLadder(_wordGraph, start, end, uxWordLadder.Items);
                if(uxWordLadder.Items.Count == 0)
                {
                    MessageBox.Show("No word ladder found");
                }
                else
                {
                    MessageBox.Show("Length: " + (uxWordLadder.Items.Count - 1));
                }
            }
            else
            {
                if(isWord(start) == false || (isWord(start) == false && isWord(end) == false))
                {
                    MessageBox.Show(start + " is not in the word list");
                }else if (isWord(end) == false)
                {
                    MessageBox.Show(end + " is not in the word list");
                }
                uxWordLadder.Items.Clear();
            }


        }
    }
}
