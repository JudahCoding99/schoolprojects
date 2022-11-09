/*ReportGenerator.cs
 * Author:Emmanuel Adeniji
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.ReportingStructureViewer
{    
    public static class ReportGenerator
    {
        /// <summary>
        /// It should return an int giving the total team size for the given employee, including the given employee, all the way down to the leaves of the tree
        /// This method will only write output if the current depth is no more than the maximum depth
        /// TO calculate the size recursive calls on all its children are made
        /// </summary>
        /// <param name="e">Employoee that is selected by user to create a report about</param>
        /// <param name="depth">0</param>
        /// <param name="maxDepth">How deep into the employees uder the employee passed in the user wants to go</param>
        /// <param name="file">FIle to write to</param>
        /// <returns></returns>
        private static int GenerateReport(Employee e, int depth, int maxDepth, StreamWriter file)
        {
            if(depth <= maxDepth)
            {               
                file.WriteLine("<li>");
                file.Write(e.ToString() + " (" + e.Id.ToString() + ") - Started " + e.StartDate.ToString("d"));
                file.WriteLine("<ul>");                
            }
            int totalTeamSize = 1;
            foreach(Employee em in e.DirectReports)
            {
                totalTeamSize += GenerateReport(em, depth + 1, maxDepth, file);
            }
            if (depth <= maxDepth)
            {
                file.WriteLine("</ul>");
                file.Write(e.ToString() + " Direct Reports: " + e.DirectReports.Count + "; Total Team Members: " + totalTeamSize);
                file.WriteLine("</li>");
            }
            return totalTeamSize;
        }

        /// <summary>
        /// Creates the whole body of the file
        /// </summary>
        /// <param name="e">Employoee that is selected by user to create a report about</param>
        /// <param name="maxDepth">How deep into the employees uder the employee passed in the user wants to go</param>
        /// <param name="outFile">FIle to write to</param>
        public static void GenerateReport(Employee e, int maxDepth, string outFile)
        {
            
            using (StreamWriter sw = new StreamWriter(outFile))
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine("<title>Team Structure Report</title>");
                sw.WriteLine("</head>");
                sw.WriteLine("<body>");
                sw.WriteLine("<style>");
                sw.WriteLine("li {list-style-type: square;}");
                sw.WriteLine("</style>");
                sw.WriteLine("Team Structure for: <strong>" + e.ToString() + "</strong>");
                sw.WriteLine("<ul>");
                GenerateReport(e, 0, maxDepth, sw);
                sw.WriteLine("</ul>");
                sw.WriteLine("</body>");
                sw.WriteLine("</html>");
            }

        }
    }
}
