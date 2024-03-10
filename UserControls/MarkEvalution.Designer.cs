namespace MidProjectEven.UserControls
{
    partial class MarkEvalution
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmb_student = new System.Windows.Forms.ComboBox();
            this.assessmentbox = new System.Windows.Forms.ComboBox();
            this.rubric_level_box = new System.Windows.Forms.ComboBox();
            this.Edit_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Mark_btn = new Guna.UI2.WinForms.Guna2Button();
            this.GridAssessments = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridAssessments)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_student
            // 
            this.cmb_student.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_student.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_student.ForeColor = System.Drawing.Color.DimGray;
            this.cmb_student.Items.AddRange(new object[] {
            "Customer",
            "Admin"});
            this.cmb_student.Location = new System.Drawing.Point(15, 36);
            this.cmb_student.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_student.Name = "cmb_student";
            this.cmb_student.Size = new System.Drawing.Size(173, 28);
            this.cmb_student.TabIndex = 2;
            this.cmb_student.Text = "Select Student";
            // 
            // assessmentbox
            // 
            this.assessmentbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.assessmentbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.assessmentbox.ForeColor = System.Drawing.Color.DimGray;
            this.assessmentbox.Items.AddRange(new object[] {
            "Customer",
            "Admin"});
            this.assessmentbox.Location = new System.Drawing.Point(216, 36);
            this.assessmentbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.assessmentbox.Name = "assessmentbox";
            this.assessmentbox.Size = new System.Drawing.Size(173, 28);
            this.assessmentbox.TabIndex = 3;
            this.assessmentbox.Text = "Select Assessment Component";
            this.assessmentbox.SelectedIndexChanged += new System.EventHandler(this.assessmentbox_SelectedIndexChanged);
            // 
            // rubric_level_box
            // 
            this.rubric_level_box.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rubric_level_box.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.rubric_level_box.ForeColor = System.Drawing.Color.DimGray;
            this.rubric_level_box.Items.AddRange(new object[] {
            "Customer",
            "Admin"});
            this.rubric_level_box.Location = new System.Drawing.Point(429, 36);
            this.rubric_level_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rubric_level_box.Name = "rubric_level_box";
            this.rubric_level_box.Size = new System.Drawing.Size(173, 28);
            this.rubric_level_box.TabIndex = 4;
            this.rubric_level_box.Text = "Select Rubric Level";
            // 
            // Edit_btn
            // 
            this.Edit_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Edit_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.Edit_btn.BorderRadius = 5;
            this.Edit_btn.BorderThickness = 1;
            this.Edit_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Edit_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Edit_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Edit_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Edit_btn.FillColor = System.Drawing.Color.White;
            this.Edit_btn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Edit_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.Edit_btn.Location = new System.Drawing.Point(379, 701);
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.Size = new System.Drawing.Size(116, 37);
            this.Edit_btn.TabIndex = 73;
            this.Edit_btn.Text = "Delete";
            // 
            // Mark_btn
            // 
            this.Mark_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Mark_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.Mark_btn.BorderRadius = 5;
            this.Mark_btn.BorderThickness = 1;
            this.Mark_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Mark_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Mark_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Mark_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Mark_btn.FillColor = System.Drawing.Color.White;
            this.Mark_btn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Mark_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.Mark_btn.Location = new System.Drawing.Point(198, 701);
            this.Mark_btn.Name = "Mark_btn";
            this.Mark_btn.Size = new System.Drawing.Size(142, 37);
            this.Mark_btn.TabIndex = 72;
            this.Mark_btn.Text = "Add Evaluation";
            this.Mark_btn.Click += new System.EventHandler(this.Mark_btn_Click);
            // 
            // GridAssessments
            // 
            this.GridAssessments.AllowUserToAddRows = false;
            this.GridAssessments.AllowUserToDeleteRows = false;
            this.GridAssessments.AllowUserToResizeColumns = false;
            this.GridAssessments.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.GridAssessments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.GridAssessments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GridAssessments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridAssessments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GridAssessments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(148)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(148)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridAssessments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.GridAssessments.ColumnHeadersHeight = 35;
            this.GridAssessments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridAssessments.DefaultCellStyle = dataGridViewCellStyle11;
            this.GridAssessments.EnableHeadersVisualStyles = true;
            this.GridAssessments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridAssessments.Location = new System.Drawing.Point(-2, 149);
            this.GridAssessments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GridAssessments.MultiSelect = false;
            this.GridAssessments.Name = "GridAssessments";
            this.GridAssessments.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridAssessments.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.GridAssessments.RowHeadersVisible = false;
            this.GridAssessments.RowHeadersWidth = 100;
            this.GridAssessments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridAssessments.RowTemplate.Height = 25;
            this.GridAssessments.Size = new System.Drawing.Size(838, 490);
            this.GridAssessments.TabIndex = 74;
            this.GridAssessments.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(128)))), ((int)(((byte)(26)))));
            this.GridAssessments.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridAssessments.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.GridAssessments.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.GridAssessments.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.GridAssessments.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GridAssessments.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridAssessments.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(148)))), ((int)(((byte)(62)))));
            this.GridAssessments.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.GridAssessments.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridAssessments.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GridAssessments.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GridAssessments.ThemeStyle.HeaderStyle.Height = 35;
            this.GridAssessments.ThemeStyle.ReadOnly = true;
            this.GridAssessments.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GridAssessments.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridAssessments.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridAssessments.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(160)))));
            this.GridAssessments.ThemeStyle.RowsStyle.Height = 25;
            this.GridAssessments.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.GridAssessments.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // MarkEvalution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GridAssessments);
            this.Controls.Add(this.Edit_btn);
            this.Controls.Add(this.Mark_btn);
            this.Controls.Add(this.rubric_level_box);
            this.Controls.Add(this.assessmentbox);
            this.Controls.Add(this.cmb_student);
            this.Name = "MarkEvalution";
            this.Size = new System.Drawing.Size(834, 789);
            ((System.ComponentModel.ISupportInitialize)(this.GridAssessments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_student;
        private System.Windows.Forms.ComboBox assessmentbox;
        private System.Windows.Forms.ComboBox rubric_level_box;
        private Guna.UI2.WinForms.Guna2Button Edit_btn;
        private Guna.UI2.WinForms.Guna2Button Mark_btn;
        private Guna.UI2.WinForms.Guna2DataGridView GridAssessments;
    }
}
