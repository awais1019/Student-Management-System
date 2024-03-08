namespace MidProjectEven.UserControls
{
    partial class Clo_Rubrics_Card
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
            this.submain_table = new System.Windows.Forms.TableLayoutPanel();
            this.main_table = new System.Windows.Forms.TableLayoutPanel();
            this.table1 = new System.Windows.Forms.TableLayoutPanel();
            this.main_table.SuspendLayout();
            this.SuspendLayout();
            // 
            // submain_table
            // 
            this.submain_table.BackColor = System.Drawing.Color.White;
            this.submain_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.submain_table.ColumnCount = 5;
            this.submain_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.submain_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.submain_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.submain_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.submain_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.submain_table.Dock = System.Windows.Forms.DockStyle.Right;
            this.submain_table.ForeColor = System.Drawing.Color.Black;
            this.submain_table.Location = new System.Drawing.Point(203, 3);
            this.submain_table.Name = "submain_table";
            this.submain_table.RowCount = 4;
            this.submain_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.454545F));
            this.submain_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.98418F));
            this.submain_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.70695F));
            this.submain_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.85432F));
            this.submain_table.Size = new System.Drawing.Size(1094, 642);
            this.submain_table.TabIndex = 6;
            // 
            // main_table
            // 
            this.main_table.BackColor = System.Drawing.Color.White;
            this.main_table.ColumnCount = 2;
            this.main_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.main_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1100F));
            this.main_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.main_table.Controls.Add(this.table1, 0, 0);
            this.main_table.Controls.Add(this.submain_table, 2, 0);
            this.main_table.Location = new System.Drawing.Point(0, 0);
            this.main_table.Name = "main_table";
            this.main_table.RowCount = 1;
            this.main_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.main_table.Size = new System.Drawing.Size(1300, 648);
            this.main_table.TabIndex = 0;
            // 
            // table1
            // 
            this.table1.BackColor = System.Drawing.Color.White;
            this.table1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.table1.ColumnCount = 1;
            this.table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table1.Location = new System.Drawing.Point(3, 3);
            this.table1.Name = "table1";
            this.table1.RowCount = 1;
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 642F));
            this.table1.Size = new System.Drawing.Size(194, 642);
            this.table1.TabIndex = 5;
            // 
            // Clo_Rubrics_Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.main_table);
            this.DoubleBuffered = true;
            this.Name = "Clo_Rubrics_Card";
            this.Size = new System.Drawing.Size(1300, 648);
            this.main_table.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel submain_table;
        private System.Windows.Forms.TableLayoutPanel main_table;
        private System.Windows.Forms.TableLayoutPanel table1;
    }
}
