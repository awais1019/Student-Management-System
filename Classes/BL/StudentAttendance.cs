using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProjectEven.Classes
{
    public class StudentAttendance
    {

        public int ClassAttendanceId { get; set; }
        public int StudentId { get; set; }
        public int AttendanceStatusId { get; set; }
        public StudentAttendance(int studentId, int classAttendanceId, int attendanceStatusId)
        {
            this.StudentId = studentId;
            this.ClassAttendanceId = classAttendanceId;
            this.AttendanceStatusId = attendanceStatusId;
        }


    }
}
