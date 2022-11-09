/*Employee.cs
 * Author:Emmanuel Adeniji
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.ReportingStructureViewer
{
    /// <summary>
    ///  Holds the information for an employee
    /// </summary>
    public class Employee : IComparable<Employee>
    {
        /// <summary>
        /// gets a string giving the employee's ID
        /// </summary>
        private string _displayName;
        public string Id { get; }

        /// <summary>
        /// gets a string giving the employee's first name in lower case
        /// </summary>
        public string FirstName { get; }

        /// <summary>
        /// gets a string giving the employee's last name in lower case
        /// </summary>
        public string LastName { get; }

        /// <summary>
        /// gets a DateTime giving the starting date of the employee
        /// </summary>
        public DateTime StartDate { get; }

        /// <summary>
        /// gets a SortedSet<Employee> containing the employees who directly report to this employee. 
        /// </summary>
        public SortedSet<Employee> DirectReports { get; } = new SortedSet<Employee>();

        /// <summary>
        /// gets a string giving the ID of this employee's manager
        /// </summary>
        public string ManagerId { get; }

        /// <summary>
        /// initialize each of the properties and fields except DirectReports
        /// </summary>
        /// <param name="i">property Id</param>
        /// <param name="fn">proeprty first name</param>
        /// <param name="ln">property last name</param>
        /// <param name="sd"> property start date</param>
        /// <param name="mi">property managerID</param>
        public Employee(string i, string fn, string ln, DateTime sd, string mi)
        {
            Id = i.Trim();
            FirstName = fn.Trim().ToLower();
            LastName = ln.Trim().ToLower();
            StartDate = sd;
            ManagerId = mi.Trim();
            StringBuilder sb = new StringBuilder(fn.Trim());
            sb.Append(", ");
            sb.Append(ln.Trim());
            _displayName = sb.ToString();
        }

        /// <summary>
        /// The ToString method of Employee overrides the ToString method of the object
        /// adds Employees to a ListBox
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _displayName;
        }

        /// <summary>
        /// returns the result of comparing the private field with the given Employee's private field
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public int CompareTo(Employee e)
        {
            int i = _displayName.CompareTo(e._displayName);
            return i;
        }
    }
}
