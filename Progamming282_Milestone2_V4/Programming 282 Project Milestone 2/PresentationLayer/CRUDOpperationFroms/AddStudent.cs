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

using Programming_282_Project_Milestone_2.DataLayer; // Used to allow access to the data layer classes

namespace Programming_282_Project_Milestone_2.PresentationLayer
{
    public partial class AddStudent : Form
    {
        // The following is used to locate the image folder where the StudentImages are stored
        string imageFolder = $@"{Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.IndexOf("bin"))}\Images";

        DataHandler handler = new DataHandler(); // Creates data handler object

        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            // Used to determine the student module and their age
            int moduleCode, studentAge = (DateTime.Now.Year - dtpDateofBirth.Value.Year);


            if (txtStuNumber.Text == "" || txtName.Text == "" || txtSurname.Text == "" || cbGender.Text == "Gender" || txtPhone.Text == "" || txtAddress.Text == "" || dtpDateofBirth.Text == "")
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

                        // Looks if the user has selected a file. If the path is empty then a default image will be added
                        if (lblPath.Text != "")
                        {
                            // Checks if the file of the same type exists in the folder
                            try
                            {
                                // If there is not a file found a new one will be added to the folder
                                File.Copy(lblPath.Text, $@"{imageFolder}\{lblName.Text}");
                                Console.WriteLine("Image was successfully saved");
                            }
                            catch (Exception err)
                            {
                                // Indication that the file exists
                                Console.WriteLine(err.Message);
                                Console.WriteLine("The image exists in the files");
                            }

                        }
                        else
                        {
                            // Adds a default picture if user did not add a picture
                            lblName.Text = "DefaultProfile.png";
                        }

                        try
                        {
                            // Creating new student object
                            Students students = new Students(txtName.Text, txtSurname.Text, lblName.Text, cbGender.Text, txtPhone.Text, txtAddress.Text, dtpDateofBirth.Text, int.Parse(txtStuNumber.Text), moduleCode);

                            // Calling the AddStudents method
                            handler.AddStudents(students);

                            // Indication of completion
                            MessageBox.Show($"{txtName.Text} {txtSurname.Text} has been added to the Database");

                            // Clearing the current entered text
                            ClearText();
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

        // If the back button is clicked it will close the current form and return to the main menu
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Used to clear all the text enter by the user
        public void ClearText()
        {
            txtStuNumber.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            lblName.Text = "";
            lblPath.Text = "";
            pbImage.ImageLocation = null;
            cbGender.Text = "Gender";
            txtPhone.Text = "";
            txtAddress.Text = "";
            dtpDateofBirth.Value = DateTime.Today;

            rbtnPRG.Checked = false; 
            rbtnLPR.Checked = false;
            rbtnWPR.Checked = false;
            rbtnMAT.Checked = false;
            rbtnINF.Checked = false;

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

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
