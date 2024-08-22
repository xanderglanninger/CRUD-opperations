using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Programming_282_Project_Milestone_2.DataLayer; // Used to allow access to the DataLayer classes
using Programming_282_Project_Milestone_2.BusinessLogicLayer; // Used to allow access to the BusinessLogicLayer classes

namespace Programming_282_Project_Milestone_2.PresentationLayer
{
    public partial class Register_Form : Form
    {
        BusinessOpperations opperations = new BusinessOpperations(); // Used to create an business opperations object.

        DataHandler handler = new DataHandler(); // Used to create an data handler object.

        string path = @"Lecturers.txt"; // Creates the text file in the bin/debug folder

        public Register_Form()
        {
            InitializeComponent();
        }

        // If button is clicked it will register an user and add them to the text file in the bin/debug folder
        private void btnRegister_Click(object sender, EventArgs e)
        {

            string username = txtUserName.Text, password1 = txtPassword.Text, password2 = txtCheckPass.Text;
            
            // Used to confirm the password that was entered first
            if (opperations.Validate(password1,password2))
            {
                // Calls a method that will create a new lecturer
                handler.AddLecturers(path, username, password1);
                this.Close();

            } else
            {
                // Warning
                MessageBox.Show("ALERT: The passwords do not match");
            }
        }

        // If the button is clicked it will return the user to the login page
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
