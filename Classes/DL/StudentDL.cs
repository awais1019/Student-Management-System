using Guna.UI2.WinForms.Enums;
using MidProjectEven.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace MidProjectEven.Classes.DL
{
    public class StudentDL
    {
        static public List<Student_infromation_card> List = new List<Student_infromation_card>();

        public static void Add_Students(Student_infromation_card student_infromation_card)
        {
            List.Add(student_infromation_card);
        }
        public static void RemoveCardFromList(Student_infromation_card student_infromation_card)
        {
            List.Remove(student_infromation_card);
        }
       public static void changechecked(Student student,bool value)
        {
            for (int i = 0; i < List.Count; i++)
            {
                if (List[i].student_.FirstName == student.FirstName &&List[i].student_.RegistrationNumber==student.RegistrationNumber)
                {
                    List[i].checked_ = value;
               
                }
       
            }
        }
        public static List<Student_infromation_card> count_checked_student()
        {
            List<Student_infromation_card>checked_student=new List<Student_infromation_card>();
            for (int i = 0; i < List.Count; i++)
            {
                if (List[i].checked_) 
                {
                    checked_student.Add(List[i]); 
                }
            }
            return checked_student;
        }
        public static bool AllUnchecked(bool value)
        {
            for (int i = 0; i < List.Count; i++)
            {
           
                List[i].checked_ = value;
                   
            }
            return true;
        }

        public static Student GetCheckedStudent()
        {
            Student student=null;
            for (int i = 0; i < List.Count; i++)
            {
                if (List[i].checked_)
                {
                    student = new Student(List[i].student_.FirstName, List[i].student_.LastName, List[i].student_.RegistrationNumber, List[i].student_.Email, List[i].student_.Contact, List[i].student_.Status);
                    List[i].checked_ = false;
                }
            }

            return student;
        }
        public static List<Student> GetCheckedStudentsList()
        {
            List<Student> students = new List<Student>();
            Student student = null;
            for (int i = 0; i < List.Count; i++)
            {
                if (List[i].checked_)
                {
                    student = new Student(List[i].student_.FirstName, List[i].student_.LastName, List[i].student_.RegistrationNumber, List[i].student_.Email, List[i].student_.Contact, List[i].student_.Status);
                    List[i].checked_ = false;
                    students.Add(student);

                }
            }

            return students;
        }
        public static bool RemoveCardFromList(List<Student_infromation_card>deletelist)
        {
            foreach (var item in deletelist)
            {
                RemoveCardFromList(item);
            }
            return true;
        }


    }
}
