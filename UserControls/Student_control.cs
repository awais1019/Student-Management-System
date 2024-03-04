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
using MidProjectEven.Classes.DL;
using System.Reflection.Emit;
using System.Diagnostics.Eventing.Reader;

namespace MidProjectEven.UserControls
{
    public partial class Student_control : UserControl
    {


        List<Student_infromation_card> checked_students=new List<Student_infromation_card> ();
        public Student_control() 
        {
        
            InitializeComponent();
        
        }
        List<Student> loadData()
        {
            List<Student> list = new List<Student>();
            StudentDL.List.Clear();
            list.Clear();
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
                        list.Add(student);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return list;
        }

   void display()
        {
            List<Student> list = loadData();
            foreach(var person in list)
            {
                Student student = new Student(person.FirstName, person.LastName, person.RegistrationNumber, person.Email, person.Contact, person.Status);
                Student_infromation_card card = new Student_infromation_card(student);
                StudentDL.Add_Students(card);
                flowLayoutPanel.Controls.Add(card);
                flowLayoutPanel.ResumeLayout();
            }
            count_students_label.Text = StudentDL.List.Count.ToString();
        }
        void display(List<Student> list)
        {
            flowLayoutPanel.Controls.Clear();
            foreach (var person in list)
            {
                Student student = new Student(person.FirstName, person.LastName, person.RegistrationNumber, person.Email, person.Contact, person.Status);
                Student_infromation_card card = new Student_infromation_card(student);
                StudentDL.Add_Students(card);
                flowLayoutPanel.Controls.Add(card);
                flowLayoutPanel.ResumeLayout();
            }
            count_students_label.Text = StudentDL.List.Count.ToString();

        }
        void editHeader()
        {
            first_name_label.Text = "Edit";
            email_label.Text = "";
            last_name_label.Text = "Delete";
            status_label.Text = "Mark Attendance";
            status_label.ForeColor= Color.FromArgb(0,118,212);
            reg_number.Text = "";
            contact_label.Text = "";
           
           
          }
        void editHeader1()
        {
            status_label.ForeColor = Color.White;
            last_name_label.Text = "Last Name";
            email_label.Text = "Email";
            status_label.Text = "Status";
            first_name_label.Text = "First Name";
            reg_number.Text = "Registration Number";
            contact_label.Text = "Contact";
       
        }





        

        private void Add_student_btn_Click(object sender, EventArgs e)
        {
            /* Student student = null;
             Full_panel.Controls.Clear();
             Add_Student_Control control = new Add_Student_Control(student);
             Full_panel.Dock = DockStyle.Fill;
            control.Dock= DockStyle.Fill;
          *//*   StoreControls.AddControl(control);*//*
             Full_panel.Controls.Add(control);*/
            GetCheckedStudent();
          
        }



        private void Searchbox_TextChanged(object sender, EventArgs e)
        {

            List<Student> list = SearchData(Searchbox.Text.ToString());
            if (list != null)
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
            display();
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

        private void flowLayoutPanel_Scroll(object sender, ScrollEventArgs e)
        {

        }


    
        private void timer_to_check_selected_Tick(object sender, EventArgs e)
        {
        
            check();
        }

        void check()
        {
          checked_students = StudentDL.count_checked_student();
          
            if (checked_students.Count > 0)
            {
                editHeader();
            }
           else
            {
                editHeader1();
            }
        }

        private void first_name_label_Click(object sender, EventArgs e)
        {
          /*  StudentDL.AllUnchecked(false);*/
            checked_students = StudentDL.count_checked_student();

            if (checked_students.Count > 1)
            {
                MessageBox.Show("Please Select Only One Student at a time");
            }
            else
            {
                GetCheckedStudent();
            }

        }

        public void GetCheckedStudent()
        {
            Student student = StudentDL.GetCheckedStudent();
            Full_panel.Controls.Clear();
            Add_Student_Control control = new Add_Student_Control(student);
            Full_panel.Dock = DockStyle.Fill;
            control.Dock = DockStyle.Fill;
            Full_panel.Controls.Add(control);
        }
    }
}
