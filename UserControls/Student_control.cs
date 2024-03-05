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
using MidProjectEven.Properties;

namespace MidProjectEven.UserControls
{
    public partial class Student_control : UserControl
    {


        List<Student_infromation_card> checked_students=new List<Student_infromation_card> ();
        ClassAttendance attendance;
        int value;
        public Student_control() 
        {
        
            InitializeComponent();
            FillAttendancebox();
            Attendance_box.SelectedIndex = 0;
            value = 0;



        }
        List<Student> loadData()
        {
            List<Student> list = new List<Student>();
            StudentDL.List.Clear();
            list.Clear();
            using (SqlConnection connection = new SqlConnection(DataBase.SqlConnectionString))
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
            }
            Addcards();
            count_students_label.Text = StudentDL.List.Count.ToString();
        }

        void Addcards()
        {
            foreach (var card in StudentDL.List)
            {
                flowLayoutPanel.Controls.Add(card);
                flowLayoutPanel.ResumeLayout();
            }
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
            count_students_label.Text = list.Count.ToString();

        }


       
        private void Add_student_btn_Click(object sender, EventArgs e)
        {
            checked_students = StudentDL.count_checked_student();
            if (checked_students.Count>1)
            {
                MessageBox.Show("Please Select Only One Student at a time");
                return;
            }
            else
            {
                GetCheckedStudent();
            }




        }



        private void Searchbox_TextChanged(object sender, EventArgs e)
        {

            List<Student> list = DataBase.SearchData(Searchbox.Text.ToString());
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

            if (checked_students.Count ==0)
            {
                Add_student_btn.Image = Properties.Resources.icons8_add_50__2_;
                Add_student_btn.Text = "Add Student";
                Attendance_box.Enabled = false;
                Mark_Attandance.Visible = false;

            }
            else if ((checked_students.Count >=1))
            {
                Add_student_btn.Image = Properties.Resources.icons8_update_64__1_;
                Add_student_btn.Text = "Update Student";
                Attendance_box.Enabled = true;
             
                Mark_Attandance.Visible = true;


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

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void Attendance_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void FillAttendancebox()
        {
            List<string>list = new List<string>();
           list= DataBase.FillStatusComboBox();
            for(int i = 0; i < list.Count; i++) 
            {
                Attendance_box.Items.Add(list[i]); 
            }
        }

        private void Mark_Attandance_Click(object sender, EventArgs e)
        {
            checked_students = StudentDL.count_checked_student();
            int AttendanceStatus=-1, studentid=-1, attendanceid=-1;

            if (checked_students.Count > 1)
            {
                MessageBox.Show("Please Select Only One Student at a time");
                return;
            }
            if (Attendance_box.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item in the ComboBox before proceeding.", "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

                attendance = new ClassAttendance();
                ClassAttandanceDL.AddIntoList(attendance);
             if(checked_students.Count ==1)
            {
            
                Student student=StudentDL.GetCheckedStudent();
                studentid=DataBase.GetStudentId(student.RegistrationNumber);
                AttendanceStatus = DataBase.GetStatusId(Attendance_box.SelectedItem.ToString());

            }
            attendanceid = DataBase.AddClassAttendanceAndGetId(ClassAttandanceDL.GetFirstObj());
            if (attendanceid != -1 && studentid != -1 && AttendanceStatus != -1)
            {
                StudentAttendance studentAttendance = new StudentAttendance(studentid, attendanceid, AttendanceStatus);
               bool isadd= StudentAttendanceDL.AddintoList(studentAttendance);
                if (!isadd)
                {
                    MessageBox.Show("Attendance is already marked for that student. Change attendance status if you want to edit it.", "Duplicate Attendance", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else

                {
                    MessageBox.Show("Attendance Added");
                }
            
            }





        }
    }
}
