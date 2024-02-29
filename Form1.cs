using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MidProjectEven.UserControls;

namespace MidProjectEven
{
    public partial class main_form : Form
    {

      

        public main_form()
        {
            InitializeComponent();

        }
 

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void main_form_Load(object sender, EventArgs e)
        {
      
        }


        private void btn_home_Click(object sender, EventArgs e)
        {

        }

        private void Students_btn_Click(object sender, EventArgs e)
        {
            btn_home.Checked = false;
            Students_btn.Checked = true;
            Student_control student_Control = new Student_control();
            addusercontrol(student_Control);



        }
        private void addusercontrol(UserControl control)
        {
          
            control.Dock= DockStyle.Fill;
            main_panel.Controls.Add(control);
            control.BringToFront();
        }

        private void Assesment_btn_Click(object sender, EventArgs e)
        {
         
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
  
}
