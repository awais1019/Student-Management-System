using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProjectEven.Classes.DL
{
    public class StudentAttendanceDL
    {
        public static List<StudentAttendance> studentAttendancelist = new List<StudentAttendance>();
        public static bool AddintoList(StudentAttendance studentAttendance)
        {
            if (studentAttendance == null)
                return false;
            foreach (var item in studentAttendancelist)
            {
                if(item.StudentId==studentAttendance.StudentId&&studentAttendance.AttendanceStatusId==item.AttendanceStatusId)
                {
                    return false;
                }
                if(item.StudentId == studentAttendance.StudentId && studentAttendance.AttendanceStatusId != item.AttendanceStatusId)
                {
                    item.AttendanceStatusId = studentAttendance.AttendanceStatusId;
                    return true;
                }
            }
            studentAttendancelist.Add(studentAttendance);
            return true;
        }
        public static bool RemoveFromList (StudentAttendance studentAttendance)
        {

               studentAttendancelist.Remove(studentAttendance);             
                return true;
         }
/*       public static bool  UpdateStudentStatus(StudentAttendance studentAttendance)
        {
            foreach (var item in studentAttendancelist)
            {
                if(studentAttendance.StudentId==item.StudentId)
                {
                    item.AttendanceStatusId = studentAttendance.AttendanceStatusId;
                    return true;
                }
            }
            return false;
        }*/
    }
}
