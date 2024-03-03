using MidProjectEven.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidProjectEven.UserControls
{
    public partial class Student_infromation_card : UserControl
    {

        string firstname, lastname, email, contact, regNumber;
        int status;

        private void checkbox1_Click(object sender, EventArgs e)
        {

        }

 

        private void Student_infromation_card_Load(object sender, EventArgs e)
        {
            FirstName_lable.Text = firstname;
            LastName_label.Text = lastname;
            email_label.Text = email;
            contact_label.Text = contact;
            Reg_Number_label.Text = regNumber;
           string name= GetStatus(status);
            if(name!=null)
           {
                status_label.Text =name.ToString();
            }
          


        }


        public Student_infromation_card(Student student)
        {
            InitializeComponent();
            firstname= student.FirstName;
            lastname= student.LastName;
            email= student.Email;
            contact= student.Contact;
            regNumber = student.RegistrationNumber;
            status=student.Status;
                     

        }


        public string GetStatus(int id)
        {
            using (SqlConnection connection = new SqlConnection(Configuration.SqlConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Name FROM Lookup WHERE LookupId = @id AND Category = 'STUDENT_STATUS'";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        return result.ToString();
                    }
             
                }
                catch (Exception ex)
                {
                
                    MessageBox.Show(ex.Message);
             
                }
                return null;
            }
        }

       
    }
}
