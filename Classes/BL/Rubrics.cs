using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProjectEven.Classes.BL
{
    public  class Rubric
    {  
 
            public string Details { get; set; }
        
            public int CloId { get; set; } 
            public int id { get; set; } 

            public Rubric(int id,string details, int cloId)
            {
               this.id = id;
                Details = details;
                CloId = cloId;
            }
        

    }
}
