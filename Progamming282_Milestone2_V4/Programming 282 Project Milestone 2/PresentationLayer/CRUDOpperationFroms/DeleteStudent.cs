using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Programming_282_Project_Milestone_2.DataLayer; // Used to allow access to the classes of the DataLayer

namespace Programming_282_Project_Milestone_2.PresentationLayer.CRUDOpperationFroms
{
    public partial class DeleteStudent : Form
    {
        DataHandler handler = new DataHandler(); // Creates a data handler object

        public DeleteStudent()
        {
            InitializeComponent();
        }
        
        // The following will run when the form loads
        private void DeleteStudent_Load(object sender, EventArgs e)
        {

            DataSet ds = handler.GetStudents(); // Creating a DataSet object

            dgvStudents.DataSource = ds.Tables[0]; // Displays the student information with the use of a DataGridView
            dgvModules.DataSource = null; // Displays the module information with the use of a DataGridView

        }
        
        // If the delete button is pressed, the following will run
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                handler.DeleteStudents(int.Parse(txtStuNum.Text)); // Calls the delete method and passes the student number to the delete method
                UpdateDGV();
                txtStuNum.Text = "";

            }
            catch (Exception ex)
            {
                // Warning
                Console.WriteLine(ex.Message);
                MessageBox.Show("Please enter the correct information and avoid leaving the input open.");
            }
        }

        private void dgvDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Identifies if it is in the boundries of the DataGridView table and not the headings
            if (e.RowIndex >= 0)
            {
                // Creating DataGridViewRow object to access the DataGridView Rows
                DataGridViewRow row = this.dgvStudents.Rows[e.RowIndex];

                txtStuNum.Text = row.Cells["StudentNumber"].Value.ToString(); // StudentNumber

            }
        }

        // The following method is used to update the DataGridView
        public void UpdateDGV()
        {
            DataSet ds = handler.GetStudents(); // Creating a DataSet object


            dgvStudents.DataSource = null; // Clear the DataGridView to avoid errors from occuring
            dgvModules.DataSource = null;

            dgvStudents.DataSource = ds.Tables[0]; // Displays the student information with the use of a DataGridView
            dgvModules.DataSource = null; // Displays the module information with the use of a DataGridView
        }

        // If the back button is pressed, user will return to main menu
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // If a cell in the dgvStudent is clicked then it will display the student's module in the dgvModule
        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Identifies if it is in the boundries of the DataGridView table and not the headings
            if (e.RowIndex >= 0)
            {
                // Creating DataGridViewRow object to access the DataGridView Rows
                DataGridViewRow row = this.dgvStudents.Rows[e.RowIndex];

                // Updates the student number text box each time you click on a new cell
                txtStuNum.Text = row.Cells["StudentNumber"].Value.ToString();

                int modulecode = int.Parse(row.Cells["ModuleCodes"].Value.ToString()); // Getting the module code from the student data grid view

                DataTable dt = handler.DisplayModule(modulecode); // Creating data table and adding the values from the database to it

                dgvModules.DataSource = null; // Clearing the dgvModules
                dgvModules.DataSource = dt; // Adding the new data table values to the data grid view
            }
        }
    }
}
