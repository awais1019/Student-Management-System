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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MidProjectEven.UserControls
{
    public partial class Student_control : UserControl
    {
        static List<Student>studentsllist = new List<Student>();
        public Student_control()
        {
            InitializeComponent();
        
        }
        void loadData()
        {

           studentsllist.Clear();
            using (SqlConnection connection = new SqlConnection(Configuration.SqlConnectionString))
            {
                connection.Open();

                try
                {
                    string query = "SELECT FirstName, LastName, Contact, Email, RegistrationNumber, Status FROM Student";
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string FirstName = reader["FirstName"].ToString();
                        string LastName = reader["LastName"].ToString();
                        string Contact = reader["Contact"].ToString();
                        string Email = reader["Email"].ToString();
                        string RegistrationNumber = reader["RegistrationNumber"].ToString();
                        int Status = Convert.ToInt32(reader["Status"]);
                        Student student = new Student (FirstName, LastName, RegistrationNumber, Email, Contact ,Status);                     
                        studentsllist.Add(student);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

   
        void display(List<Student>list)
        {
            flowLayoutPanel.Controls.Clear();
            foreach(var person in list)
            {
                Student student = new Student(person.FirstName, person.LastName, person.RegistrationNumber, person.Email, person.Contact, person.Status);
                Student_infromation_card hello = new Student_infromation_card(student); 
                flowLayoutPanel.Controls.Add(hello);
                flowLayoutPanel.ResumeLayout();
            }
            count_students_label.Text = studentsllist.Count.ToString();
         
        }

      
        private void Add_student_btn_Click(object sender, EventArgs e)
        {
            Full_panel.Controls.Clear();
            Add_Student_Control control = new Add_Student_Control();
            Full_panel.Dock = DockStyle.Fill;
           control.Dock= DockStyle.Fill;
            Full_panel.Controls.Add(control);
          
        }
   
        

        private void Searchbox_TextChanged(object sender, EventArgs e)
        {

          List<Student>list= SearchData(Searchbox.Text.ToString());
         if(list!=null)
            {
                display(list);
            }
         else
            {
                MessageBox.Show("No Record Found");
                databind();
            }
        }

        private void Student_control_Load(object sender, EventArgs e)
        {
            databind();
        }

        public void databind()
        {
            loadData();
            display(studentsllist);
        }
        public List<Student> SearchData(string name)
        {
            List<Student> result = new List<Student>();

            using (SqlConnection connection = new SqlConnection(Configuration.SqlConnectionString))
            {
                connection.Open();

                try
                {
                    string query = "SELECT FirstName, LastName, Contact, Email, RegistrationNumber, Status FROM Student WHERE FirstName = @name";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", name);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string FirstName = reader["FirstName"].ToString();
                        string LastName = reader["LastName"].ToString();
                        string Contact = reader["Contact"].ToString();
                        string Email = reader["Email"].ToString();
                        string RegistrationNumber = reader["RegistrationNumber"].ToString();
                        int Status = Convert.ToInt32(reader["Status"]);
                        Student student = new Student(FirstName, LastName, RegistrationNumber, Email, Contact, Status);
                        result.Add(student);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return result;
        }

        private void Searchbox_Leave(object sender, EventArgs e)
        {
            databind();
        }
    }
}
