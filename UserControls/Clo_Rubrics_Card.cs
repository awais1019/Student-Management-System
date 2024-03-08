using MidProjectEven.Classes.BL;
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
    public partial class Clo_Rubrics_Card : UserControl
    {

        public Clo_Rubrics_Card()
        {
            InitializeComponent();
        }
       

        private void table2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private static void FillTable1(TableLayoutPanel table)
        {
    
            string[] cellData = { "Cell 1 MY Name is Awais And What is your Name Can you Tell me What is your name",
                           "Cell 2 jjjjjjjjjjjjjjjjjjjjjjjjjjjj",
                           "Cell 3" };

        
            if (table.RowCount >= cellData.Length)
            {
               
                for (int i = 0; i < cellData.Length; i++)
                {
                    Label label = new Label();
                    label.Text = cellData[i];
                    label.Font = new Font(label.Font.FontFamily, 9, FontStyle.Regular);
                    label.AutoSize = true;
                    table.Controls.Add(label, 0, i);
                }
            }
            else
            {
                Console.WriteLine("Table doesn't have enough rows to accommodate the data. Adjust the table or cellData array.");
            }
        }
        public  void FillCloName(string cloName)
        {      
            FillTable1(table1, cloName);
        }

        public void FillRubricsAndRubricsLevels(Rubric rubric,List<RubricLevel> list,int rowcount)
        {
            PrintRubricAndLevelsInRow(submain_table,rubric,list,rowcount);
        }



        private void FillTable1(TableLayoutPanel table, string cloName)
        {
            if (table.RowCount >= 1)
            {
                table.Controls.Clear();

                Label label = new Label();
                label.Font = new Font(label.Font.FontFamily, 10, FontStyle.Bold);
                label.AutoSize = true;
                label.Text = cloName;
                label.Anchor = AnchorStyles.None;
                label.TextAlign = ContentAlignment.MiddleCenter;
                table.Controls.Add(label, 0, 0);
            }
        }

      


        public static void PrintRubricAndLevelsInRow(TableLayoutPanel table, Rubric rubric, List<RubricLevel> rubricLevels, int rowNumber)
        {
            if (rubric == null || rubricLevels == null || rubricLevels.Count == 0)
            {
                return; 
            }

        
            Label rubricLabel = new Label();

            rubricLabel.Text = rubric.Details;
            rubricLabel.Font = new Font(rubricLabel.Font, FontStyle.Bold);
            table.Controls.Add(rubricLabel, 0, rowNumber); 

    
            for (int i = 0; i < rubricLevels.Count; i++)
            {
                Label levelLabel = new Label();
                levelLabel.Text = $"{rubricLevels[i].Details} Level:({rubricLevels[i].MeasurementLevel})";

                table.Controls.Add(levelLabel, i + 1, rowNumber); 
            }
            if (table.RowCount <= rowNumber)
            {
                table.RowCount = rowNumber + 1;
            }
        }







    }


}
