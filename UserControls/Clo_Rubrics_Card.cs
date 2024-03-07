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
            FillTable1(table2);
        }
       
        private void table2_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {
            
        }
   private static void FillTable1(TableLayoutPanel table)
{
            // Set AutoSizeMode to prevent unexpected resizing (optional)
          

    // Assuming you want to add string data to each cell
    string[] cellData = { "Cell 1 MY Name is Awais And What is your Name Can you Tell me What is your name",
                           "Cell 2 jjjjjjjjjjjjjjjjjjjjjjjjjjjj",
                           "Cell 3" };

    // Check if the table has at least three rows
    if (table.RowCount >= cellData.Length)
    {
        // Iterate through each cell and add string data
        for (int i = 0; i < cellData.Length; i++)
        {
            Label label = new Label();
            label.Text = cellData[i];

            // Set larger font size (adjust as needed)
            label.Font = new Font(label.Font.FontFamily, 9, FontStyle.Regular); 

            // Wrap text to the next line if it overflows the label width
            label.AutoSize = true;

            // Add the label to the corresponding cell (i = row index, 0 = column index)
            table.Controls.Add(label, 0, i);
        }
    }
    else
    {
        Console.WriteLine("Table doesn't have enough rows to accommodate the data. Adjust the table or cellData array.");
    }
}

    }
}
