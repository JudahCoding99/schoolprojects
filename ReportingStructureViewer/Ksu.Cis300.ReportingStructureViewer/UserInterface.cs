/*UserInterface.cs
 * Author:Emmanuel Adeniji
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
using Ksu.Cis300.TrieLibrary;

namespace Ksu.Cis300.ReportingStructureViewer
{
    /// <summary>
    /// This class willimplement the GUI the user will use to test the program
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// This will be the minimum length required for a user to look up names
        /// </summary>
        private const int _minimumPrefixLength = 2;

        /// <summary>
        /// Dictionary that Will contains all the first and last names in the file as keys, and the employees associated with the names as values
        /// </summary>
        private  Dictionary<string, List<Employee>> _namesDictionary;

        /// <summary>
        /// Contains all the first and last names in the file in order
        /// </summary>
        private ITrie _names;
        

        public UserInterface()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Get the path of specified file
        /// Using method in the EmployeeLoader class load the contents into the Dictionary from the specified file
        /// if operation is cancel application is exited
        /// Exception Handling ooccurs?
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserInterface_Load(object sender, EventArgs e)
        {
            try
            {
                if (uxOpenDialog.ShowDialog() == DialogResult.OK)
                {

                    string file = uxOpenDialog.FileName;
                    _namesDictionary = EmployeeLoader.GetNamesDictionary(file);
                    _names = EmployeeLoader.GetNamesTrie(_namesDictionary);

                }
                else if (uxOpenDialog.ShowDialog() == DialogResult.Cancel)
                {
                    Application.Exit();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }

        /// <summary>
        /// Will take as its only parameter a string giving the prefix. 
        /// It will return a SortedSet<Employee> containing all employees whose first or last names begin with the given prefix.
        /// This occurs by using an ITrie method called GetCompletions which will look through an itrie and return an Itrie with
        ///         strings that have the specified prefix in them
        /// The ITrie that is made is added to a lost which is then compared with the list of employees in the dictionary.
        /// The emplyees are then added to a SortedSet
        /// </summary>
        /// <param name="prefix">String that will be used by GetCompletions</param>
        /// <returns>returns the SortedSet created</returns>
        private SortedSet<Employee> GetEmployees(string prefix)
        {
            List<string> lt = new List<string>();
            SortedSet<Employee> st = new SortedSet<Employee>();
            ITrie completions = _names.GetCompletions(prefix);
            if (completions != null)
            {               
                completions.AddAll(new StringBuilder(prefix), lt);                
            }
            foreach(string name in lt)
            {
                List<Employee> le = _namesDictionary[name];
                foreach(Employee em in le)
                {
                    st.Add(em);
                }
            }
            return st;
        }
        /// <summary>
        /// Clears the listbox 
        /// Adds all the employees in the SortedSet created by the GetEmployees method to the ListBOx
        /// </summary>
        /// <param name="st"></param>
        private void SetEmployeeList(SortedSet<Employee> st)
        {
            uxNames.Items.Clear();
            foreach (Employee e in st)
            {
                uxNames.Items.Add(e);
            }
        }
        /// <summary>
        /// Enables and disables the Lookup button based on the length of the TextBox
        /// Greater than or equal 2 => Enabled
        /// Less than 2 => Disabled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxPrefix_TextChanged(object sender, EventArgs e)
        {
            string tx = uxPrefix.Text;
            if(tx.Trim().Length >= 2)
            {
                uxLookup.Enabled = true;
            }
            else
            {
                uxLookup.Enabled = false;
            }
        }
        /// <summary>
        /// Executes the SetEmployeeList() method
        /// disables GenerateReport
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxLookup_Click(object sender, EventArgs e)
        {
            string tx = uxPrefix.Text.Trim().ToLower();
            SetEmployeeList(GetEmployees(tx));
            uxGenerateReport.Enabled = false;
        }
        /// <summary>
        /// Enables GenerateReport when an item is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(uxNames.SelectedIndex >= 0)
            {
                uxGenerateReport.Enabled = true;
            }
        }
        /// <summary>
        /// Using the GenerateReport method in ReportGenerator creates a file with th results of the actions taking in the program
        /// Also displays the results in the WebBrowser
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = (Employee)uxNames.SelectedItem;
                uxSaveDialog.FileName = emp.ToString();
                if (uxSaveDialog.ShowDialog() == DialogResult.OK)
                {
                    ReportGenerator.GenerateReport(emp, (int) uxDepth.Value, uxSaveDialog.FileName);
                    uxReport.Navigate(new Uri(uxSaveDialog.FileName));
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
