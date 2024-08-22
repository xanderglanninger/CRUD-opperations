using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

using Programming_282_Project_Milestone_2.PresentationLayer; // Used to access the classes of the presentation layer
using Programming_282_Project_Milestone_2.BusinessLogicLayer; // Used to access the classes of the business layer

namespace Programming_282_Project_Milestone_2.DataLayer
{
    internal class DataHandler
    {
        // The following is used to locate the image folder where the StudentImages are stored
        string imageFolder = $@"{Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.IndexOf("bin"))}\Images";

        // SQLExpress
        string connection = @"Server=DESKTOP-O2PN62F; Initial Catalog=BelgiumCampusDataBase; Integrated Security=SSPI";

        // Text File location in the bin/debug folder
        string path = @"Lecturers.txt";

        // The following method is used to get the student information from the database
        public DataSet GetStudents()
        {
            string query = @"SELECT * FROM Students; SELECT * FROM Modules"; // Query used to select all the students and the modules in the database

            SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, connection); // Represents the data commands and connection

            DataSet ds = new DataSet(); // Used to create a DataSet object

            sqlAdapter.Fill(ds); // Adding the information from the database to the DataTable

            return ds; // Returns the DataTable containing all the student information
        }

        // The following method is used to search for a student in the database and it will return the information igf it finds the student
        public DataSet SearchStudents(int number)
        {
            // Query used to see if the student exists
            string query = $"SELECT * FROM Students WHERE StudentNumber = {number}";
            

            SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, connection); // Used to read data from a database

            DataTable dtStudent = new DataTable(); // Used to create a DataSet object

            sqlAdapter.Fill(dtStudent); // Adding the information from the database to the DataTable

            DataSet ds = new DataSet();

            if (dtStudent.Rows.Count >= 1)
            {
                string dataSetQuery = $"SELECT * FROM Students WHERE StudentNumber = {number}; SELECT * FROM Modules WHERE ModuleCodes = {dtStudent.Rows[0][8]}";

                sqlAdapter = new SqlDataAdapter(dataSetQuery, connection); // Used to read data from a database

                sqlAdapter.Fill(ds);
            }
            else
            { 
                ds = null;
            }
            

