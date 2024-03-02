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
            for(int i = 0; i < n; i++)
            {

                Student_infromation_card hello = new Student_infromation_card();
                flowLayoutPanel.Controls.Add(hello);
             
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
    }
}
