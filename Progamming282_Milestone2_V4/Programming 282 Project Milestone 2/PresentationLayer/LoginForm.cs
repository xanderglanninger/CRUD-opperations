using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Programming_282_Project_Milestone_2.BusinessLogicLayer; // Used to access the Business Logic Layer classes
using Programming_282_Project_Milestone_2.DataLayer; // Used to access the Data Layer classes
using Programming_282_Project_Milestone_2.PresentationLayer; // Used to access the Presentation Layer Classes and Forms

namespace Programming_282_Project_Milestone_2
{
    public partial class LoginForm : Form
    {
        BusinessOpperations opperations = new BusinessOpperations(); // Creating a business opperation object

        public LoginForm()
        {
            InitializeComponent();
        }

        // If the following button is pressed the user will log into the application, if all the information is correct
        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text, password = txtPassword.Text;

            if (username != "" && password != "")
            {
                if (opperations.ValidateLogin(username, password))
                {

                    MainMenuForm mainMenuForm = new MainMenuForm(); // Creating a main menu form object

                    ClearText(); // Clearing the current text in the text boxes

                    this.Hide(); // Hiding the current form

                    mainMenuForm.Show(); // Showing the main menu form

                    mainMenuForm.FormClosing += MainMenuForm_FormClosing; // Enabling the following method to happen before the registration form closes

                }
                else
                {
                    // Warning
                    MessageBox.Show("Your password is incorrect or your account does not exist");
                }
            }
            else
            {
                MessageBox.Show("Please make sure to enter all the information");
            }
            
        }

        // If the register button is pressed the following will be done
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register_Form registerForm = new Register_Form(); // Creating a register form object

            this.Hide(); // Hiding the current login form

            registerForm.Show(); // Showing the registration form

            registerForm.FormClosing += Register_Form_FormClosing; // Enabling the following method to happen before the registration form closes
        }

        // The following function will run when the register form closes
        private void Register_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        // The following function will run when the main menu form closes
        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        // Clears the text boxes
        public void ClearText()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
