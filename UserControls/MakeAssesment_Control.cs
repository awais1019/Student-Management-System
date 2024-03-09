using MidProjectEven.Classes.BL;
using MidProjectEven.Classes.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MidProjectEven.UserControls
{


    public partial class MakeAssesment_Control : UserControl
    {
        string title;
        int totalmarks;
        int toatleweightage;
        public MakeAssesment_Control()
        {
            InitializeComponent();
            FillDataGrid();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if(validatedata())
            {
                DateTime date = DateTime.Now;
                Assessment assessment=new Assessment(title,date,totalmarks,toatleweightage);
                bool save = DataBase.AddAssessment(assessment);
                if(save)
                {
                    FillDataGrid();
                    clearfields();
                }
            
            }
        }


        bool validatedata()
        {
            if(string.IsNullOrEmpty(title_txt.Text))
            {
                MessageBox.Show("Fill Title Field");
                return false;

            }
            else
            {
                title = title_txt.Text;
            }
            if(int.Parse(total_marks_txt.Text) <=0||total_marks_txt.Text.Length<=0 )
            { 
                MessageBox.Show("Invalid Total Marks");
                return false;

            }
            else
            {
                totalmarks = int.Parse(total_marks_txt.Text);
            }
            if (int.Parse(total_waithage_txt.Text) <= 0||total_waithage_txt.Text.Length<=0)
            {
                MessageBox.Show("Invalid Weightage");

            }
            else
            {
                toatleweightage = int.Parse(total_waithage_txt.Text);
            }
            return true;
        }
        void clearfields()
        {
            title_txt.Text= string.Empty;
            total_marks_txt.Text = string.Empty;
            total_waithage_txt.Text=string.Empty;

        }
         void FillDataGrid()
        {
            GridAssessments.DataSource = null;
            GridAssessments.DataSource =DataBase.GetAllAssessments();
            GridAssessments.Refresh(); 
        }

        private void GridAssessments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridAssessments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow row = GridAssessments.Rows[index];
                title_txt.Text = row.Cells[0].Value.ToString();
                total_marks_txt.Text = row.Cells[2].Value.ToString();
                total_waithage_txt.Text = row.Cells[3].Value.ToString();
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message, "Warning");
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if(validatedata())
            {
                DateTime date = DateTime.Now;
                Assessment assessment = new Assessment(title, date, totalmarks, toatleweightage);
                bool save = DataBase.EditAssessment(assessment);
                if (save)
                {
                    FillDataGrid();
                    clearfields();
                }
            }
        }
    }
}
