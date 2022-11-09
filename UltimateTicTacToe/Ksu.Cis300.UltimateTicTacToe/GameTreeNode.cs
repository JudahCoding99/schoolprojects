/*GameTreeNode.cs
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
    /// represents single nodes of the game tree
    /// These nodes store the play that led to this node
    /// </summary>
    public class GameTreeNode
    {
        /// <summary>
        /// Stores the Node's children
        /// </summary>
        private GameTreeNode[] _children = null;
        /// <summary>
        /// The number if childreb tgat have been included in one or more simulations
        /// </summary>        
        private int _childrenSimulated = 0;
        /// <summary>
        /// the total score of all simulations that have included this node
        /// </summary>
        private float _score = 0;
        /// <summary>
        /// the number of simulations that have included this node
        /// </summary>
        private int _simulations = 0;
        /// <summary>
        /// This allows for a game simulation starting at the current board position
        /// </summary>
        public (int, int, int, int) Play
        {
            get;
        }
        /// <summary>
        ///constructor when nothing is passed in
        /// </summary>
        public GameTreeNode()
        {

        }
        /// <summary>
        /// Gives the location of the play leading to the construction of the node
        /// </summary>
        /// <param name="lpn"></param>
        public GameTreeNode((int, int, int, int) lpn)
        {
            Play = lpn;
        }
        /// <summary>
        /// add the given value to the total score for this node, 
        /// increments the number of simulations that include it. 
        /// </summary>
        /// <param name="simScore">value to be added to score</param>
        /// <returns></returns>
        private float UpdateScore(float simScore)
        {
            _score += simScore;
            _simulations++;
            return simScore;
        }
        /// <summary>
        /// returns a GameTreeNode referring to child corresponding to the play
        /// described by the location passed in
        /// </summary>
        /// <param name="lpn">loaction that will be passed in</param>
        /// <returns>Game Tree Node describing the play that was passed in</returns>
        public GameTreeNode GetChild((int, int, int, int) lpn)
        {
            foreach (GameTreeNode gtn in _children)
            {
                if (gtn.Play.Equals(lpn))
                {
                    return gtn;
                }
            }
            return null;
        }
        /// <summary>
        /// Adds children to the node from available plays on the board
        /// </summary>
        /// <param name="u">Gives the board position at the node</param>
        public void AddChildren(UltimateBoard u)
        {
            List<(int, int, int, int)> lpn = u.GetAvailablePlays();
            _children = new GameTreeNode[lpn.Count];
            for (int i = 0; i < _children.Length; i++)
            {
                GameTreeNode gt = new GameTreeNode(lpn[i]);
                _children[i] = gt;
            }
        }
        /// <summary>
        /// Checks three cases
        /// 1 => Node has not been used in any sim
        ///   A random simulation of this node is done
        /// 2 => Game on the given board is over
        ///   it will determine the score of the simulation
        /// 3=> Otherwise
        ///      Make sure the node as children if not add them
        ///      Then a recursion will be done to check through the cases again
        /// </summary>
        /// <param name="u">Gives the board position at the node</param>
        /// <returns>A float giving the score of a simulation, where the score is as defined for RandomSimulator.Simulate</returns>
        public float Simulate(UltimateBoard u)
        {
            if(_simulations == 0)
            {
                return UpdateScore(RandomSimulator.Simulate(u));
            }else if(u.IsOver)
            {
                if(u.IsWon)
                {
                    return UpdateScore(1);
                }
                else
                {
                    return UpdateScore(0.5f);
                }
            }
            else
            {
                if(_children == null)
                {
                    AddChildren(u);
                }
                GameTreeNode g = GetChildForSimulation();
                u.Play(g.Play);
                return UpdateScore(1 - g.Simulate(u));
            }
        }
        /// <summary>
        /// Gives the child that will repsent the best play for the player
        /// This is the child used most in simulations
        /// </summary>
        /// <returns>The child used most in the simulations</returns>
        public GameTreeNode GetBestChild()
        {
            GameTreeNode bestChild = null;
            int max = 0;
            for(int i = 0; i < _children.Length; i++)
            {
                if(max < _children[i]._simulations)
                {
                    max = _children[i]._simulations;
                    bestChild = _children[i];
                }
            }

            return bestChild;
        }
        /// <summary>
        /// Checks to cases:
        /// 1 => Not all children have been used in the simulation
        /// ensures that each child has been used in at least one simulation before the next case applies
        /// 2 => otherwise
        /// make a selection that prefers children that appear more promising, 
        /// while also exploring all the children enough to get trustworthy estimates of how promising they are
        /// </summary>
        /// <returns>THe selected child</returns>
        private GameTreeNode GetChildForSimulation()
        {
            if(_childrenSimulated < _children.Length)
            {
                GameTreeNode gtn = _children[_childrenSimulated];
                _childrenSimulated++;
                return gtn;
            }
            else
            {
                double nat = 2 * Math.Log(_simulations);
                float max = -1;
                GameTreeNode gt = null;
                foreach(GameTreeNode g in _children)
                {
                    float result = (float)((g._score / g._simulations) + Math.Sqrt(nat / g._simulations));
                    if(result > max)
                    {
                        max = result;
                        gt = g;
                    }
                }
                return gt;
            }
        }

    }
}
