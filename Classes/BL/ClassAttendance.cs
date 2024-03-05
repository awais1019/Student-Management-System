using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProjectEven.Classes
{
    public class ClassAttendance
    {
            public DateTime AttendanceDate { get; set; }

        public ClassAttendance()
        {
            AttendanceDate = DateTime.Now;
        }


    }
}
