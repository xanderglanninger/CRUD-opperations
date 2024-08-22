using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Programming_282_Project_Milestone_2.DataLayer; // Used to access the classes of the Data Layer

namespace Programming_282_Project_Milestone_2.BusinessLogicLayer
{
    internal class BusinessOpperations
    {

        DataHandler handler = new DataHandler(); // Creates a data handler object


        // Validation for the register of an user
        public Boolean Validate(string pass1,string pass2)
        {
            // Will return a boolean value indicating the user can continue or not
            bool giveAccess = false;
            
            if (pass1 == pass2)
            {
                // Allow access
                giveAccess = true;
            } else
            {
                // Do not allow access
                giveAccess = false;
            }

            return giveAccess;
        }


        // The following method will return a boolean value indicating if the user is allowed access or not
        public Boolean ValidateLogin(string username, string password)
        {
            bool giveAccess = false;

            List<String> lectList = handler.GetLecturers(); // Getting the list returned from the data handler class method GetLecturers

            
            // Makes sure that the list contains information
            if (lectList != null)
            {
                // The application reads through the lecturer list and searches for the username and passwords that match
                foreach (var item in lectList)
                {
                    string[] tempArr = item.Split(',');


                    // If the username and password maches with one of the stored usernames and password it will terminate the loop and give the user premission to access the application
                    if (username == tempArr[0] && password == tempArr[1])
                    {
                        giveAccess = true;
                        break; // Terminates the loop
                    }
                }
            }
            
            return giveAccess;
        }
    }
}
