/*EmployeeLoader.cs
 * Author:Emmanuel Adeniji
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ksu.Cis300.TrieLibrary;
using System.Windows.Forms;

namespace Ksu.Cis300.ReportingStructureViewer
{
    /// <summary>
    /// Loads employees from an input file into the various data structures
    /// </summary>
    public static class EmployeeLoader 
    {
        /// <summary>
        /// Uses the dictionary's TryGetValue method to look up the key
        /// If the key isn't in the dictionary, you can add it will be added to an empty list
        /// </summary>
        /// <param name="e">Employee passed in</param>
        /// <param name="k">key of the Dictionary</param>
        /// <param name="l">dictionary passed in</param>
        private static void AddEmployee(Employee e, string k, Dictionary<string, List<Employee>> l)
        {
            List<Employee> temp;
            if (!(l.TryGetValue(k, out temp)))
            {
                temp = new List<Employee>();
                l.Add(k, temp);
            }
            temp.Add(e);
        }

        /// <summary>
        /// Adds all employees under a manger to their teams
        /// This is acheived my adding the employees under the manger's Direct Reports
        /// </summary>
        /// <param name="l">Dictionary containing all the employees that will be added</param>
        private static void AddTeamMembers(Dictionary<string, Employee> l)
        {
            foreach(Employee e in l.Values)
            {
                if(!(e.ManagerId.Equals("0")))
                {
                    Employee manager;
                    if (l.TryGetValue(e.ManagerId, out manager))
                    {
                        manager.DirectReports.Add(e);
                    }
                    else
                    {
                        MessageBox.Show("There is no manager with ID " + e.ManagerId);
                        Application.Exit();
                    }
                }
            }
        }

        /// <summary>
        /// Create an instance of StreamReader to read from a file.
        /// Adds all the first and last names intoa dictionary as keys
        /// Adds list of employees with all their fields initialized as Values
        /// </summary>
        /// <param name="fileName">FIle that is read from</param>
        /// <returns></returns>
        public static Dictionary<string, List<Employee>> GetNamesDictionary(string fileName)
        {
            Dictionary<string, Employee> t = new Dictionary<string, Employee>();
            Dictionary<string, List<Employee>> tp = new Dictionary<string, List<Employee>>();
            using (StreamReader sr = new StreamReader(fileName))
            {
                string line;
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    string[] fields = line.Split(',');
                    if(fields.Length == 5)
                    {
                        Employee e = new Employee(fields[0], fields[1], fields[2], Convert.ToDateTime(fields[3].Trim()), fields[4]);
                        t.Add(e.Id, e);
                        AddEmployee(e, e.LastName, tp);
                        AddEmployee(e, e.FirstName, tp);
                    }
                    else
                    { 
                        MessageBox.Show("An input line contains the wrong number of fields.");
                        Application.Exit();
                        
                    }
                }
            }
            AddTeamMembers(t);
            return tp;
        }

        /// <summary>
        /// Adds all the names in the dictionary to a trie
        /// </summary>
        /// <param name="d">Dictionary containing the names</param>
        /// <returns></returns>
        public static ITrie GetNamesTrie(Dictionary<string, List<Employee>> d)
        {
            ITrie t = new TrieWithNoChildren();
            foreach (string k in d.Keys)
            {
                t = t.Add(k);
            }
            return t;
        }
    }
}
