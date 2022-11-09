/*GraphBUilder.cs
 * Author: Emmanuel Adeniji
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ksu.Cis300.Graphs;
using Ksu.Cis300.TrieLibrary;
using System.IO;

namespace Ksu.Cis300.WordLadders
{
    /// <summary>
    /// program builds the graph using the words gotten from the text file
    /// </summary>
    static class GraphBuilder
    {
        /// <summary>
        /// adds an edge from the string taken from the given list to the current word in this list
        /// </summary>
        /// <param name="allWords">gicen list that words will be taken from</param>
        /// <param name="list">Trie that will be used to add adjacent words to the temporary list created</param>
        /// <param name="graph">Edges that will be addes between two very similar words</param>
        private static void AddEdges(List<string> allWords, ITrie list, DirectedGraph<string, bool> graph)
        {            
            foreach (string s in allWords)
            {
                List<string> temp = new List<string>();
                StringBuilder b = new StringBuilder();
                list.AddAdjacent(b, s, temp);
                foreach (string word in temp)
                {
                    graph.AddEdge(s, word, true);
                }
            }
           
        }

        /// <summary>
        /// Creates a Directed Graph that relates all similar words
        /// creates graph by reading from a file filled woth words
        /// </summary>
        /// <param name="fileName">File holding all the words</param>
        /// <returns>Directed Graph</returns>
        public static DirectedGraph<string, bool> GetGraph(string fileName)
        {
            DirectedGraph<string, bool> temp1 = new DirectedGraph<string, bool>();
            ITrie temp2 = new TrieWithNoChildren();
            List<string> temp3 = new List<string>();
            int i = 1;
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    while (!sr.EndOfStream)
                    {
                        string s = sr.ReadLine().Trim().ToLower();
                        if (!temp1.ContainsNode(s))
                        {
                            temp2 = temp2.Add(s);
                            temp3.Add(s);
                            temp1.AddNode(s);                            
                        }
                        i++;
                    }
                    AddEdges(temp3, temp2, temp1);
                }
            }catch(ArgumentException ex)
            {
                throw new IOException("There is invalid character on line " + i);
            }
           
            return temp1;
        }
    }
}
