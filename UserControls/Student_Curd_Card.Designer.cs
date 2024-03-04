namespace MidProjectEven.UserControls
{
    partial class Student_Curd_Card
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.select_all_label = new System.Windows.Forms.Label();
            this.guna2CustomCheckBox1 = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.cross_everything = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.update_box = new System.Windows.Forms.PictureBox();
            this.selected_label = new System.Windows.Forms.Label();
            this.selected_items = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cross_everything)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.update_box)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.selected_items);
            this.panel1.Controls.Add(this.selected_label);
            this.panel1.Controls.Add(this.update_box);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.cross_everything);
            this.panel1.Controls.Add(this.guna2CustomCheckBox1);
            this.panel1.Controls.Add(this.select_all_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 53);
            this.panel1.TabIndex = 0;
            // 
            // select_all_label
            // 
            this.select_all_label.AutoSize = true;
            this.select_all_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_all_label.ForeColor = System.Drawing.Color.White;
            this.select_all_label.Location = new System.Drawing.Point(23, 13);
            this.select_all_label.Name = "select_all_label";
            this.select_all_label.Size = new System.Drawing.Size(94, 25);
            this.select_all_label.TabIndex = 1;
            this.select_all_label.Text = "Select All";
            // 
            // guna2CustomCheckBox1
            // 
            this.guna2CustomCheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CustomCheckBox1.CheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CustomCheckBox1.Location = new System.Drawing.Point(2, 2);
            this.guna2CustomCheckBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2CustomCheckBox1.Name = "guna2CustomCheckBox1";
            this.guna2CustomCheckBox1.Padding = new System.Windows.Forms.Padding(3);
            this.guna2CustomCheckBox1.Size = new System.Drawing.Size(16, 49);
            this.guna2CustomCheckBox1.TabIndex = 4;
            this.guna2CustomCheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CustomCheckBox1.UncheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // cross_everything
            // 
            this.cross_everything.Image = global::MidProjectEven.Properties.Resources.icons8_cross_50;
            this.cross_everything.Location = new System.Drawing.Point(796, 8);
            this.cross_everything.Name = "cross_everything";
            this.cross_everything.Size = new System.Drawing.Size(35, 30);
            this.cross_everything.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cross_everything.TabIndex = 5;
            this.cross_everything.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MidProjectEven.Properties.Resources.icons8_update_64;
            this.pictureBox2.Location = new System.Drawing.Point(692, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // update_box
            // 
            this.update_box.Image = global::MidProjectEven.Properties.Resources.icons8_delete_24;
            this.update_box.Location = new System.Drawing.Point(744, 8);
            this.update_box.Name = "update_box";
            this.update_box.Size = new System.Drawing.Size(35, 30);
            this.update_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.update_box.TabIndex = 7;
            this.update_box.TabStop = false;
            // 
            // selected_label
            // 
            this.selected_label.AutoSize = true;
            this.selected_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selected_label.ForeColor = System.Drawing.Color.White;
            this.selected_label.Location = new System.Drawing.Point(229, 13);
            this.selected_label.Name = "selected_label";
            this.selected_label.Size = new System.Drawing.Size(89, 25);
            this.selected_label.TabIndex = 8;
            this.selected_label.Text = "Selected";
            // 
            // selected_items
            // 
            this.selected_items.AutoSize = true;
            this.selected_items.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selected_items.ForeColor = System.Drawing.Color.White;
            this.selected_items.Location = new System.Drawing.Point(314, 13);
            this.selected_items.Name = "selected_items";
            this.selected_items.Size = new System.Drawing.Size(23, 25);
            this.selected_items.TabIndex = 9;
            this.selected_items.Text = "1";
            // 
            // Student_Curd_Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Student_Curd_Card";
            this.Size = new System.Drawing.Size(834, 53);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cross_everything)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.update_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label select_all_label;
        private Guna.UI2.WinForms.Guna2CustomCheckBox guna2CustomCheckBox1;
        private System.Windows.Forms.PictureBox cross_everything;
        private System.Windows.Forms.PictureBox update_box;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label selected_label;
        private System.Windows.Forms.Label selected_items;
    }
}
