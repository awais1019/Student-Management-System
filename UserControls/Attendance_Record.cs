
using MidProjectEven.Classes.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using iTextSharp.text;


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


            }
        }

        private void Attendance_Record_Load(object sender, EventArgs e)
        {
            FillCheckbox();
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            if (AllTime_box.SelectedIndex == -1)
            {
                MessageBox.Show("Please First Select A Date and Time From box");
            }
            else
            {

                GridAttendance.DataSource = null;

                string selectedDate = AllTime_box.SelectedItem.ToString();
                report_generate_btn.Enabled = true;

                int GetSelectDateId = DataBase.GetSelectedTimeIdFromClassAttendance(selectedDate);
                List<StudentAttendanceWithDetails> newlist = DataBase.GetAttendanceDetails(GetSelectDateId);
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
                    string getattendncestatus = DataBase.GetStatusName(detail.Attendance.AttendanceStatusId);
                    if (getattendncestatus != null)
                    {
                        row.Cells[5].Value = getattendncestatus;

                    }
                    DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
                    cellStyle.BackColor = Color.White; 
                    cellStyle.ForeColor = Color.FromArgb(0, 118, 212);
                    cellStyle.Font = new System.Drawing.Font("Arial", 10, FontStyle.Italic);


                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.ApplyStyle(cellStyle);
                    }
                    GridAttendance.Rows.Add(row);
                }
                GridAttendance.Refresh();
                foreach (DataGridViewRow row in GridAttendance.Rows)
                {
                    row.Height = 30;
                }




            }
        }
        void databind()
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void report_generate_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (.pdf)|.pdf";
            saveFileDialog.Title = "Export to PDF";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                Document document = new Document(PageSize.A4, 10f, 10f, 10f, 10f);

          
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));

                document.Open();
                string specificDate = AllTime_box.SelectedItem.ToString();

                Paragraph dateParagraph = new Paragraph($"Date: {specificDate}");
                document.Add(dateParagraph);

                PdfPTable pdfTable = new PdfPTable(GridAttendance.ColumnCount);
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 100;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                foreach (DataGridViewColumn column in GridAttendance.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    pdfTable.AddCell(cell);
                }

                foreach (DataGridViewRow row in GridAttendance.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {

                        object cellValue = cell.Value;
                        string cellText = cellValue != null ? cellValue.ToString() : "";
                        pdfTable.AddCell(cellText);
                    }
                }

                document.Add(pdfTable);

    

                document.Close();

                MessageBox.Show("PDF file has been created!");
               
            }
        }

   

    }

}

