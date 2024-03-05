using MidProjectEven.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MidProjectEven
{
   public  class DataBase
    {
        public static string SqlConnectionString = "Data Source=AWAIS-LAPTOP;Initial Catalog=ProjectB;Integrated Security=True;Encrypt=False";



        public static List<Student> SearchData(string name)
        {
            List<Student> result = new List<Student>();

            using (SqlConnection connection = new SqlConnection(DataBase.SqlConnectionString))
            {
                connection.Open();

                try
                {
                    string query = "SELECT FirstName, LastName, Contact, Email, RegistrationNumber, Status FROM Student WHERE FirstName = @name";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", name);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string FirstName = reader["FirstName"].ToString();
                        string LastName = reader["LastName"].ToString();
                        string Contact = reader["Contact"].ToString();
                        string Email = reader["Email"].ToString();
                        string RegistrationNumber = reader["RegistrationNumber"].ToString();
                        int Status = Convert.ToInt32(reader["Status"]);
                        Student student = new Student(FirstName, LastName, RegistrationNumber, Email, Contact, Status);
                        result.Add(student);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return result;
        }
           public static List<string>FillStatusComboBox()
        {
            List<string> result = new List<string>();   
           


            using (SqlConnection connection = new SqlConnection(DataBase.SqlConnectionString))
            {
                connection.Open();

                try
                {

                    string query = "SELECT Name FROM Lookup WHERE Category = 'ATTENDANCE_STATUS'";
                    SqlCommand command = new SqlCommand(query, connection);


                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string itemName = reader["Name"].ToString();
                        result.Add(itemName);
                        
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return result;

        }
        public static int GetStudentId(string registrationNumber)
        {
            using (SqlConnection connection = new SqlConnection(DataBase.SqlConnectionString))
            {
                connection.Open();

                try
                {
                    string query = "SELECT Id FROM Student WHERE RegistrationNumber = @registrationNumber";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@registrationNumber", registrationNumber);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read() && reader["Id"] != DBNull.Value)
                        {
                            return Convert.ToInt32(reader["Id"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

      
            return -1;
        }

        public static int AddClassAttendanceAndGetId(ClassAttendance classAttendance)
        {
            using (SqlConnection connection = new SqlConnection(DataBase.SqlConnectionString))
            {
                connection.Open();

                try
                {
                    string query = "INSERT INTO ClassAttendance (AttendanceDate) OUTPUT INSERTED.Id VALUES (@attendanceDate)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@attendanceDate", classAttendance.AttendanceDate);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read() && reader["Id"] != DBNull.Value)
                        {
                            return Convert.ToInt32(reader["Id"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

     
            return -1;
        }

        public static int GetStatusId(string statusName)
        {
            using (SqlConnection connection = new SqlConnection(DataBase.SqlConnectionString))
            {
                try
                {
                    string query = "SELECT LookupId FROM Lookup WHERE Name = @name AND Category = 'ATTENDANCE_STATUS'";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", statusName);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result == null)
                    {
                        return -1;
                    }

                    return Convert.ToInt32(result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return -1;
                }
            }
        }









    }
}
