using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProjectEven.Classes.BL
{
    public class AssessmentComponent
    {
   /*     public int Id { get; set; }*/
        public string Name { get; set; }
        public int RubricId { get; set; }
        public int TotalMarks { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int AssessmentId { get; set; }

        public AssessmentComponent(string name, int rubricId, int totalMarks, DateTime dateCreated, DateTime dateUpdated, int assessmentId)
        {
           /* Id = id;*/
            Name = name;
            RubricId = rubricId;
            TotalMarks = totalMarks;
            DateCreated = dateCreated;
            DateUpdated = dateUpdated;
            AssessmentId = assessmentId;
        }
    }
}
