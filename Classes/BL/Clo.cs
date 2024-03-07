using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProjectEven.Classes
{
    public  class Clo
    {
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

        public Clo(string name, DateTime dateCreated, DateTime dateUpdated)
        {
            Name = name;
            DateCreated = new DateTime(dateCreated.Year, dateCreated.Month, dateCreated.Day, dateCreated.Hour, dateCreated.Minute, 0); 
            DateUpdated = new DateTime(dateUpdated.Year, dateUpdated.Month, dateUpdated.Day, dateUpdated.Hour, dateUpdated.Minute, 0);
        }
    }
}
