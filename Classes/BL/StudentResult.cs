using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProjectEven.Classes.BL
{
    public class StudentResult
    {
        public int StudentId { get; set; }
        public int AssessmentComponentId { get; set; }
        public int RubricMeasurementId { get; set; }
        public DateTime EvaluationDate { get; set; }

    

    
            public StudentResult(int studentId, int assessmentComponentId, int rubricMeasurementId,DateTime  datetime)
            {
                StudentId = studentId;
                AssessmentComponentId = assessmentComponentId;
            RubricMeasurementId = rubricMeasurementId;
            EvaluationDate = new DateTime(datetime.Year, datetime.Month, datetime.Day, datetime.Hour, datetime.Minute, 0);

        }



    }
}
