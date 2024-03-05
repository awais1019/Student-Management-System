namespace MidProjectEven.UserControls
{
    partial class Student_control
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_control));
            this.Full_panel = new System.Windows.Forms.Panel();
            this.status_bar_panel = new System.Windows.Forms.Panel();
            this.count_students_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.status_label = new System.Windows.Forms.Label();
            this.contact_label = new System.Windows.Forms.Label();
            this.first_name_label = new System.Windows.Forms.Label();
            this.last_name_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.reg_number = new System.Windows.Forms.Label();
            this.search_bar_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.Delete_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Add_student_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Searchbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.timer_to_check_selected = new System.Windows.Forms.Timer(this.components);
            this.Attendance_box = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Mark_Attandance = new Guna.UI2.WinForms.Guna2Button();
            this.Full_panel.SuspendLayout();
            this.status_bar_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.search_bar_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Full_panel
            // 
            this.Full_panel.BackColor = System.Drawing.Color.White;
            this.Full_panel.Controls.Add(this.status_bar_panel);
            this.Full_panel.Controls.Add(this.flowLayoutPanel);
            this.Full_panel.Controls.Add(this.panel1);
            this.Full_panel.Controls.Add(this.search_bar_panel);
            this.Full_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Full_panel.Location = new System.Drawing.Point(0, 0);
            this.Full_panel.Name = "Full_panel";
            this.Full_panel.Size = new System.Drawing.Size(834, 602);
            this.Full_panel.TabIndex = 0;
            // 
            // status_bar_panel
            // 
            this.status_bar_panel.BackColor = System.Drawing.Color.White;
            this.status_bar_panel.Controls.Add(this.count_students_label);
            this.status_bar_panel.Controls.Add(this.label7);
            this.status_bar_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.status_bar_panel.Location = new System.Drawing.Point(0, 577);
            this.status_bar_panel.Name = "status_bar_panel";
            this.status_bar_panel.Size = new System.Drawing.Size(834, 25);
            this.status_bar_panel.TabIndex = 12;
            // 
            // count_students_label
            // 
            this.count_students_label.AutoSize = true;
            this.count_students_label.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count_students_label.Location = new System.Drawing.Point(104, 3);
            this.count_students_label.Name = "count_students_label";
            this.count_students_label.Size = new System.Drawing.Size(0, 19);
            this.count_students_label.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total Stuents:";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 109);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(834, 493);
            this.flowLayoutPanel.TabIndex = 2;
            this.flowLayoutPanel.Scroll += new System.Windows.Forms.ScrollEventHandler(this.flowLayoutPanel_Scroll);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 49);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.status_label, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.contact_label, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.first_name_label, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.last_name_label, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.email_label, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.reg_number, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(834, 53);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.status_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.status_label.ForeColor = System.Drawing.Color.White;
            this.status_label.Location = new System.Drawing.Point(699, 0);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(132, 53);
            this.status_label.TabIndex = 5;
            this.status_label.Text = "Status";
            this.status_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contact_label
            // 
            this.contact_label.AutoSize = true;
            this.contact_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contact_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.contact_label.ForeColor = System.Drawing.Color.White;
            this.contact_label.Location = new System.Drawing.Point(563, 0);
            this.contact_label.Name = "contact_label";
            this.contact_label.Size = new System.Drawing.Size(130, 53);
            this.contact_label.TabIndex = 5;
            this.contact_label.Text = "Contact";
            this.contact_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // first_name_label
            // 
            this.first_name_label.AutoSize = true;
            this.first_name_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.first_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.first_name_label.ForeColor = System.Drawing.Color.White;
            this.first_name_label.Location = new System.Drawing.Point(19, 0);
            this.first_name_label.Name = "first_name_label";
            this.first_name_label.Size = new System.Drawing.Size(130, 53);
            this.first_name_label.TabIndex = 4;
            this.first_name_label.Text = "First Name";
            this.first_name_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // last_name_label
            // 
            this.last_name_label.AutoSize = true;
            this.last_name_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.last_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.last_name_label.ForeColor = System.Drawing.Color.White;
            this.last_name_label.Location = new System.Drawing.Point(155, 0);
            this.last_name_label.Name = "last_name_label";
            this.last_name_label.Size = new System.Drawing.Size(130, 53);
            this.last_name_label.TabIndex = 5;
            this.last_name_label.Text = "Last Name";
            this.last_name_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.email_label.ForeColor = System.Drawing.Color.White;
            this.email_label.Location = new System.Drawing.Point(291, 0);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(130, 53);
            this.email_label.TabIndex = 6;
            this.email_label.Text = "Email";
            this.email_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reg_number
            // 
            this.reg_number.AutoSize = true;
            this.reg_number.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reg_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.reg_number.ForeColor = System.Drawing.Color.White;
            this.reg_number.Location = new System.Drawing.Point(427, 0);
            this.reg_number.Name = "reg_number";
            this.reg_number.Size = new System.Drawing.Size(130, 53);
            this.reg_number.TabIndex = 7;
            this.reg_number.Text = "Registration Number";
            this.reg_number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // search_bar_panel
            // 
            this.search_bar_panel.BackColor = System.Drawing.Color.White;
            this.search_bar_panel.Controls.Add(this.Mark_Attandance);
            this.search_bar_panel.Controls.Add(this.Attendance_box);
            this.search_bar_panel.Controls.Add(this.Delete_btn);
            this.search_bar_panel.Controls.Add(this.Add_student_btn);
            this.search_bar_panel.Controls.Add(this.Searchbox);
            this.search_bar_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.search_bar_panel.Location = new System.Drawing.Point(0, 0);
            this.search_bar_panel.Name = "search_bar_panel";
            this.search_bar_panel.Size = new System.Drawing.Size(834, 60);
            this.search_bar_panel.TabIndex = 0;
            // 
            // Delete_btn
            // 
            this.Delete_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Delete_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Delete_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Delete_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Delete_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Delete_btn.FillColor = System.Drawing.Color.White;
            this.Delete_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Delete_btn.ForeColor = System.Drawing.Color.Black;
            this.Delete_btn.Image = ((System.Drawing.Image)(resources.GetObject("Delete_btn.Image")));
            this.Delete_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Delete_btn.Location = new System.Drawing.Point(160, 13);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(158, 37);
            this.Delete_btn.TabIndex = 57;
            this.Delete_btn.Text = "Delete Student";
            this.Delete_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Add_student_btn
            // 
            this.Add_student_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Add_student_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Add_student_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Add_student_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Add_student_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Add_student_btn.FillColor = System.Drawing.Color.White;
            this.Add_student_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Add_student_btn.ForeColor = System.Drawing.Color.Black;
            this.Add_student_btn.Image = ((System.Drawing.Image)(resources.GetObject("Add_student_btn.Image")));
            this.Add_student_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Add_student_btn.Location = new System.Drawing.Point(3, 13);
            this.Add_student_btn.Name = "Add_student_btn";
            this.Add_student_btn.Size = new System.Drawing.Size(158, 37);
            this.Add_student_btn.TabIndex = 56;
            this.Add_student_btn.Text = "Add Student";
            this.Add_student_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Add_student_btn.Click += new System.EventHandler(this.Add_student_btn_Click);
            // 
            // Searchbox
            // 
            this.Searchbox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Searchbox.BorderThickness = 2;
            this.Searchbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Searchbox.DefaultText = "";
            this.Searchbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Searchbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Searchbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Searchbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Searchbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Searchbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Searchbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Searchbox.IconLeft = ((System.Drawing.Image)(resources.GetObject("Searchbox.IconLeft")));
            this.Searchbox.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.Searchbox.IconLeftSize = new System.Drawing.Size(18, 18);
            this.Searchbox.Location = new System.Drawing.Point(642, 9);
            this.Searchbox.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.Searchbox.Name = "Searchbox";
            this.Searchbox.PasswordChar = '\0';
            this.Searchbox.PlaceholderText = "Search";
            this.Searchbox.SelectedText = "";
            this.Searchbox.Size = new System.Drawing.Size(189, 41);
            this.Searchbox.TabIndex = 55;
            this.Searchbox.TextChanged += new System.EventHandler(this.Searchbox_TextChanged);
            this.Searchbox.Leave += new System.EventHandler(this.Searchbox_Leave);
            // 
            // timer_to_check_selected
            // 
            this.timer_to_check_selected.Enabled = true;
            this.timer_to_check_selected.Tick += new System.EventHandler(this.timer_to_check_selected_Tick);
            // 
            // Attendance_box
            // 
            this.Attendance_box.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Attendance_box.BackColor = System.Drawing.Color.Transparent;
            this.Attendance_box.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Attendance_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Attendance_box.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Attendance_box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Attendance_box.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Attendance_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Attendance_box.ItemHeight = 30;
            this.Attendance_box.Location = new System.Drawing.Point(512, 14);
            this.Attendance_box.Name = "Attendance_box";
            this.Attendance_box.Size = new System.Drawing.Size(120, 36);
            this.Attendance_box.TabIndex = 0;
            this.Attendance_box.SelectedIndexChanged += new System.EventHandler(this.Attendance_box_SelectedIndexChanged);
            // 
            // Mark_Attandance
            // 
            this.Mark_Attandance.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Mark_Attandance.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Mark_Attandance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Mark_Attandance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Mark_Attandance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Mark_Attandance.FillColor = System.Drawing.Color.White;
            this.Mark_Attandance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Mark_Attandance.ForeColor = System.Drawing.Color.Black;
            this.Mark_Attandance.Image = ((System.Drawing.Image)(resources.GetObject("Mark_Attandance.Image")));
            this.Mark_Attandance.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Mark_Attandance.Location = new System.Drawing.Point(324, 14);
            this.Mark_Attandance.Name = "Mark_Attandance";
            this.Mark_Attandance.Size = new System.Drawing.Size(182, 36);
            this.Mark_Attandance.TabIndex = 58;
            this.Mark_Attandance.Text = "Mark Attendance";
            this.Mark_Attandance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Mark_Attandance.Click += new System.EventHandler(this.Mark_Attandance_Click);
            // 
            // Student_control
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Full_panel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(0, 6, 6, 6);
            this.Name = "Student_control";
            this.Size = new System.Drawing.Size(834, 602);
            this.Load += new System.EventHandler(this.Student_control_Load);
            this.Full_panel.ResumeLayout(false);
            this.status_bar_panel.ResumeLayout(false);
            this.status_bar_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.search_bar_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel search_bar_panel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel status_bar_panel;
        private System.Windows.Forms.Label count_students_label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.Label contact_label;
        private System.Windows.Forms.Label first_name_label;
        private System.Windows.Forms.Label last_name_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label reg_number;
        private Guna.UI2.WinForms.Guna2TextBox Searchbox;
        private Guna.UI2.WinForms.Guna2Button Add_student_btn;
        public System.Windows.Forms.Panel Full_panel;
        private System.Windows.Forms.Timer timer_to_check_selected;
        private Guna.UI2.WinForms.Guna2Button Delete_btn;
        private Guna.UI2.WinForms.Guna2ComboBox Attendance_box;
        private Guna.UI2.WinForms.Guna2Button Mark_Attandance;
    }
}
