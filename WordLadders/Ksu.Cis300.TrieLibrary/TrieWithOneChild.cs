/* TrieWithOneChild.cs
 * Author: Rod Howell
 */
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.TrieLibrary
{
    /// <summary>
    /// A trie with exactly one child.
    /// </summary>
    public class TrieWithOneChild : ITrie
    {
        /// <summary>
        /// Indicates whether the trie rooted at this node contains the empty string.
        /// </summary>
        private bool _hasEmptyString;

        /// <summary>
        /// This node's only child.
        /// </summary>
        private ITrie _child;

        /// <summary>
        /// The child's label.
        /// </summary>
        private char _childLabel;

        /// <summary>
        /// Constructs a trie containing the given nonempty string, and perhaps the empty string.
        /// If the given string is empty or contains a character that is not a lower-case English
        /// letter, throws an ArgumentException.
        /// </summary>
        /// <param name="s">The nonempty string to include.</param>
        /// <param name="hasEmptyString">Indicates whether the empty string should be included.</param>
        public TrieWithOneChild(string s, bool hasEmptyString)
        {
            if (s == "" || s[0] < 'a' || s[0] > 'z')
            {
                throw new ArgumentException();
            }
            _hasEmptyString = hasEmptyString;
            _childLabel = s[0];
            _child = new TrieWithNoChildren().Add(s.Substring(1));
        }

        /// <summary>
        /// Builds the result of adding the given string to the trie rooted at this node.
        /// This node may or may not be changed.
        /// </summary>
        /// <param name="s">The string to add.</param>
        /// <returns>The resulting trie.</returns>
        public ITrie Add(string s)
        {
            if (s == "")
            {
                _hasEmptyString = true;
                return this;
            }
            else if (s[0] < 'a' || s[0] > 'z')
            {
                throw new ArgumentException();
            }
            else if (s[0] == _childLabel)
            {
                _child = _child.Add(s.Substring(1));
                return this;
            }
            else
            {
                return new TrieWithManyChildren(s, _hasEmptyString, _childLabel, _child);
            }
        }

        /// <summary>
        /// Determines whether this trie contains the given string.
        /// </summary>
        /// <param name="s">The string to look up.</param>
        /// <returns>Whether this trie contains s.</returns>
        public bool Contains(string s)
        {
            if (s == "")
            {
                return _hasEmptyString;
            }
            else if (s[0] == _childLabel)
            {
                return _child.Contains(s.Substring(1));
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Gets all of the strings that form words in this trie when appended to the given prefix.
        /// </summary>
        /// <param name="prefix">The prefix</param>
        /// <returns>A trie containing all of the strings that form words in this trie when appended
        /// to the given prefix.</returns>
        public ITrie GetCompletions(string prefix)
        {
            if (prefix == "")
            {
                return this;
            }
            else if (prefix[0] == _childLabel)
            {
                return _child.GetCompletions(prefix.Substring(1));
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Adds all of the strings in this trie alphabetically to the end of the given list, with each
        /// string prefixed by the given prefix.
        /// </summary>
        /// <param name="prefix">The prefix.</param>
        /// <param name="list">The list to which the strings are to be added.</param>
        public void AddAll(StringBuilder prefix, IList list)
        {
            if (_hasEmptyString)
            {
                list.Add(prefix.ToString());
            }
            prefix.Append(_childLabel);
            _child.AddAll(prefix, list);
            prefix.Length--;
        }

        /// <summary>
        /// Adds words adjacent  to "matching" to the IList
        /// This means words that differ from matching by 1 character
        /// </summary>
        /// <param name="prefix">prefix</param>
        /// <param name="matching">word that will be checked against</param>
        /// <param name="list">All the words that are similar to this word</param>
        public void AddAdjacent(StringBuilder prefix, string matching, IList list)
        {
            if(!(matching == ""))
            {
                if (_childLabel.Equals(matching[0]))
                {
                    prefix.Append(matching[0]);
                    _child.AddAdjacent(prefix, matching.Substring(1), list);
                    prefix.Length--;
                }
                else
                {
                    if(_child.Contains(matching.Substring(1)))
                    {
                        prefix.Append(_childLabel);
                        prefix.Append(matching.Substring(1));
                        list.Add(prefix.ToString());
                        prefix.Length = prefix.Length - matching.Length;
                    }
                }
            }
        }
    }
}
