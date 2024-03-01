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
            Home_UserControl home_UserControl = new Home_UserControl();
            addusercontrol(home_UserControl);

        }


        private void btn_home_Click(object sender, EventArgs e)
        {
            Home_UserControl home_UserControl = new Home_UserControl();
            addusercontrol(home_UserControl);
        }

        private void Students_btn_Click(object sender, EventArgs e)
        {
      
            Student_control student_Control = new Student_control();
            addusercontrol(student_Control);

        }
        private void addusercontrol(UserControl control)
        {
            control.Dock = DockStyle.Fill;
            main_panel.Controls.Add(control);
            control.BringToFront();
        }

        private void Assesment_btn_Click(object sender, EventArgs e)
        {
         
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Close Application", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            { 
                Application.Exit();
            }
         
        }
        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            sidepicture.Location = new Point(b.Location.X + 118, b.Location.Y - 30);
            sidepicture.SendToBack();
        }
        private void btn_home_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }
    }
  
}
