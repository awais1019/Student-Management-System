namespace MidProjectEven.UserControls
{
    partial class Student_infromation_card
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.status_label = new System.Windows.Forms.Label();
            this.checkbox1 = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.email_label = new System.Windows.Forms.Label();
            this.FirstName_lable = new System.Windows.Forms.Label();
            this.contact_label = new System.Windows.Forms.Label();
            this.Reg_Number_label = new System.Windows.Forms.Label();
            this.LastName_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 53);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.status_label, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkbox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.email_label, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.FirstName_lable, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.contact_label, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.Reg_Number_label, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.LastName_label, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(832, 53);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.status_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.status_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.status_label.Location = new System.Drawing.Point(698, 0);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(131, 53);
            this.status_label.TabIndex = 7;
            this.status_label.Text = "Active";
            this.status_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkbox1
            // 
            this.checkbox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkbox1.CheckedState.BorderRadius = 2;
            this.checkbox1.CheckedState.BorderThickness = 0;
            this.checkbox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkbox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkbox1.Location = new System.Drawing.Point(2, 2);
            this.checkbox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkbox1.Name = "checkbox1";
            this.checkbox1.Padding = new System.Windows.Forms.Padding(3);
            this.checkbox1.Size = new System.Drawing.Size(16, 49);
            this.checkbox1.TabIndex = 3;
            this.checkbox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkbox1.UncheckedState.BorderRadius = 2;
            this.checkbox1.UncheckedState.BorderThickness = 0;
            this.checkbox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkbox1.Click += new System.EventHandler(this.checkbox1_Click);
            this.checkbox1.Leave += new System.EventHandler(this.checkbox1_Leave);
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.email_label.Location = new System.Drawing.Point(293, 0);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(129, 53);
            this.email_label.TabIndex = 2;
            this.email_label.Text = "mhawais431@gmail.com";
            this.email_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstName_lable
            // 
            this.FirstName_lable.AutoSize = true;
            this.FirstName_lable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirstName_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FirstName_lable.Location = new System.Drawing.Point(23, 0);
            this.FirstName_lable.Name = "FirstName_lable";
            this.FirstName_lable.Size = new System.Drawing.Size(129, 53);
            this.FirstName_lable.TabIndex = 0;
            this.FirstName_lable.Text = "Muhammad Awais";
            this.FirstName_lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contact_label
            // 
            this.contact_label.AutoSize = true;
            this.contact_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contact_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contact_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.contact_label.Location = new System.Drawing.Point(563, 0);
            this.contact_label.Name = "contact_label";
            this.contact_label.Size = new System.Drawing.Size(129, 53);
            this.contact_label.TabIndex = 5;
            this.contact_label.Text = "03154193750";
            this.contact_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Reg_Number_label
            // 
            this.Reg_Number_label.AutoSize = true;
            this.Reg_Number_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Reg_Number_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Reg_Number_label.Location = new System.Drawing.Point(428, 0);
            this.Reg_Number_label.Name = "Reg_Number_label";
            this.Reg_Number_label.Size = new System.Drawing.Size(129, 53);
            this.Reg_Number_label.TabIndex = 5;
            this.Reg_Number_label.Text = "2022-CS-186";
            this.Reg_Number_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LastName_label
            // 
            this.LastName_label.AutoSize = true;
            this.LastName_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LastName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LastName_label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LastName_label.Location = new System.Drawing.Point(158, 0);
            this.LastName_label.Name = "LastName_label";
            this.LastName_label.Size = new System.Drawing.Size(129, 53);
            this.LastName_label.TabIndex = 5;
            this.LastName_label.Text = "Ashraf";
            this.LastName_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Student_infromation_card
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.Name = "Student_infromation_card";
            this.Size = new System.Drawing.Size(832, 53);
            this.Load += new System.EventHandler(this.Student_infromation_card_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label status_label;
        private Guna.UI2.WinForms.Guna2CustomCheckBox checkbox1;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label FirstName_lable;
        private System.Windows.Forms.Label contact_label;
        private System.Windows.Forms.Label Reg_Number_label;
        private System.Windows.Forms.Label LastName_label;
    }
}
