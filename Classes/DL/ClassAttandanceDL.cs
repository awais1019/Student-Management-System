using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProjectEven.Classes.DL
{
    public  class ClassAttandanceDL
    {
       public static  List <ClassAttendance> attendancesdate=new List<ClassAttendance>();

        public static bool AddIntoList(ClassAttendance attendance)
        {
            if(attendance == null) return false;
            attendancesdate.Add(attendance);
            return true;
        }
        public static bool RemoveFromList(ClassAttendance attendance)
        {
            attendancesdate.Remove(attendance);
            return true;
        }
        public static ClassAttendance  GetFirstObj()
        {
            foreach (var item in attendancesdate)
            {
                return item;
            }
            return null;
        }
    }
}
