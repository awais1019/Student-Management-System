using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProjectEven.Classes.BL
{
    public class StudentAttendanceWithDetails
    {
        public Student Student { get; set; }
        public StudentAttendance Attendance { get; set; }

        public StudentAttendanceWithDetails(Student student, StudentAttendance attendance)
        {
            this.Student = student;
            this.Attendance = attendance;
        }
    }
}