            return ds; // Returns the DataTable containing the searched student's information

        }

        public DataTable DisplayModule(int code)
        {
            string query = $"SELECT * FROM Modules WHERE ModuleCodes = {code}"; // Query used to select all the students and the modules in the database

            SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, connection); // Represents the data commands and connection

            DataTable dt = new DataTable(); // Used to create a DataTable object

            sqlAdapter.Fill(dt); // Adding the information from the database to the DataTable

            return dt; // Returns the DataTable containing all the student information
        }

        // The following method is used to add a new student to the database.
        public void DeleteStudents(int number)
        {
            try
            {
                // Query used to insert the new student with their information
                string query = $"DELETE FROM Students WHERE StudentNumber = {number}"; // Query used to delete the student from the database

                string imgQuery = $"SELECT StudentImage FROM Students WHERE StudentNumber = {number};"; // Query used to get the name of the image that the student is using

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(imgQuery, connection); // Creating an sql data adapter object

                DataTable dt = new DataTable(); // Creating a data table object

                // Inserts the information from the database into the data table
                sqlAdapter.Fill(dt);

                // The following is to get the image name that a user is using
                string imgName = dt.Rows[0][0].ToString();

                // The folowing query will be used to count the number of rows that contain the same image name
                string countQuery = $"SELECT * FROM Students WHERE StudentImage = '{imgName}';";

                // The sqlAdapter adds the information from the database to the data table
                sqlAdapter = new SqlDataAdapter(countQuery, connection);

                dt.Clear(); // Clears a DataTable so the new query data can bbe added to it

                // The sqlAdapter adds the information from the database to the data table
                sqlAdapter.Fill(dt);

                // The following if statement avoid deleting the default image and an image that is used by multiple users
                if (imgName != "DefaultProfile.png" && imgName != "..." && dt.Rows.Count == 1)
                {
                    File.Delete($@"{imageFolder}\{imgName}");
                }
                else
                {
                    // Indication that image will not be deleted
                    Console.WriteLine("There is still a person using the image it will not be deleted");
                }
                
                // Creating a connection
                using (SqlConnection sqlConnection = new SqlConnection(connection))
                {
                    // Creating the command
                    using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                    {
                        sqlConnection.Open(); // Opening the connection                     
                        cmd.ExecuteNonQuery(); // Executing the command
                        sqlConnection.Close(); // Closing the connection
                    }
                }

                // Confirmation Message
                MessageBox.Show($"Student with student number: {number}, has been deleted");
            }
            catch (Exception ex)
            {
                // Warning
                Console.WriteLine(ex.Message);
                MessageBox.Show($"Student: {number}, does not exist in the current application");
            }
        }

        // The following method is used to add a new student to the database.
        public void AddStudents(Students students)
        {
            try
            {
                // Query used to insert the new student with their information
                string query = $"INSERT INTO Students VALUES ({students.StudentNumber}, '{students.Firstname}', '{students.Surname}', '{students.Image}', '{students.Date}', '{students.Gender}', '{students.Phone}', '{students.Address}', {students.ModuleCode})";

                // Creating a connection
                using (SqlConnection sqlConnection = new SqlConnection(connection))
                {
                    // Creating the command
                    using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                    {
                        sqlConnection.Open(); // Opening the connection                     
                        cmd.ExecuteNonQuery(); // Executing the command
                        sqlConnection.Close(); // Closing the connection
                    }
                }
            }
            catch (Exception ex)
            {
                // Warning
                Console.WriteLine(ex.Message);
                MessageBox.Show("Something went wrong while trying to add a new student.");
            }
        }

        // The following method is used to update a student contained in the database.
        public bool UpdateStudents(Students students)
        {
            string query;
            string checkQuery = $"SELECT * FROM Students WHERE StudentNumber = {students.StudentNumber}";
            bool userExist = false;

            DataTable dtCheck = new DataTable();

            SqlDataAdapter checkAdapter = new SqlDataAdapter(checkQuery, connection);

            checkAdapter.Fill(dtCheck);

            if (dtCheck.Rows.Count >= 1)
            {
                try
                {
                    // Query used to update the new student with their information
                    if (students.Image == "...")
                    {
                        query = $"UPDATE Students SET FirstName = '{students.Firstname}', Surname = '{students.Surname}', DOB = '{students.Date}', Gender = '{students.Gender}', Phone = '{students.Phone}', StudentAddress = '{students.Address}', ModuleCodes = {students.ModuleCode} WHERE StudentNumber = {students.StudentNumber}";
                    }
                    else
                    {
                        query = $"UPDATE Students SET FirstName = '{students.Firstname}', Surname = '{students.Surname}', StudentImage = '{students.Image}', DOB = '{students.Date}', Gender = '{students.Gender}', Phone = '{students.Phone}', StudentAddress = '{students.Address}', ModuleCodes = {students.ModuleCode} WHERE StudentNumber = {students.StudentNumber}";
                    }



                    // Creating a connection
                    using (SqlConnection sqlConnection = new SqlConnection(connection))
                    {
                        // Creating the command
                        using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                        {
                            sqlConnection.Open(); // Opening the connection
                            cmd.ExecuteNonQuery(); // Executing the command
                            sqlConnection.Close(); // Closing the connection
                        }
                    }

                    userExist = true;
                }
                catch (Exception ex)
                {
                    // Warning
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Something went wrong while trying to update the student information");
                }
            }
            else
            {
                MessageBox.Show($"Student: {students.StudentNumber}, does not exists in the current application.");
            }

            return userExist;
        }

        // The following method returns a list of all the lecturer stored in the text file
        public List<String> GetLecturers()
        {
            List<String> lectList = new List<String>(); // Creating a list to store all the lecturer info in.
            if (File.Exists(path))
            {
                // Using StreamReader object to read the information stored in the text file, line by line
                using (StreamReader reader = new StreamReader(path))
                {
                    // The text file information will be added to the variable and then the variable will be added to the list
                    string line;

                    // Reads all the lines that contain information
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Adding the information from the text file to the lecturer list
                        lectList.Add(line);
                    }
                }

                // Returning the list so it can be used by other layers, like the business layer
                return lectList;
            }
            else
            {
                Console.WriteLine("There are no users registered.");
            }
            
            return null;
        }

        // The following method is used to add a new lecturer to the text file with their entered information
        public void AddLecturers (string path, string username, string password)
        {
            // Adding the username and password into one string, so it can be stored easier
            string userInfo = $"{username},{password}";
            // The array help by storing the information into the text file, line by line
            string[] tempArr = new string[1];

            tempArr[0] = userInfo; // Adding the string to the array

            File.AppendAllLines(path, tempArr); // Appending the new text to the text file

            // Confirmation of registration
            MessageBox.Show("Account Registered");
        }

        public DataTable GetModules()
        {
            string query = @"SELECT * FROM Modules";
            DataTable ds = new DataTable();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);

            sqlDataAdapter.Fill(ds);
            return ds;

        }

        public void AddModules(Modules modules)
        {
            try
            {
                // Query used to insert the new student with their information
                string query = $"INSERT INTO Modules VALUES ({modules.ModuleCode}, '{modules.Name}', '{modules.Description}', '{modules.YtLinks}')";

                // Creating a connection
                using (SqlConnection sqlConnection = new SqlConnection(connection))
                {
                    // Creating the command
                    using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                    {
                        sqlConnection.Open(); // Opening the connection                     
                        cmd.ExecuteNonQuery(); // Executing the command
                        sqlConnection.Close(); // Closing the connection
                    }
                }
                MessageBox.Show("Module Added");
            }
            catch (Exception ex)
            {
                // Warning
                Console.WriteLine(ex.Message);
                MessageBox.Show("Something went wrong while trying to add a new Module.");
            }
        }

        public void UpdateModules(Modules modules)
        {
            try
            {
                // Query used to insert the new student with their information
                string query = $"UPDATE Modules SET ModuleName = '{modules.Name}', ModuleDescription = '{modules.Description}', YTlinks = '{modules.YtLinks}' WHERE ModuleCodes = '{modules.ModuleCode}'";

                // Creating a connection
                using (SqlConnection sqlConnection = new SqlConnection(connection))
                {
                    // Creating the command
                    using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                    {
                        sqlConnection.Open(); // Opening the connection                     
                        cmd.ExecuteNonQuery(); // Executing the command
                        sqlConnection.Close(); // Closing the connection
                    }
                }
                MessageBox.Show("Module Updated");
            }
            catch (Exception ex)
            {
                // Warning
                Console.WriteLine(ex.Message);
                MessageBox.Show("Something went wrong while trying to add a new Module.");
            }
        }

        public void DeleteModule(int num)
        {
            string query = $"DELETE FROM Modules WHERE ModuleCodes = {num}";
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                // Creating the command
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    sqlConnection.Open(); // Opening the connection                     
                    cmd.ExecuteNonQuery(); // Executing the command
                    sqlConnection.Close(); // Closing the connection
                }
            }
            MessageBox.Show("Module Deleted");

        }
        public DataTable SearchModule(int num)
        {
            string query = $"SELECT * FROM Modules WHERE ModuleCodes = {num}";
            DataTable dt = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            adapter.Fill(dt);
            return dt;
            
        }
    }
}
