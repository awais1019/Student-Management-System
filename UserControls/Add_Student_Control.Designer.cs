namespace MidProjectEven.UserControls
{
    partial class Add_Student_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Student_Control));
            this.status_combo_box = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.back_btn = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contact_labe = new System.Windows.Forms.Label();
            this.email_labe = new System.Windows.Forms.Label();
            this.reg_label = new System.Windows.Forms.Label();
            this.last_name_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.Add_btn = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Shapes5 = new Guna.UI2.WinForms.Guna2Shapes();
            this.contact_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Shapes4 = new Guna.UI2.WinForms.Guna2Shapes();
            this.reg_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Shapes3 = new Guna.UI2.WinForms.Guna2Shapes();
            this.email_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Shapes2 = new Guna.UI2.WinForms.Guna2Shapes();
            this.lastnametxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // status_combo_box
            // 
            this.status_combo_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.status_combo_box.FormattingEnabled = true;
            this.status_combo_box.Location = new System.Drawing.Point(355, 405);
            this.status_combo_box.Name = "status_combo_box";
            this.status_combo_box.Size = new System.Drawing.Size(283, 28);
            this.status_combo_box.Sorted = true;
            this.status_combo_box.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.back_btn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 602);
            this.panel1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Addition";
            // 
            // back_btn
            // 
            this.back_btn.BorderRadius = 5;
            this.back_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.back_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.back_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.back_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.back_btn.FillColor = System.Drawing.Color.White;
            this.back_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.back_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.back_btn.Image = ((System.Drawing.Image)(resources.GetObject("back_btn.Image")));
            this.back_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.back_btn.ImageSize = new System.Drawing.Size(15, 15);
            this.back_btn.Location = new System.Drawing.Point(3, 12);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(102, 41);
            this.back_btn.TabIndex = 31;
            this.back_btn.Text = "Back";
            this.back_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            this.back_btn.Leave += new System.EventHandler(this.back_btn_Leave);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.contact_labe);
            this.panel2.Controls.Add(this.email_labe);
            this.panel2.Controls.Add(this.reg_label);
            this.panel2.Controls.Add(this.last_name_label);
            this.panel2.Controls.Add(this.name_label);
            this.panel2.Controls.Add(this.Add_btn);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.guna2Shapes5);
            this.panel2.Controls.Add(this.contact_txt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.guna2Shapes4);
            this.panel2.Controls.Add(this.reg_txtbox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.guna2Shapes3);
            this.panel2.Controls.Add(this.email_txtbox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.guna2Shapes2);
            this.panel2.Controls.Add(this.lastnametxt);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.status_combo_box);
            this.panel2.Controls.Add(this.guna2Shapes1);
            this.panel2.Controls.Add(this.txtFirstName);
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 533);
            this.panel2.TabIndex = 17;
            // 
            // contact_labe
            // 
            this.contact_labe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.contact_labe.AutoSize = true;
            this.contact_labe.Location = new System.Drawing.Point(450, 356);
            this.contact_labe.Name = "contact_labe";
            this.contact_labe.Size = new System.Drawing.Size(109, 20);
            this.contact_labe.TabIndex = 35;
            this.contact_labe.Text = "Follow Format";
            this.contact_labe.Visible = false;
            // 
            // email_labe
            // 
            this.email_labe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.email_labe.AutoSize = true;
            this.email_labe.Location = new System.Drawing.Point(450, 288);
            this.email_labe.Name = "email_labe";
            this.email_labe.Size = new System.Drawing.Size(109, 20);
            this.email_labe.TabIndex = 34;
            this.email_labe.Text = "Follow Format";
            this.email_labe.Visible = false;
            // 
            // reg_label
            // 
            this.reg_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.reg_label.AutoSize = true;
            this.reg_label.Location = new System.Drawing.Point(437, 222);
            this.reg_label.Name = "reg_label";
            this.reg_label.Size = new System.Drawing.Size(109, 20);
            this.reg_label.TabIndex = 33;
            this.reg_label.Text = "Follow Format";
            this.reg_label.Visible = false;
            // 
            // last_name_label
            // 
            this.last_name_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.last_name_label.AutoSize = true;
            this.last_name_label.Location = new System.Drawing.Point(387, 152);
            this.last_name_label.Name = "last_name_label";
            this.last_name_label.Size = new System.Drawing.Size(233, 20);
            this.last_name_label.TabIndex = 32;
            this.last_name_label.Text = "Length should be more 2 letters";
            this.last_name_label.Visible = false;
            // 
            // name_label
            // 
            this.name_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(387, 69);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(233, 20);
            this.name_label.TabIndex = 31;
            this.name_label.Text = "Length should be more 2 letters";
            this.name_label.Visible = false;
            // 
            // Add_btn
            // 
            this.Add_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.Add_btn.BorderRadius = 5;
            this.Add_btn.BorderThickness = 1;
            this.Add_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Add_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Add_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Add_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Add_btn.FillColor = System.Drawing.Color.White;
            this.Add_btn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Add_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.Add_btn.Location = new System.Drawing.Point(408, 474);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(180, 45);
            this.Add_btn.TabIndex = 30;
            this.Add_btn.Text = "Add";
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label6.Location = new System.Drawing.Point(154, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 28);
            this.label6.TabIndex = 29;
            this.label6.Text = "Status";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label5.Location = new System.Drawing.Point(137, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 28);
            this.label5.TabIndex = 26;
            this.label5.Text = "Contact";
            // 
            // guna2Shapes5
            // 
            this.guna2Shapes5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Shapes5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Shapes5.LineThickness = 2;
            this.guna2Shapes5.Location = new System.Drawing.Point(317, 340);
            this.guna2Shapes5.Name = "guna2Shapes5";
            this.guna2Shapes5.PolygonSkip = 1;
            this.guna2Shapes5.Rotate = 0F;
            this.guna2Shapes5.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes5.Size = new System.Drawing.Size(351, 13);
            this.guna2Shapes5.TabIndex = 28;
            this.guna2Shapes5.Text = "guna2Shapes5";
            this.guna2Shapes5.Zoom = 80;
            // 
            // contact_txt
            // 
            this.contact_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.contact_txt.BorderColor = System.Drawing.Color.White;
            this.contact_txt.BorderThickness = 0;
            this.contact_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contact_txt.DefaultText = "";
            this.contact_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.contact_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.contact_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contact_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contact_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contact_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contact_txt.ForeColor = System.Drawing.Color.Black;
            this.contact_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contact_txt.Location = new System.Drawing.Point(337, 313);
            this.contact_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.contact_txt.Name = "contact_txt";
            this.contact_txt.PasswordChar = '\0';
            this.contact_txt.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.contact_txt.PlaceholderText = "03154193750";
            this.contact_txt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.contact_txt.SelectedText = "";
            this.contact_txt.Size = new System.Drawing.Size(307, 29);
            this.contact_txt.TabIndex = 27;
            this.contact_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.contact_txt.TextChanged += new System.EventHandler(this.contact_txt_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label4.Location = new System.Drawing.Point(58, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 28);
            this.label4.TabIndex = 23;
            this.label4.Text = "Registration Number";
            // 
            // guna2Shapes4
            // 
            this.guna2Shapes4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Shapes4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Shapes4.LineThickness = 2;
            this.guna2Shapes4.Location = new System.Drawing.Point(323, 206);
            this.guna2Shapes4.Name = "guna2Shapes4";
            this.guna2Shapes4.PolygonSkip = 1;
            this.guna2Shapes4.Rotate = 0F;
            this.guna2Shapes4.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes4.Size = new System.Drawing.Size(351, 13);
            this.guna2Shapes4.TabIndex = 25;
            this.guna2Shapes4.Text = "guna2Shapes4";
            this.guna2Shapes4.Zoom = 80;
            // 
            // reg_txtbox
            // 
            this.reg_txtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.reg_txtbox.BorderColor = System.Drawing.Color.White;
            this.reg_txtbox.BorderThickness = 0;
            this.reg_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.reg_txtbox.DefaultText = "";
            this.reg_txtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.reg_txtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.reg_txtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.reg_txtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.reg_txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.reg_txtbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.reg_txtbox.ForeColor = System.Drawing.Color.Black;
            this.reg_txtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.reg_txtbox.Location = new System.Drawing.Point(343, 179);
            this.reg_txtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reg_txtbox.Name = "reg_txtbox";
            this.reg_txtbox.PasswordChar = '\0';
            this.reg_txtbox.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.reg_txtbox.PlaceholderText = "2020-CS-01";
            this.reg_txtbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.reg_txtbox.SelectedText = "";
            this.reg_txtbox.Size = new System.Drawing.Size(307, 29);
            this.reg_txtbox.TabIndex = 24;
            this.reg_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.reg_txtbox.TextChanged += new System.EventHandler(this.reg_txtbox_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label3.Location = new System.Drawing.Point(145, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "Email";
            // 
            // guna2Shapes3
            // 
            this.guna2Shapes3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Shapes3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Shapes3.LineThickness = 2;
            this.guna2Shapes3.Location = new System.Drawing.Point(317, 276);
            this.guna2Shapes3.Name = "guna2Shapes3";
            this.guna2Shapes3.PolygonSkip = 1;
            this.guna2Shapes3.Rotate = 0F;
            this.guna2Shapes3.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes3.Size = new System.Drawing.Size(351, 13);
            this.guna2Shapes3.TabIndex = 22;
            this.guna2Shapes3.Text = "guna2Shapes3";
            this.guna2Shapes3.Zoom = 80;
            // 
            // email_txtbox
            // 
            this.email_txtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.email_txtbox.BorderColor = System.Drawing.Color.White;
            this.email_txtbox.BorderThickness = 0;
            this.email_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email_txtbox.DefaultText = "";
            this.email_txtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.email_txtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.email_txtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email_txtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email_txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email_txtbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.email_txtbox.ForeColor = System.Drawing.Color.Black;
            this.email_txtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email_txtbox.Location = new System.Drawing.Point(337, 249);
            this.email_txtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.email_txtbox.Name = "email_txtbox";
            this.email_txtbox.PasswordChar = '\0';
            this.email_txtbox.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.email_txtbox.PlaceholderText = "example@gmail.com";
            this.email_txtbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.email_txtbox.SelectedText = "";
            this.email_txtbox.Size = new System.Drawing.Size(307, 29);
            this.email_txtbox.TabIndex = 21;
            this.email_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.email_txtbox.TextChanged += new System.EventHandler(this.email_txtbox_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label2.Location = new System.Drawing.Point(113, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "Last Name";
            // 
            // guna2Shapes2
            // 
            this.guna2Shapes2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Shapes2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Shapes2.LineThickness = 2;
            this.guna2Shapes2.Location = new System.Drawing.Point(317, 136);
            this.guna2Shapes2.Name = "guna2Shapes2";
            this.guna2Shapes2.PolygonSkip = 1;
            this.guna2Shapes2.Rotate = 0F;
            this.guna2Shapes2.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes2.Size = new System.Drawing.Size(351, 13);
            this.guna2Shapes2.TabIndex = 19;
            this.guna2Shapes2.Text = "guna2Shapes2";
            this.guna2Shapes2.Zoom = 80;
            // 
            // lastnametxt
            // 
            this.lastnametxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lastnametxt.BorderColor = System.Drawing.Color.White;
            this.lastnametxt.BorderThickness = 0;
            this.lastnametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastnametxt.DefaultText = "";
            this.lastnametxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lastnametxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lastnametxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastnametxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastnametxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastnametxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lastnametxt.ForeColor = System.Drawing.Color.Black;
            this.lastnametxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastnametxt.Location = new System.Drawing.Point(337, 109);
            this.lastnametxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lastnametxt.Name = "lastnametxt";
            this.lastnametxt.PasswordChar = '\0';
            this.lastnametxt.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.lastnametxt.PlaceholderText = "Ashraf";
            this.lastnametxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lastnametxt.SelectedText = "";
            this.lastnametxt.Size = new System.Drawing.Size(307, 29);
            this.lastnametxt.TabIndex = 18;
            this.lastnametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lastnametxt.TextChanged += new System.EventHandler(this.lastnametxt_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label1.Location = new System.Drawing.Point(114, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Shapes1.LineThickness = 2;
            this.guna2Shapes1.Location = new System.Drawing.Point(323, 53);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes1.Size = new System.Drawing.Size(351, 13);
            this.guna2Shapes1.TabIndex = 16;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.Zoom = 80;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.BorderColor = System.Drawing.Color.White;
            this.txtFirstName.BorderThickness = 0;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.DefaultText = "";
            this.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFirstName.ForeColor = System.Drawing.Color.Black;
            this.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Location = new System.Drawing.Point(343, 27);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtFirstName.PlaceholderText = "Awais";
            this.txtFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(307, 29);
            this.txtFirstName.TabIndex = 15;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // Add_Student_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Add_Student_Control";
            this.Size = new System.Drawing.Size(834, 602);
            this.Load += new System.EventHandler(this.Add_Student_Control_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox status_combo_box;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes2;
        private Guna.UI2.WinForms.Guna2TextBox lastnametxt;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes5;
        private Guna.UI2.WinForms.Guna2TextBox contact_txt;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes4;
        private Guna.UI2.WinForms.Guna2TextBox reg_txtbox;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes3;
        private Guna.UI2.WinForms.Guna2TextBox email_txtbox;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button Add_btn;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button back_btn;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label last_name_label;
        private System.Windows.Forms.Label contact_labe;
        private System.Windows.Forms.Label email_labe;
        private System.Windows.Forms.Label reg_label;
    }
}
