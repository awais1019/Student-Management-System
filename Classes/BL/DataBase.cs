using MidProjectEven.Classes;
using MidProjectEven.Classes.BL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web;
using System.Windows.Forms;

namespace MidProjectEven
{
   public  class DataBase
    {
        public static string SqlConnectionString = "Data Source=AWAIS-LAPTOP;Initial Catalog=ProjectB;Integrated Security=True;Encrypt=False";



        public static List<Student> SearchData(string name, int status=5)
        {
            List<Student> result = new List<Student>();

            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
            {
                connection.Open();

                try
                {
                    string query = "SELECT FirstName, LastName, Contact, Email, RegistrationNumber, Status FROM Student WHERE FirstName = @name AND Status = @status";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@status", status);

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
        public static void AddStudentAttendanceInDB(StudentAttendance studentAttendance)
        {
            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
            {
                connection.Open();

                try
                {
                    string query = "INSERT INTO StudentAttendance (AttendanceId, StudentId, AttendanceStatus) " +
                                   "VALUES (@AttendanceId, @StudentId, @AttendanceStatus)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@AttendanceId", studentAttendance.ClassAttendanceId);
                    command.Parameters.AddWithValue("@StudentId", studentAttendance.StudentId);
                    command.Parameters.AddWithValue("@AttendanceStatus", studentAttendance.AttendanceStatusId);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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
            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
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
            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
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
            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
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

      public static  List<Student> LoadActiveStudents()
        {
            List<Student> studentsWithStatus5 = new List<Student>();

            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
            {
                connection.Open();

                try
                {
                    string query = "SELECT FirstName, LastName, Contact, Email, RegistrationNumber, Status FROM Student WHERE Status = 5";
                    SqlCommand command = new SqlCommand(query, connection);

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
                        studentsWithStatus5.Add(student);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return studentsWithStatus5;
        }
        public static bool MakeStudentInactive(Student student)
        {
            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE Student SET Status = 6 WHERE RegistrationNumber = @RegistrationNumber";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@RegistrationNumber", student.RegistrationNumber);

                    int rowsAffected = command.ExecuteNonQuery();

              
                    if (rowsAffected > 0)
                    {
                     
                        return true;
                    }
                    else
                    {
                     
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }
        public static List<string> GetAllDateAndTimes() 
        {
            List<string> result = new List<string>();

            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
            {
                connection.Open();

                try
                {
                    string query = "SELECT AttendanceDate FROM ClassAttendance"; 
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string formattedDate = reader["AttendanceDate"].ToString(); // Get date as string
                        result.Add(formattedDate);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return result;
        }

        public static int GetSelectedTimeIdFromClassAttendance(string selectedDate)
        {
            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
            {
                connection.Open();

                try
                {
                    string query = "SELECT Id FROM ClassAttendance WHERE AttendanceDate = @selectedDate";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@selectedDate", selectedDate);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
              
                        return -1; 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return -1;
        }
        public static Dictionary<int, int> GetStudentAttendanceStatus(int attendanceId)
        {
            Dictionary<int, int> studentAttendanceStatus = new Dictionary<int, int>();

            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
            {
                connection.Open();

                try
                {
                    string query = "SELECT StudentId, AttendanceStatus FROM StudentAttendance WHERE ClassAttendanceId = @attendanceId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@attendanceId", attendanceId);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int studentId = Convert.ToInt32(reader["StudentId"]);
                        int attendanceStatus = Convert.ToInt32(reader["AttendanceStatus"]);

                        studentAttendanceStatus.Add(studentId, attendanceStatus);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return studentAttendanceStatus;
        }
        public static List<StudentAttendanceWithDetails> GetAttendanceDetails(int attendanceId)
        {
            List<StudentAttendanceWithDetails> details = new List<StudentAttendanceWithDetails>();

            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
            {
                connection.Open();

                try
                {
                    string query = @"
                SELECT
                    s.Id AS StudentId,
                    s.FirstName,
                    s.LastName,
                    s.RegistrationNumber,
                    s.Email,
                    s.Contact,
                    a.AttendanceStatus
                FROM
                    Student s
                INNER JOIN
                    StudentAttendance a ON s.Id = a.StudentId
                WHERE
                    a.AttendanceId = @attendanceId";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@attendanceId", attendanceId);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int studentId = Convert.ToInt32(reader["StudentId"]);
                        string firstName = reader["FirstName"].ToString();
                        string lastName = reader["LastName"].ToString();
                        string regNumber = reader["RegistrationNumber"].ToString();
                        string email = reader["Email"].ToString();
                        string contact = reader["Contact"].ToString();
                        int attendanceStatus = int.Parse(reader["AttendanceStatus"].ToString());

                        Student student = new Student(firstName, lastName, regNumber, email, contact,6); 
                        StudentAttendance attendance = new StudentAttendance(studentId, attendanceId, attendanceStatus);

                        StudentAttendanceWithDetails detail = new StudentAttendanceWithDetails(student, attendance);
                        details.Add(detail);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return details;
        }

        public static  int GetStatusIdOne(string statusName)
        {
            using (SqlConnection connection = new SqlConnection(DataBase.SqlConnectionString))
            {
                try
                {
                    string query = "SELECT LookupId FROM Lookup WHERE Name = @name AND Category = 'STUDENT_STATUS'";
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
        public static  bool InsertStudent(Student student)
        {
            using (SqlConnection connection = new SqlConnection(DataBase.SqlConnectionString))
            {
                connection.Open();
                try
                {

                    string checkQuery = "SELECT COUNT(*) FROM Student WHERE RegistrationNumber = @RegistrationNumber";
                    SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                    checkCommand.Parameters.AddWithValue("@RegistrationNumber", student.RegistrationNumber);

                    int existingCount = (int)checkCommand.ExecuteScalar();

                    if (existingCount > 0)
                    {

                        return false;
                    }


                    string insertQuery = "INSERT INTO Student (FirstName, LastName, Email, RegistrationNumber, Contact, Status) " +
                                         "VALUES (@FirstName, @LastName, @Email, @RegistrationNumber, @Contact, @Status)";

                    SqlCommand command = new SqlCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@FirstName", student.FirstName);
                    command.Parameters.AddWithValue("@LastName", student.LastName);
                    command.Parameters.AddWithValue("@Email", student.Email);
                    command.Parameters.AddWithValue("@RegistrationNumber", student.RegistrationNumber);
                    command.Parameters.AddWithValue("@Contact", student.Contact);
                    command.Parameters.AddWithValue("@Status", student.Status);
                    command.ExecuteNonQuery();

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                return false;
            }
        }
        public static bool EditStudent(string oldRegistrationNumber, Student newStudent)
        {
            using (SqlConnection connection = new SqlConnection(DataBase.SqlConnectionString))
            {
                connection.Open();
                try
                {

                    string checkQuery = "SELECT COUNT(*) FROM Student WHERE RegistrationNumber = @OldRegistrationNumber";
                    SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                    checkCommand.Parameters.AddWithValue("@OldRegistrationNumber", oldRegistrationNumber);

                    int existingCount = (int)checkCommand.ExecuteScalar();


                    if (existingCount > 0)
                    {
                        string updateQuery = "UPDATE Student SET FirstName = @FirstName, LastName = @LastName, " +
                                             "Email = @Email, RegistrationNumber = @NewRegistrationNumber, " +
                                             "Contact = @Contact, Status = @Status " +
                                             "WHERE RegistrationNumber = @OldRegistrationNumber";

                        SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                        updateCommand.Parameters.AddWithValue("@FirstName", newStudent.FirstName);
                        updateCommand.Parameters.AddWithValue("@LastName", newStudent.LastName);
                        updateCommand.Parameters.AddWithValue("@Email", newStudent.Email);
                        updateCommand.Parameters.AddWithValue("@NewRegistrationNumber", newStudent.RegistrationNumber);
                        updateCommand.Parameters.AddWithValue("@Contact", newStudent.Contact);
                        updateCommand.Parameters.AddWithValue("@Status", newStudent.Status);
                        updateCommand.Parameters.AddWithValue("@OldRegistrationNumber", oldRegistrationNumber);

                        updateCommand.ExecuteNonQuery();
                        return true;
                    }
                    else
                    {


                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                return false;
            }
        }
        public static List<string> FillStudentStatusComboBox()
        {

            List<string> list = new List<string>(); 
            using (SqlConnection connection = new SqlConnection(DataBase.SqlConnectionString))
            {
                connection.Open();

                try
                {

                    string query = "SELECT Name FROM Lookup WHERE Category = 'STUDENT_STATUS'";
                    SqlCommand command = new SqlCommand(query, connection);


                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string itemName = reader["Name"].ToString();
                        list.Add(itemName);
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return list;

        }
        public static int SaveCloInDatabase(Clo clo)
        {
            DateTime dateTime = DateTime.Now;
            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
            {
                connection.Open();

                try
                {
                
                    string checkQuery = "SELECT Id FROM Clo WHERE Name = @name";
                    SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                    checkCommand.Parameters.AddWithValue("@name", clo.Name);
                    object existingCloId = checkCommand.ExecuteScalar();

             
                    if (existingCloId != null)

                    {
 
                        int id= Convert.ToInt32(existingCloId);
                        UpdateCloDateUpdated(id, dateTime);
                        return id;
                    }

      
                    string insertQuery = "INSERT INTO Clo (Name, DateCreated, DateUpdated) OUTPUT INSERTED.Id VALUES (@name, @dateCreated, @dateUpdated)";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@name", clo.Name);
                    insertCommand.Parameters.AddWithValue("@dateCreated", clo.DateCreated);
                    insertCommand.Parameters.AddWithValue("@dateUpdated", clo.DateUpdated);

         
                    using (SqlDataReader reader = insertCommand.ExecuteReader())
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


        public static int InsertRubricForThatClo(Rubric rubric)
        {
            DateTime dateTime = DateTime.Now;
            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
            {
                connection.Open();

                try
                {
         
                    string checkQuery = "SELECT Id FROM Rubric WHERE CloId = @cloId AND Details = @details";
                    SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                    checkCommand.Parameters.AddWithValue("@cloId", rubric.CloId);
                    checkCommand.Parameters.AddWithValue("@details", rubric.Details);
                    object existingRubricId = checkCommand.ExecuteScalar();

                    if (existingRubricId != null)
                    {
                       
                        int id=Convert.ToInt32(existingRubricId);
                        UpdateCloDateUpdated(rubric.CloId, dateTime);
                        return id;
                    }

                    string getLastIdQuery = "SELECT MAX(Id) FROM Rubric";
                    SqlCommand getLastIdCommand = new SqlCommand(getLastIdQuery, connection);
                    object lastInsertedId = getLastIdCommand.ExecuteScalar();
                    int nextId = (lastInsertedId != DBNull.Value) ? Convert.ToInt32(lastInsertedId) + 1 : 1;

                    string insertQuery = "INSERT INTO Rubric (Id, Details, CloId) VALUES (@id, @details, @cloId)";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@id", nextId);
                    insertCommand.Parameters.AddWithValue("@details", rubric.Details);
                    insertCommand.Parameters.AddWithValue("@cloId", rubric.CloId);

                    insertCommand.ExecuteNonQuery();

                    return nextId;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return -1;
        }

        public static bool StoreLevelAndCheck(RubricLevel level)
        {
            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
            {
                connection.Open();

                try
                {

                    string checkQuery = "SELECT COUNT(*) FROM RubricLevel WHERE RubricId = @rubricId AND Details = @details AND MeasurementLevel = @measurementLevel";
                    SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                    checkCommand.Parameters.AddWithValue("@rubricId", level.RubricId);
                    checkCommand.Parameters.AddWithValue("@details", level.Details);
                    checkCommand.Parameters.AddWithValue("@measurementLevel", level.MeasurementLevel);
                    int existingLevelsCount = (int)checkCommand.ExecuteScalar();


                    if (existingLevelsCount > 0)
                    {
                        MessageBox.Show("Level with the same details and measurement level already exists. Change the level details.");
                        return false;
                    }


                    string insertQuery = "INSERT INTO RubricLevel (RubricId, Details, MeasurementLevel) VALUES (@rubricId, @details, @measurementLevel)";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@rubricId", level.RubricId);
                    insertCommand.Parameters.AddWithValue("@details", level.Details);
                    insertCommand.Parameters.AddWithValue("@measurementLevel", level.MeasurementLevel);


                    insertCommand.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return false;
            }
        }
            public static void UpdateCloDateUpdated(int cloId, DateTime updatedDateTime)
            {
               updatedDateTime=new DateTime(updatedDateTime.Year,updatedDateTime.Month,updatedDateTime.Day,updatedDateTime.Hour,updatedDateTime.Minute,0);
                using (SqlConnection connection = new SqlConnection(SqlConnectionString))
                {
                    connection.Open();

                    try
                    {
                        string updateQuery = "UPDATE Clo SET DateUpdated = @updatedDateTime WHERE Id = @cloId";
                        SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                        updateCommand.Parameters.AddWithValue("@cloId", cloId);
                        updateCommand.Parameters.AddWithValue("@updatedDateTime", updatedDateTime);

                        updateCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }


        public static List<string> GetAllCloNames()
        {
            List<string> cloNames = new List<string>();

            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
            {
                connection.Open();

                string query = "SELECT Name FROM Clo";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string cloName = reader["Name"].ToString();
                            cloNames.Add(cloName);
                        }
                    }
                }
            }

            return cloNames;
        }









    }
}
