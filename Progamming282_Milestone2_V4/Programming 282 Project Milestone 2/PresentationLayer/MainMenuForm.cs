using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

using System.IO;

using Programming_282_Project_Milestone_2.DataLayer; // Used to access the classes in the Data Layer
using Programming_282_Project_Milestone_2.PresentationLayer.CRUDOpperationFroms; // Used to access the forms in the presentation layer

namespace Programming_282_Project_Milestone_2.PresentationLayer
{
    public partial class MainMenuForm : Form
    {
        DataHandler handler = new DataHandler(); // Creating a data handler object

        // The following is used to locate the image folder where the StudentImages are stored
        string imageFolder = $@"{Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.IndexOf("bin"))}\Images";

        public MainMenuForm()
        {
            InitializeComponent();
        }

        // If the delete student records button is clicked it will display the delete student form
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteStudent deleteStudentForm = new DeleteStudent(); // Creating the delete form object

            this.Hide(); // Hiding the current form

            deleteStudentForm.Show(); // Displaying the delete form

            deleteStudentForm.FormClosing += DeleteStudent_FormClosing; // In the event of the add delete form closing it will run the method attached
        }

        // The following method will run as the add delete form closes
        private void DeleteStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            // It will show the current form again
            this.Show();

            // Update the Data Grid View
            LoadDGV();
        }

        // If the add student button is clicked the following will happen
        private void btnAddStu_Click(object sender, EventArgs e)
        {
            AddStudent addStudentForm = new AddStudent(); // Creating add student form object

            this.Hide(); // Hiding the current form

            addStudentForm.Show(); // Showing the add student form

            addStudentForm.FormClosing += AddStudent_FormClosing; // In the event of the add student form closing it will run the method attached
        }

        // The following method will run as the add student form closes
        private void AddStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            // It will show the current form again
            this.Show();

            // Update the Data Grid View
            LoadDGV();

        }

        // If the Search button is pressed the following will happen
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForStudent searchForStudent = new SearchForStudent(); // Creating a Search student object

            this.Hide(); // Hiding the main form

            searchForStudent.Show(); // Showing the search form

            searchForStudent.FormClosing += SearchForStudent_FormClosing; // In the event of the search form closing the following method will be executed

        }

        // The following method will be executed as the search form closes
        private void SearchForStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show(); // Shows the main form

            ClearImage(); // Clears the image out of the picture box if any was displayed
        }

        // If the Update button is pressed it will display the update form
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm(); // Creating the update form object

            this.Hide();

            updateForm.Show(); // Displaying the update form

            updateForm.FormClosing += UpdateForm_FormClosing; // In the event of the update form closing the following method will be executed
        }

        private void UpdateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // It will show the current form again
            this.Show();

            // Update the Data Grid View
            LoadDGV();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            DataSet ds = handler.GetStudents(); // Creating a DataSet object

            dgvStudents.DataSource = ds.Tables[0]; // Displays the student information with the use of a DataGridView
            dgvModules.DataSource = null; // Clears the dgvModule
        }

        // If the exit button is clicked, the user will exit the whole program
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // If the log out button is clicked, the user will be sent back to the login screen
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // The following function is used to load all the changes made by the other forms, so that the DataGridView is constantly updated
        public void LoadDGV()
        {
            DataSet ds = handler.GetStudents(); // Creating a DataSet object
            

            dgvStudents.DataSource = null; // Clear the DataGridView to avoid errors from occuring
            dgvModules.DataSource = null;

            dgvStudents.DataSource = ds.Tables[0]; // Displays the student information with the use of a DataGridView
            dgvModules.DataSource = null; // Clears the dgvModule

            ClearImage(); // Clears the image out of the picture box if any was displayed
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvStudents.Rows[e.RowIndex];
                
                int modulecode = int.Parse(row.Cells["ModuleCodes"].Value.ToString());

                string img = row.Cells["StudentImage"].Value.ToString();

                if (img == "")
                {
                    pbImage.ImageLocation = null;
                }
                else
                {
                    pbImage.ImageLocation = $@"{imageFolder}\{img}";
                }

                DataTable dt = handler.DisplayModule(modulecode);

                dgvModules.DataSource = null;
                dgvModules.DataSource = dt;

            }
        }

        public void ClearImage()
        {
            pbImage.ImageLocation = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddModuleForm addModuleForm = new AddModuleForm();
            addModuleForm.Show();
            this.Hide();
        }
    }
}
