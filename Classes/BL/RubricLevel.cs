using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProjectEven.Classes.BL
{
    public class RubricLevel
    {
        public int RubricId { get; set; }
        public string Details { get; set; }
        public int MeasurementLevel { get; set; }

        public RubricLevel(int rubricId, string details, int measurementLevel)
        {
        
            RubricId = rubricId;
            Details = details;
            MeasurementLevel = measurementLevel;
        }
    }
}
