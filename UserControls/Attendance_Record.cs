using MidProjectEven.Classes.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidProjectEven.UserControls
{
    public partial class Attendance_Record : UserControl
    {
        public Attendance_Record()
        {
            InitializeComponent();
            
        }

 
      private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        void FillCheckbox()
        {
            List<string> list = DataBase.GetAllDateAndTimes();
            {
                foreach (var item in list)
                {
                    DateTime date = DateTime.Parse(item); 
                    string formattedDate = date.ToString("yyyy-MM-dd HH:mm:ss"); 
                    AllTime_box.Items.Add(formattedDate);
                }
                AllTime_box.SelectedIndex = 0;
            }
        }

        private void Attendance_Record_Load(object sender, EventArgs e)
        {
            FillCheckbox();
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            if(AllTime_box.SelectedIndex ==-1)
            {
               MessageBox.Show("Please First Select A Date and Time From box");
            }
            else
            {

                GridAttendance.DataSource = null;
   
                string selectedDate = AllTime_box.SelectedItem.ToString();
  

                int GetSelectDateId = DataBase.GetSelectedTimeIdFromClassAttendance(selectedDate);
                List<StudentAttendanceWithDetails> newlist=DataBase.GetAttendanceDetails(GetSelectDateId);
                GridAttendance.Columns.Clear();
                GridAttendance.Columns.Add("FirstName", "First Name");
                GridAttendance.Columns.Add("LastName", "Last Name");
                GridAttendance.Columns.Add("Email", "Email");
                GridAttendance.Columns.Add("RegistrationNumber", "Registration Number");
                GridAttendance.Columns.Add("Contact", "Contact");
                GridAttendance.Columns.Add("AttendanceStatus", "Attendance Status");


                foreach (var detail in newlist)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(GridAttendance);

                    row.Cells[0].Value = detail.Student.FirstName;
                    row.Cells[1].Value = detail.Student.LastName;
                    row.Cells[2].Value = detail.Student.Email;
                    row.Cells[3].Value = detail.Student.RegistrationNumber;
                    row.Cells[4].Value = detail.Student.Contact;
                    row.Cells[5].Value = detail.Attendance.AttendanceStatusId;
                    DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
                    cellStyle.BackColor = Color.LightBlue; // Set the background color
                    cellStyle.ForeColor = Color.Black; // Set the text color
                    cellStyle.Font = new Font("Arial", 10, FontStyle.Bold); // Set the font size and style

                    // Apply the style to all cells in the row
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.ApplyStyle(cellStyle);
                    }
                    GridAttendance.Rows.Add(row);
                }
                GridAttendance.Refresh();
                foreach (DataGridViewRow row in GridAttendance.Rows)
                {
                    row.Height = 30; // Set the desired height
                }




            }
        }
        void databind()
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
