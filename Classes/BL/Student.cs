using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MidProjectEven.Classes
{
    public class Student
    {
      public  string FirstName { get; set; }
        public string LastName { get; set; }
         public string RegistrationNumber { get; set; }
        public string Email{ get; set; }
        public string Contact { get; set; }
           public  int Status { get; set; }


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
