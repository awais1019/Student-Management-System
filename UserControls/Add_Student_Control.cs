using MidProjectEven.Classes;
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
        string first_name, last_name, email, registration_number, contact;
        int selectindex;


        public Add_Student_Control()
        {
            InitializeComponent();
       
        }

        private void Add_Student_Control_Load(object sender, EventArgs e)
        {
            FillStatusComboBox();
        }

        private void FillStatusComboBox()
        {
            status_combo_box.Items.Clear();


            using (SqlConnection connection = new SqlConnection(Configuration.SqlConnectionString))
            {
                connection.Open();

                try
                {

                    string query = "SELECT Name FROM Lookup WHERE Category = 'STUDENT_STATUS'";
                    SqlCommand command = new SqlCommand(query, connection);


                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string itemName = reader["Name"].ToString();
                        status_combo_box.Items.Add(itemName);
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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

            if (string.IsNullOrEmpty(first_name) || string.IsNullOrEmpty(last_name) || string.IsNullOrEmpty(email)
         || string.IsNullOrEmpty(registration_number) || string.IsNullOrEmpty(contact))
            {
                MessageBox.Show("Fill All Data with Correct Format");
                return;
            }

            if (status_combo_box.SelectedIndex != -1)
            {
                string selectedStatus = status_combo_box.SelectedItem.ToString();
                selectindex = status_combo_box.SelectedIndex;

                int id = GetStatusId(selectedStatus);
                if(id!=-1)
                {
                    Student student = new Student(first_name, last_name, registration_number, email, contact, id);
                    bool inserted = InsertStudent(student);
                    if (inserted)
                    {
                        MessageBox.Show("Student Added Successfully");
                        clearfieldes();
                    }
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

        }

        private void back_btn_Click(object sender, EventArgs e)
        {


          /**/
              
        }

        private void back_btn_Leave(object sender, EventArgs e)
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

      public  bool InsertStudent(Student student)
        {
            using (SqlConnection connection = new SqlConnection(Configuration.SqlConnectionString))
            {

                connection.Open();
                try
                {

                    string query = "INSERT INTO Student (FirstName, LastName, Email, RegistrationNumber, Contact, Status) " +
                              "VALUES (@FirstName, @LastName, @Email, @RegistrationNumber, @Contact, @Status)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@FirstName", student.FirstName);
                    command.Parameters.AddWithValue("@LastName", student.LastName);
                    command.Parameters.AddWithValue("@Email", student.Email);
                    command.Parameters.AddWithValue("@RegistrationNumber", student.RegistrationNumber);
                    command.Parameters.AddWithValue("@Contact", contact);
                    command.Parameters.AddWithValue("@Status", student.Status);
                    command.ExecuteNonQuery();

                    return true;

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                return false;
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
        private int GetStatusId(string statusName)
        {
            using (SqlConnection connection = new SqlConnection(Configuration.SqlConnectionString))
            {
                try
                {
                    string query = "SELECT LookupId FROM Lookup WHERE Name = @name AND Category = 'STUDENT_STATUS'";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", statusName);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result == null)
                    {
                   
                        return -1;
                    }

                    return Convert.ToInt32(result);
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show(ex.Message);
                    return -1;
                }
            }
        }







    }
}
