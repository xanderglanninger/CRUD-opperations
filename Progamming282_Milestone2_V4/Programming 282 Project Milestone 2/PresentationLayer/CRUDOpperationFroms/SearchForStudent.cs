using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Programming_282_Project_Milestone_2.DataLayer; // Used to give access to the DataLayer classes

namespace Programming_282_Project_Milestone_2.PresentationLayer
{
    public partial class SearchForStudent : Form
    {
        DataHandler handler = new DataHandler(); // Creating a data handler object

        public SearchForStudent()
        {
            InitializeComponent();
        }

        // Loads all the students' information to the data grid view
        private void SearchForStudentLoad(object sender, EventArgs e)
        {
            DataSet ds = handler.GetStudents(); // Creating a DataSet object

            dgvStudents.DataSource = ds.Tables[0]; // Displays the student information with the use of a DataGridView
            dgvModules.DataSource = null; // Displays the module information with the use of a DataGridView
        }

        // If the Search button is clicked it will display the entered student number's details
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Variable used to store the text box value
            int number;

            // Try catch is used to make sure that the user enters the correct data
            try
            {
                // Converting the text box information into an int value
                number = int.Parse(txtStuNumber.Text);

                // Fetching the data from the data handler class method, SearchStudents and adding it to the created DataTable
                DataSet ds = handler.SearchStudents(number); // Creating a DataSet object

                if (ds != null)
                {
                    // Indication that the student was found
                    MessageBox.Show($"Student with the student number: {number}, was found.");

                    // Adding the DataTable information to the DataGridView's data source
                    dgvStudents.DataSource = ds.Tables[0]; // Displays the student information with the use of a DataGridView
                    dgvModules.DataSource = ds.Tables[1]; // Displays the module information with the use of a DataGridView
                    
                }
                else
                {
                    // Indication that the student was not found
                    MessageBox.Show($"Student with the student number: {number}, does not exist in the current application");
                }


            }
            catch (Exception ex)
            {
                // Warning
                Console.WriteLine(ex.Message);
                MessageBox.Show("Please enter the correct information in the search bar, example: 1001");
            }
            
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Identifies if it is in the boundries of the DataGridView table and not the headings
            if (e.RowIndex >= 0)
            {
                // Creating DataGridViewRow object to access the DataGridView Rows
                DataGridViewRow row = this.dgvStudents.Rows[e.RowIndex];

                int modulecode = int.Parse(row.Cells["ModuleCodes"].Value.ToString()); // Getting the module code from the student data grid view

                DataTable dt = handler.DisplayModule(modulecode); // Creating data table and adding the values from the database to it

                dgvModules.DataSource = null; // Clearing the dgvModules
                dgvModules.DataSource = dt; // Adding the new data table values to the data grid view
            }
        }

        // Will return back to the main page once the search form closes
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
