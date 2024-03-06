using MidProjectEven.Classes;
using MidProjectEven.Classes.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidProjectEven.UserControls
{
    public partial class Add_Student_Control : UserControl
    {
        private bool controlRemoved = false;
        string first_name, last_name, email, registration_number, contact;
        int selectindex;
        Student student;


        public Add_Student_Control(Student student)
        {
            InitializeComponent();
            this.student = student;

        }

        private void Add_Student_Control_Load(object sender, EventArgs e)
        {
            FillStatusComboBox();
            AddDataToTextBoxes();

        }

        void FillStatusComboBox()
        {
            status_combo_box.Items.Clear();
            List<string> list = DataBase.FillStudentStatusComboBox();
            foreach (var item in  list)
            {
                status_combo_box.Items.Add(item);
            }
            status_combo_box.SelectedItem = 0;
        }

        

 
        public void  AddDataToTextBoxes()
        {
            if(student != null)
            {
                txtFirstName.Text = student.FirstName;
                lastnametxt.Text = student.LastName;
                email_txtbox.Text = student.Email;
                reg_txtbox.Text = student.RegistrationNumber;
                contact_txt.Text = student.Contact;
                Add_btn.Text = "Edit";
            }
        }



        private void lastnametxt_TextChanged(object sender, EventArgs e)
        {
            bool validate = Validations.ValidName(lastnametxt.Text);
            if (!validate && lastnametxt.Text.Length >= 1)
            {
                last_name_label.Visible = true;
                last_name_label.ForeColor = Color.Red;

            }
            else
            {
                last_name = lastnametxt.Text.ToString();
                last_name_label.Visible = false;
            }
        }

        private void reg_txtbox_TextChanged(object sender, EventArgs e)
        {
            bool validate = Validations.ValidRegistrationNumber(reg_txtbox.Text);
            if (!validate && reg_txtbox.Text.Length >= 1)
            {
                reg_label.ForeColor = Color.Red;
                reg_label.Visible = true;

            }
            else
            {
                registration_number = reg_txtbox.Text.ToString();
                reg_label.Visible = false;
            }
        }

        private void email_txtbox_TextChanged(object sender, EventArgs e)
        {
            bool validate = Validations.ValidEmail(email_txtbox.Text);
            if (!validate && email_txtbox.Text.Length >= 1)
            {
                email_labe.Visible = true;
                email_labe.ForeColor = Color.Red;

            }
            else
            {
                email = email_txtbox.Text.ToString();
                email_labe.Visible = false;
            }
        }

        private void contact_txt_TextChanged(object sender, EventArgs e)
        {

            if (!Validations.ValidContact(contact_txt.Text) && contact_txt.Text.Length >= 1)
            {
                contact_labe.Visible = true;
                contact_labe.ForeColor = Color.Red;
            }
            else
            {

                contact = contact_txt.Text.ToString();
                contact_labe.Visible = false;
            }
        }



        private void Add_btn_Click(object sender, EventArgs e)
        {
            if(Add_btn.Text=="Edit")
            {
                string lastreg = student.RegistrationNumber;
                Student student1 = CheckFields();
                if (student1 != null)
                {
                    bool updated = DataBase.EditStudent(lastreg, student1);
                    if (updated)
                    {
                        MessageBox.Show("Student information updated successfully.");
                        clearfieldes();
                    }
                    else
                    {
                        MessageBox.Show("You can not Edit this record");
                    }
                }
            }
            else
            {
               Student student1= CheckFields();
                bool inserted = DataBase.InsertStudent(student1);
                if (inserted)
                {
                    MessageBox.Show("Student Added Successfully");
                    clearfieldes();
                }
                else
                {
                    MessageBox.Show("Student with the same Registration Number already exists.");
                }
            }

         

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
    
          
      
        }


        private void back_btn_Leave(object sender, EventArgs e)
        {
         
        }

        private void back_btn_ControlRemoved(object sender, ControlEventArgs e)
        {
      
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            bool validate=Validations.ValidName(txtFirstName.Text);
            if(!validate&&txtFirstName.Text.Length>=1)
            {
                name_label.Visible = true;
                name_label.ForeColor = Color.Red;
           
            }
            else
            {
                first_name = txtFirstName.Text;
                name_label.Visible = false;
            }
        }


          public  void clearfieldes()
        {
            txtFirstName.Text = "";
            lastnametxt.Text= "";
            email_txtbox.Text = "";
            contact_txt.Text = ""; 
            reg_txtbox.Text = "";
            status_combo_box.SelectedIndex = -1;

        }
     
        public Student CheckFields()
        {
            if (string.IsNullOrEmpty(first_name) || string.IsNullOrEmpty(last_name) || string.IsNullOrEmpty(email)
      || string.IsNullOrEmpty(registration_number) || string.IsNullOrEmpty(contact))
            {
                MessageBox.Show("Fill All Data with Correct Format");
        
            }

         else if (status_combo_box.SelectedIndex != -1)
            {
                string selectedStatus = status_combo_box.SelectedItem.ToString();
                selectindex = status_combo_box.SelectedIndex;

                int id = DataBase.GetStatusIdOne(selectedStatus);
                if (id != -1)
                {
                    Student student = new Student(first_name, last_name, registration_number, email, contact, id);
                    return student;
                
                }
                else
                {
                    /**/
                }

            }
            else
            {
                MessageBox.Show("Please Select a Status from the combo box");
            }
            return null;
        }









    }
}
