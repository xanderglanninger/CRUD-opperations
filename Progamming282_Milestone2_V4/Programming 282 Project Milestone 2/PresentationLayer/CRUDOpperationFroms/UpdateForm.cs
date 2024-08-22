using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Programming_282_Project_Milestone_2.DataLayer; // Used to allow access to all the classes in the DataLayer

namespace Programming_282_Project_Milestone_2.PresentationLayer.CRUDOpperationFroms
{
    public partial class UpdateForm : Form
    {
        // The following is used to locate the image folder where the StudentImages are stored
        string imageFolder = $@"{Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.IndexOf("bin"))}\Images";

        DataHandler handler = new DataHandler(); // Creating a data handler object to allow access to the methods that the class contains
        public UpdateForm()
        {
            InitializeComponent();
        }


        private void UpdateForm_Load(object sender, EventArgs e)
        {
            DataSet ds = handler.GetStudents(); // Creating a DataSet object

            dgvStudents.DataSource = ds.Tables[0]; // Displays the student information with the use of a DataGridView
            dgvModules.DataSource = null; // Displays the module information with the use of a DataGridView
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Used to determine the student module and their age
            int moduleCode, studentAge = (DateTime.Now.Year - dtpDateofBirth.Value.Year);


            if (txtStuNum.Text == "" || txtName.Text == "" || txtSurname.Text == "" || cbGender.Text == "Gender" || txtPhone.Text == "" || txtAddress.Text == "" || dtpDateofBirth.Text == "")
            {
                // If the user forgot to enter some of the information the system will warn them
                MessageBox.Show("Please make sure to enter all required data.");
            }
            else
            {
                // The students have to be doing a module and in the event of not selecting a module the application will warn the user to choose a module.
                if (rbtnPRG.Checked == false && rbtnLPR.Checked == false && rbtnWPR.Checked == false && rbtnMAT.Checked == false && rbtnINF.Checked == false)
                {
                    // Warning
                    MessageBox.Show("Student module has not been selected");
                }
                else
                {
                    // Makes sure that the student is at least 18 years old
                    if (studentAge >= 18)
                    {
                        // Alocating value to the module that the student is taking
                        if (rbtnPRG.Checked)
                        {
                            moduleCode = 1;
                        }
                        else if (rbtnLPR.Checked)
                        {
                            moduleCode = 2;
                        }
                        else if (rbtnWPR.Checked)
                        {
                            moduleCode = 3;
                        }
                        else if (rbtnMAT.Checked)
                        {
                            moduleCode = 4;
                        }
                        else
                        {
                            moduleCode = 5;
                        }

                        // Creating new student object

                        try
                        {
                            // Creating new student object
                            Students students = new Students(txtName.Text, txtSurname.Text, lblName.Text, cbGender.Text, txtPhone.Text, txtAddress.Text, dtpDateofBirth.Text, int.Parse(txtStuNum.Text), moduleCode);

                            // Calling the UpdateStudents method
                            
                            if (handler.UpdateStudents(students))
                            {
                                // Will not try and add a new image if it was not initiated by the user
                                if (lblPath.Text != "")
                                {
                                    try
                                    {
                                        // Copies the file into the image folder of the application
                                        File.Copy(lblPath.Text, $@"{imageFolder}\{lblName.Text}");
                                        Console.WriteLine("Image was successfully saved");
                                    }
                                    catch (Exception err)
                                    {
                                        // Indicates that there is a file/image of the same type
                                        Console.WriteLine(err.Message);
                                        Console.WriteLine("The image exists in the files");
                                    }

                                }
                                else
                                {
                                }

                                // Indication of completion
                                MessageBox.Show($"{txtName.Text} {txtSurname.Text} has been updated");

                                // Used to update the DataGridView to the latest version
                                UpdateDGV();

                                // Clearing the current entered text
                                ClearText();
                            }
                            

                        }
                        catch (Exception err)
                        {
                            Console.WriteLine(err.Message);
                            MessageBox.Show("Make sure that your inputs are in the correct format");
                        }
                    }
                    else
                    {
                        // Warning
                        MessageBox.Show("Student is younger than 18");
                    }
                }
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

        // If the back button is clicked it will return the user to the main menu
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Is used to clear all the text boxes
        public void ClearText()
        {
            txtStuNum.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            lblName.Text = "";
            lblPath.Text = "";
            pbImage.ImageLocation = null;
            cbGender.Text = "Gender";
            txtPhone.Text = "";
            txtAddress.Text = "";
            dtpDateofBirth.Value = DateTime.Now;

            rbtnPRG.Checked = false;
            rbtnLPR.Checked = false;
            rbtnWPR.Checked = false;
            rbtnMAT.Checked = false;
            rbtnINF.Checked = false;
        }

        // The following function will allow the user to click on a cell of the DataGridView and it will insert the information into the text boxes and given inputs
        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Identifies if it is in the boundries of the DataGridView table and not the headings
            if (e.RowIndex >= 0)
            {
                // Creating DataGridViewRow object to access the DataGridView Rows
                DataGridViewRow row = this.dgvStudents.Rows[e.RowIndex];

                // Creating DataGridViewRow object to access the DataGridView Rows
                int modulecode = int.Parse(row.Cells["ModuleCodes"].Value.ToString());
                string imgName = row.Cells["StudentImage"].Value.ToString();

                txtStuNum.Text = row.Cells["StudentNumber"].Value.ToString(); // StudentNumber
                txtName.Text = row.Cells["FirstName"].Value.ToString(); // FirstName
                txtSurname.Text = row.Cells["Surname"].Value.ToString(); // Surname
                pbImage.ImageLocation = $@"{imageFolder}\{imgName}"; // Image
                lblName.Text = imgName; // Image Name
                cbGender.Text = row.Cells["Gender"].Value.ToString(); // Gender
                txtPhone.Text = row.Cells["Phone"].Value.ToString(); // Phone
                txtAddress.Text = row.Cells["StudentAddress"].Value.ToString(); // StudentAddress
                dtpDateofBirth.Text = row.Cells["DOB"].Value.ToString(); // DOB

                // Variable to store the info of the student module codes
                int module = int.Parse(row.Cells["ModuleCodes"].Value.ToString());

                // The following if statement identifies which radio button should be ticked
                if ( module == 1)
                {
                    rbtnPRG.Checked = true;
                }
                else if (module == 2)
                {
                    rbtnLPR.Checked = true;
                }
                else if (module == 3)
                {
                    rbtnWPR.Checked = true;
                }
                else if (module == 4)
                {
                    rbtnMAT.Checked = true;
                }
                else
                {
                    rbtnINF.Checked = true;
                }

                DataTable dt = handler.DisplayModule(modulecode); // Creating data table and adding the values from the database to it

                

                dgvModules.DataSource = null; // Clearing the dgvModules
                dgvModules.DataSource = dt; // Adding the new data table values to the data grid view

            }
        }

        // If the following button is clicked a user will be able to upload an image from their computer
        private void btnUpload_Click(object sender, EventArgs e)
        {
            // The following is used to filter only jpg and png files that could be uploaded
            openFileDialog1.Filter = "PNG files (*.png)|*.png| JPG files (*.jpg)|*.jpg";

            // The if statement is used to see if a user has selected a file to upload
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Gets the name of the file/image selected
                lblName.Text = Path.GetFileName(openFileDialog1.FileName);
                // Gets the full path of where the image is currently stored on the computer
                lblPath.Text = Path.GetFullPath(openFileDialog1.FileName);

                // Adds the image to the picture box
                pbImage.ImageLocation = lblPath.Text;
            }
            else
            {
                // Warning
                Console.WriteLine("User did not select a file");
            }
        }
    }
}
