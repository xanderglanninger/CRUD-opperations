using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming_282_Project_Milestone_2.DataLayer;
using Programming_282_Project_Milestone_2.BusinessLogicLayer;

namespace Programming_282_Project_Milestone_2.PresentationLayer.CRUDOpperationFroms
{
    public partial class AddModuleForm : Form
    {
        public AddModuleForm()
        {
            InitializeComponent();
        }

        private void AddModuleForm_Load(object sender, EventArgs e)
        {
            DataHandler handler = new DataHandler();
            DataTable ds = handler.GetModules(); // Creating a DataSet object
           
            dgvModules.DataSource = ds; // Displays the module information with the use of a DataGridView
        }

        private void gbContainer_Enter(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Close();

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            int moduleCode;
            string name, description, ytLinks;

            moduleCode = int.Parse(txtNumber.Text);
            name = txtName.Text;
            description = txtDescription.Text;
            ytLinks = txtYTlink.Text;

            Modules module = new Modules(moduleCode, name, description, ytLinks);

            DataHandler handler = new DataHandler();
            handler.AddModules(module);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataHandler dataHandler = new DataHandler();
            

            if (textBox1.Text == "") {
                MessageBox.Show("Please enter an ID");
            } else
            {
                int num = int.Parse(textBox1.Text);
                dataHandler.DeleteModule(num);
                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataHandler dataHandler = new DataHandler();
            DataTable dt = new DataTable();

            
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter an ID");
            }
            else
            {
                int num = int.Parse(textBox1.Text);
                dt = dataHandler.SearchModule(num);
                dgvModules.DataSource = dt;
                this.Refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int moduleCode;
            string name, description, ytLinks;

            moduleCode = int.Parse(txtNumber.Text);
            name = txtName.Text;
            description = txtDescription.Text;
            ytLinks = txtYTlink.Text;

            Modules module = new Modules(moduleCode, name, description, ytLinks);

            DataHandler handler = new DataHandler();
            handler.UpdateModules(module);

            this.Refresh();
        }
    }
}
