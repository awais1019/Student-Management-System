using MidProjectEven.Classes;
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
    public partial class ManageClos_Control : UserControl
    {
        private string cloName;
        private string rubricDetails;
        private string rubriclevelDetails;
        private int measurementLevel;
        Clo_Rubrics_Card card;
        public ManageClos_Control()
        {
            InitializeComponent();
            loadClos();
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Add_btn_Click_1(object sender, EventArgs e)
        {
           if(ValidateAndStoreValues())
            {
                Clo clo = new Clo(cloName, DateTime.Now, DateTime.Now);
                int cloid=DataBase.SaveCloInDatabase(clo);
                if(cloid != -1)
                {
                    Rubric rubric = new Rubric(1,rubricDetails, cloid);
                    int Rubric_id = DataBase.InsertRubricForThatClo(rubric);
                    if(Rubric_id!=-1)
                    {
                        RubricLevel level=new RubricLevel(Rubric_id, rubriclevelDetails, measurementLevel);
                       bool isready= DataBase.DoesRubricHaveLevelWithMeasurement(Rubric_id, measurementLevel);
                        if (isready)
                        {
                            MessageBox.Show("Rubric Level with this Measurment Levle Already Exis");
                        }
                        else
                        {
                            bool istrue = DataBase.StoreLevelAndCheck(level);
                            if (istrue)
                            {
                                MessageBox.Show("CLo with its Rubric and Rubric Levels saved");
                                loadClos();
                            }
                            else
                            {
                                MessageBox.Show("Rubric  or Rubric Level Already Exits");
                            }
                        }
                    }
                }
            }
           
        }
      


 
        private bool ValidateAndStoreValues()
        {
            if (String.IsNullOrEmpty(clo_name_txtbox.Text))
            {
                MessageBox.Show("CLO Name cannot be empty.");
                return false;
            }
            else
            {
              
                cloName = clo_name_txtbox.Text;
            }


            if (String.IsNullOrEmpty(rubric_details_txt.Text))
            {
              
                MessageBox.Show("Rubric Details cannot be empty.");
                return false;
            }
            else
            {
        
                rubricDetails = rubric_details_txt.Text;
            }
            if(String.IsNullOrEmpty(rubric_level_txt.Text) )
            {
                MessageBox.Show("Rubric Level Details  cannot be empty.");
                return false;

            }
            else
            {
                 rubriclevelDetails=rubric_level_txt.Text;
            }

            if (int.Parse(measurement_level.Text) <=0)
            {
                MessageBox.Show("Measurement Level must be greater than 0.");
                return false;
            }
            else
            {
                
                measurementLevel = int.Parse(measurement_level.Text);

            }

          
            return true;
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            string selectedclo=AllClos_box.SelectedItem.ToString();
            int Cloid = DataBase.GetCloId(selectedclo);
            if(Cloid!=-1)
            {
                card=new Clo_Rubrics_Card();
                card.FillCloName(selectedclo);
                List<Rubric> rubric_list = DataBase.GetRubricsForClo(Cloid);
                int j = 1;
                for (int i = 0; i <rubric_list.Count; i++,j++)
                {
                    List<RubricLevel> rubricLevels = DataBase.GetRubricLevels(rubric_list[i].id);
                    Rubric rubric = rubric_list[i];

              
                    card.FillRubricsAndRubricsLevels(rubric, rubricLevels, j);
                }


                flowLayoutPanel1.Controls.Add(card);
            }
 
            flowLayoutPanel1.Dock= DockStyle.Fill;

            flowLayoutPanel1.ResumeLayout();
        }

        void loadClos()
        {
            List<string>list=DataBase.GetAllCloNames();
            AllClos_box.DataSource = list;
        
        }
    }
}
