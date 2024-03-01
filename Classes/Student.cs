using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MidProjectEven.Classes
{
    internal class Student
    {
        string FirstName { get; set; }
         string LastName { get; set; }
         string RegistrationNumber { get; set; }
        string Email{ get; set; }
        string Contact { get; set; }
        int Status { get; set; }


        public Student(string firstName, string lastName, string registrationNumber, string email, string contact, int status)
        {
            FirstName = firstName;
            LastName = lastName;
            RegistrationNumber = registrationNumber;
            Email = email;
            Contact = contact;
            Status = status;
        }

    }
}
