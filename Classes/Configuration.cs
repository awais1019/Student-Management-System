using System;
using System.Data.SqlClient;

namespace MidProjectEven
{
    class Configuration
    {
        public static string SqlConnectionString = "Data Source=AWAIS-LAPTOP;Initial Catalog=ProjectB;Integrated Security=True;Encrypt=False";

        private static Configuration _instance;
    

        public static void getStudents()
        {
            using(var con = new SqlConnection(SqlConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Student;", con);


            }
        }



      


    }
}
