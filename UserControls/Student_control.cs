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

      
        private void Add_student_btn_Click(object sender, EventArgs e)
        {
            Full_panel.Controls.Clear();
            Add_Student_Control control = new Add_Student_Control();
            Full_panel.Dock = DockStyle.Fill;
           control.Dock= DockStyle.Fill;
            Full_panel.Controls.Add(control);
          
        }
   
        

        private void Searchbox_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
