using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProjectEven.Classes.BL
{
    public class Assessment
    {
     /*   public int Id { get; set; }*/
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public int TotalMarks { get; set; }
        public int TotalWeightage { get; set; }

        public Assessment( string title, DateTime dateCreated, int totalMarks, int totalWeightage)
        {
         /*   Id = id;*/
            Title = title;
            DateCreated = dateCreated;
            TotalMarks = totalMarks;
            TotalWeightage = totalWeightage;
        }
    }

}
