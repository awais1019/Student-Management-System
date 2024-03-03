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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_control));
            this.Full_panel = new System.Windows.Forms.Panel();
            this.status_bar_panel = new System.Windows.Forms.Panel();
            this.count_students_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.search_bar_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.Add_student_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Searchbox = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.tableLayoutPanel1.Controls.Add(this.label6, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(834, 53);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(699, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 53);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(563, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 53);
            this.label5.TabIndex = 5;
            this.label5.Text = "Contact";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 53);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(155, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 53);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(291, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 53);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(427, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 53);
            this.label4.TabIndex = 7;
            this.label4.Text = "Registration Number";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // search_bar_panel
            // 
            this.search_bar_panel.BackColor = System.Drawing.Color.White;
            this.search_bar_panel.Controls.Add(this.Add_student_btn);
            this.search_bar_panel.Controls.Add(this.Searchbox);
            this.search_bar_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.search_bar_panel.Location = new System.Drawing.Point(0, 0);
            this.search_bar_panel.Name = "search_bar_panel";
            this.search_bar_panel.Size = new System.Drawing.Size(834, 60);
            this.search_bar_panel.TabIndex = 0;
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
            this.Searchbox.Location = new System.Drawing.Point(614, 9);
            this.Searchbox.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.Searchbox.Name = "Searchbox";
            this.Searchbox.PasswordChar = '\0';
            this.Searchbox.PlaceholderText = "Search";
            this.Searchbox.SelectedText = "";
            this.Searchbox.Size = new System.Drawing.Size(217, 41);
            this.Searchbox.TabIndex = 55;
            this.Searchbox.TextChanged += new System.EventHandler(this.Searchbox_TextChanged);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox Searchbox;
        private Guna.UI2.WinForms.Guna2Button Add_student_btn;
        public System.Windows.Forms.Panel Full_panel;
    }
}
