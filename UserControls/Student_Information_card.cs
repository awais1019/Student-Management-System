using MidProjectEven.Classes;
using MidProjectEven.Classes.DL;
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
       public Student student_;
        public bool checked_;
        public static CheckBox checkbox=new CheckBox();
    

        private void checkbox1_Click(object sender, EventArgs e)
        {
            bool check = checkbox1.Checked;
            StudentDL.changechecked(student_,check);  
        }

 

        private void Student_infromation_card_Load(object sender, EventArgs e)
        {
            FirstName_lable.Text = student_.FirstName;
            LastName_label.Text = student_.LastName;
            email_label.Text = student_.Email;
            contact_label.Text = student_.Contact;
            Reg_Number_label.Text = student_. RegistrationNumber;
           string name= GetStatus(student_.Status);
            if(name!=null)
           {
                status_label.Text =name.ToString();
            }
          
        }


        public Student_infromation_card(Student student)
        {
            InitializeComponent();
            student_ = student;
            checked_ = false;
        }
        public Student_infromation_card()
        {
           
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

        private void checkbox1_Leave(object sender, EventArgs e)
        {
         /*   checkbox1.Checked = false;*/
        }
    }
}
