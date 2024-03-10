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
    public partial class MarkEvalution : UserControl
    {
        public MarkEvalution()
        {
            InitializeComponent();
            FillBoxes();
        }

        private void assessmentbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Mark_btn_Click(object sender, EventArgs e)
        {
           
           if(Validate())
            {
               int getstudentid=DataBase.GetStudentId2(cmb_student.SelectedItem.ToString());
                int getComponetId = DataBase.GetComponentId(assessmentbox.SelectedItem.ToString());
                int getRubricLevelid = DataBase.GetRubricLevelId(rubric_level_box.SelectedItem.ToString());
                DateTime dateTime = DateTime.Now;
                if(getstudentid!=-1&&getComponetId!=-1&&getRubricLevelid!=-1)
                {
                    StudentResult studentResult = new StudentResult(getstudentid, getComponetId, getRubricLevelid, dateTime);
                    DataBase.AddStudentResult(studentResult);
                }
            }
        }

        void FillBoxes()
        {
            cmb_student.DataSource = DataBase.GetStudentNamesByStatus();
            assessmentbox.DataSource = DataBase.GetAllAssessmentComponentNames();
            rubric_level_box.DataSource = DataBase.GetAllRubricDetails();
        }
        bool ValidateFunction()
        {
            if (cmb_student.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a student.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (assessmentbox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an assessment component.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (rubric_level_box.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a rubric level.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

    }
}
