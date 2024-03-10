using MidProjectEven.Classes.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidProjectEven.UserControls
{
    public partial class AssessmentComponents : UserControl
    {
        string name;
        int marks;
        public AssessmentComponents()
        {
            InitializeComponent();
            FillRubricsAndAssesments();
            FillData();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if(validatedata())
            {
                DateTime dateTime = DateTime.Now;
                int assessmentid=DataBase.GetAssessmentId(AllAssessments_box.SelectedItem.ToString());
                int  rubricid=DataBase.GetRubricId(rubric_combo.SelectedItem.ToString());
                if(assessmentid!=-1&&rubricid!=-1)
                {
                  AssessmentComponent assessmentComponent = new AssessmentComponent(name, rubricid, marks, dateTime, dateTime, assessmentid);
                  if(DataBase.AddAssessmentComponent(assessmentComponent))
                    {
                        ClearFields();
                        FillData();
                    }
                }


            }
        }

        bool validatedata()
        {

            if(AllAssessments_box.SelectedIndex == -1)
            {
                MessageBox.Show("Select Any Assements For Which you want to Add Component");
                return false;
            }
            if(rubric_combo.SelectedIndex == -1)
            {
                MessageBox.Show("Select Any Rubric For Which you want to Add Assesment");
                return false;
            }
            if (string.IsNullOrEmpty(name_txt.Text))
            {
                MessageBox.Show("Fill Name Field");
                return false;

            }
            else
            {
                name = name_txt.Text;
            }
            if (int.Parse(total_marks.Text) <= 0 || total_marks.Text.Length <= 0)
            {
                MessageBox.Show("Invalid Total Marks");
                return false;

            }
            else
            {
                marks = int.Parse(total_marks.Text);
            }
        
            return true;
        }

        void FillRubricsAndAssesments()
        {
            rubric_combo.DataSource = DataBase.GetRubricDetails();
            AllAssessments_box.DataSource = DataBase.GetAllAssessmentTitles();

        }

        private void total_marks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if(validatedata())
            {
                DateTime dateTime = DateTime.Now;
                int assessmentid = DataBase.GetAssessmentId(AllAssessments_box.SelectedItem.ToString());
                int rubricid = DataBase.GetRubricId(rubric_combo.SelectedItem.ToString());
                if (assessmentid != -1 && rubricid != -1)
                {
                    AssessmentComponent assessmentComponent = new AssessmentComponent(name, rubricid, marks, dateTime, dateTime, assessmentid);
                   if( DataBase.EditAssessmentComponent(assessmentComponent))
                    {
                        ClearFields();
                        FillData();
                    }
                }
            }
        }
        void ClearFields()
        {
            name_txt.Text = string.Empty;
           total_marks.Text = string.Empty;
        }
        void FillData()
        {
            GridAssessments.DataSource = null;
            GridAssessments.DataSource=DataBase.GetAllAssessmentComponents();
            GridAssessments.Refresh();
        }

        private void GridAssessments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow row = GridAssessments.Rows[index];
                name_txt.Text = row.Cells[0].Value.ToString();
                total_marks.Text = row.Cells[2].Value.ToString();
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message, "Warning");
            }
        }
    }
}
