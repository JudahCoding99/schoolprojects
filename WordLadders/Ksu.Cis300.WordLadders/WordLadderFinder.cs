/*WordLadderFinder.cs
 * Author: Emmanuel Adeniji
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Ksu.Cis300.Graphs;

namespace Ksu.Cis300.WordLadders
{
    /// <summary>
    /// creates the word ladder from the relations made by a directed graph
    /// </summary>
    static class WordLadderFinder
    {
        /// <summary>
        /// This method will find the shortest path from the first word to the last word
        /// in the graph 
        /// </summary>
        /// <param name="graphSearched">The graph that will be searched</param>
        /// <param name="start">first word</param>
        /// <param name="dest">last word</param>
        /// <returns>A dictionary that will hold all the words starting from "start" all the way to "dest"</returns>
        private static Dictionary<string,string> FindShortestPath(DirectedGraph<string, bool> graphSearched, string start, string dest)
        {
            Queue<Edge<string, bool>> q = new Queue<Edge<string, bool>>();
            Dictionary<string, string> paths = new Dictionary<string, string>();
            paths.Add(start, start);
            if(start == dest)
            {
                return paths;
            }
            foreach (Edge<string, bool> e in graphSearched.OutgoingEdges(start))
            {
                q.Enqueue(e);
            }
            while (q.Count > 0)
            {                
                Edge<string, bool> temp = q.Dequeue();
                string s = temp.Source;
                string d = temp.Destination;
                if (!paths.ContainsKey(d))
                {
                    paths.Add(d, s);
                    if (d == dest)
                    {
                        return paths;
                    }
                    foreach (Edge<string, bool> f in graphSearched.OutgoingEdges(d))
                    {
                        q.Enqueue(f);
                    }
                }
            }


            return null;
        }

        /// <summary>
        /// Using previous method will create the word ladder by adding 
        /// each word to the list
        /// </summary>
        /// <param name="containsWords">The directed graph</param>
        /// <param name="start">first word in the world ladder</param>
        /// <param name="dest">last word in the word ladder</param>
        /// <param name="ladder">The ladder that will hold the words from the first to last words inclusive</param>
        public static void GetWordLadder(DirectedGraph<string, bool> containsWords, string start, string dest, IList ladder)
        {
            ladder.Clear();
            Dictionary<string, string> path = FindShortestPath(containsWords, dest, start);
            if(path != null)
            {
                while (start != dest)
                {
                    ladder.Add(start);
                    start = path[start];
                }
                ladder.Add(dest);
            }            
        }
    }
}
