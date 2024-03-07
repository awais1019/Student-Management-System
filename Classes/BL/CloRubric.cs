using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProjectEven.Classes.BL
{
    public class CloRubric
    {

        public List<Rubric> rubrics { get; set; }
        public List<RubricLevel> rubricslevels { get; set; }

        public CloRubric(List<Rubric> rubrics,List<RubricLevel>rubricLevels)
        {
            this.rubrics = rubrics;
            this.rubricslevels = rubricLevels;
        }

    }
}
