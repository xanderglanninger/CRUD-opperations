using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_282_Project_Milestone_2.DataLayer
{
    internal class Students
    {
        // Student fields
        string firstname, surname, image, gender, phone, address, date;
        int studentNumber, moduleCode;

        // Empty Constructor
        public Students()
        {
        }

        // Constructor
        public Students(string firstname, string surname, string image, string gender, string phone, string address, string date, int studentNumber, int moduleCode)
        {
            this.firstname = firstname;
            this.surname = surname;
            this.image = image;
            this.gender = gender;
            this.phone = phone;
            this.address = address;
            this.date = date;
            this.studentNumber = studentNumber;
            this.moduleCode = moduleCode;
        }

       

        // Getters and Setters
        public string Firstname { get => firstname; set => firstname = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Image { get => image; set => image = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string Date { get => date; set => date = value; }
        public int StudentNumber { get => studentNumber; set => studentNumber = value; }
        public int ModuleCode { get => moduleCode; set => moduleCode = value; }
        
    }
}
