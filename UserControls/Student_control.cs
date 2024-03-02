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
    public partial class Student_control : UserControl
    {
        //list
        public Student_control()
        {
            InitializeComponent();
            display();
        }
        void loadData()
        {

        }
        int n = 100;
        void display()
        {
            flowLayoutPanel.Controls.Clear();
            for (int i = 0; i < n; i++)
            {

                Student_infromation_card hello = new Student_infromation_card();
              
                flowLayoutPanel.Controls.Add(hello);
                flowLayoutPanel.ResumeLayout();


            }
            count_students_label.Text = n.ToString();
         
        }

        private void label_email_Click(object sender, EventArgs e)
        {

        }

        private void Card_table_layout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void count_students_label_Click(object sender, EventArgs e)
        {

        }

        private void Add_student_btn_Click(object sender, EventArgs e)
        {
            Full_panel.Controls.Clear();
            Full_panel.Controls.Add(new Add_Student_Control());
        }

        private void Searchbox_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
