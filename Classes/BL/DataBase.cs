using MidProjectEven.Classes;
using MidProjectEven.Classes.BL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
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
        public static string GetStatusName(int statusId)
        {
            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
            {
                try
                {
                    string query = "SELECT Name FROM Lookup WHERE LookupId = @id AND Category = 'ATTENDANCE_STATUS'";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", statusId);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result == null)
                    {
                        return null;
                    }

                    return result.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return  null;
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
        public static List<string> GetStudentNamesByStatus(int status = 5)
        {
            List<string> studentNames = new List<string>();

            using (SqlConnection connection = new SqlConnection(DataBase.SqlConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT CONCAT(FirstName, ' ', LastName) AS StudentName FROM Student WHERE Status = @status";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@status", status);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string studentName = reader["StudentName"].ToString();
                        studentNames.Add(studentName);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return studentNames;
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
        public static int GetCloId(string name)
        {
            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
            {
                connection.Open();

                try
                {
                    string query = "SELECT Id FROM Clo WHERE Name = @name";
                    SqlCommand sqlCommand = new SqlCommand(query, connection);
                    sqlCommand.Parameters.AddWithValue("@name", name);

                   
                    object result = sqlCommand.ExecuteScalar();

                    return result != null ? Convert.ToInt32(result) : -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
             
                    return -1;
                }
            }
        }
        public static List<Rubric> GetRubricsForClo(int cloId)
        {
            List<Rubric> rubricList = new List<Rubric>();

            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
            {
                connection.Open();

                try
                {
                    string query = "SELECT Id, Details, CloId FROM Rubric WHERE CloId = @cloId";
                    SqlCommand sqlCommand = new SqlCommand(query, connection);
                    sqlCommand.Parameters.AddWithValue("@cloId", cloId);

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["Id"]);
                            string details = reader["Details"].ToString();
                            int associatedCloId = Convert.ToInt32(reader["CloId"]);

                            Rubric rubric = new Rubric(id, details, associatedCloId);

                            rubricList.Add(rubric);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
             
                }
            }

            return rubricList;
        }
        public static List<RubricLevel> GetRubricLevels(int rubricId)
        {
            List<RubricLevel> rubricLevels = new List<RubricLevel>();

            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
            {
                connection.Open();

                try
                {
                    string query = "SELECT * FROM RubricLevel WHERE RubricId = @rubricId";
                    SqlCommand sqlCommand = new SqlCommand(query, connection);
                    sqlCommand.Parameters.AddWithValue("@rubricId", rubricId);

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["Id"]);
                        string details = reader["Details"].ToString();
                        int measurementLevel = Convert.ToInt32(reader["MeasurementLevel"]);

                        RubricLevel rubricLevel = new RubricLevel(rubricId, details, measurementLevel);
                        rubricLevels.Add(rubricLevel);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return rubricLevels;
        }


        public static bool DoesRubricHaveLevelWithMeasurement(int rubricId, int measurementLevel)
        {
            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
            {
                connection.Open();

                try
                {
                    string query = "SELECT COUNT(*) FROM RubricLevel WHERE RubricId = @rubricId AND MeasurementLevel = @measurementLevel";
                    SqlCommand sqlCommand = new SqlCommand(query, connection);
                    sqlCommand.Parameters.AddWithValue("@rubricId", rubricId);
                    sqlCommand.Parameters.AddWithValue("@measurementLevel", measurementLevel);

                    int count = Convert.ToInt32(sqlCommand.ExecuteScalar());


                    return count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }
        public static bool AddAssessment(Assessment assessment)
        {
            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
            {
                connection.Open();

                try
                {
               
                    string checkQuery = "SELECT COUNT(*) FROM Assessment WHERE Title = @title";
                    SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                    checkCommand.Parameters.AddWithValue("@title", assessment.Title);

                    int existingCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (existingCount > 0)
                    {
         
                        MessageBox.Show("Assessment with the same title already exists.");
                        return false;
                    }

                    string insertQuery = "INSERT INTO Assessment (Title, DateCreated, TotalMarks, TotalWeightage) " +
                                         "VALUES (@title, @dateCreated, @totalMarks, @totalWeightage)";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@title", assessment.Title);
                    insertCommand.Parameters.AddWithValue("@dateCreated", assessment.DateCreated);
                    insertCommand.Parameters.AddWithValue("@totalMarks", assessment.TotalMarks);
                    insertCommand.Parameters.AddWithValue("@totalWeightage", assessment.TotalWeightage);

                    insertCommand.ExecuteNonQuery();

                    MessageBox.Show("Assessment added successfully.");
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }
        public static List<Assessment> GetAllAssessments()
        {
            List<Assessment> assessments = new List<Assessment>();

            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
            {
                connection.Open();

                try
                {
                    string query = "SELECT Title, DateCreated, TotalMarks, TotalWeightage FROM Assessment";
                    SqlCommand command = new SqlCommand(query, connection);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            string Title = Convert.ToString(reader["Title"]);
                            DateTime DateCreated = Convert.ToDateTime(reader["DateCreated"]);
                            int TotalMarks = Convert.ToInt32(reader["TotalMarks"]);
                            int TotalWeightage = Convert.ToInt32(reader["TotalWeightage"]);
                            Assessment assessment = new Assessment(Title, DateCreated, TotalMarks, TotalMarks);
                            assessments.Add(assessment);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return assessments;
        }
        public static bool EditAssessment(Assessment assessment)
        {
            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
            {
                connection.Open();

                try
                {
            
                    string checkQuery = "SELECT COUNT(*) FROM Assessment WHERE Title = @title";
                    SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                    checkCommand.Parameters.AddWithValue("@title", assessment.Title);

                    int existingCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (existingCount == 0)
                    {
                        MessageBox.Show($"Assessment with the title '{assessment.Title}' does not exist If you want to add it click on Add Button.");
                        return false;
                    }

                  
                    string updateQuery = "UPDATE Assessment SET DateCreated = @dateCreated, TotalMarks = @totalMarks, TotalWeightage = @totalWeightage " +
                                         "WHERE Title = @title";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@title", assessment.Title);
                    updateCommand.Parameters.AddWithValue("@dateCreated", assessment.DateCreated);
                    updateCommand.Parameters.AddWithValue("@totalMarks", assessment.TotalMarks);
                    updateCommand.Parameters.AddWithValue("@totalWeightage", assessment.TotalWeightage);

                    updateCommand.ExecuteNonQuery();

                    MessageBox.Show($"Assessment '{assessment.Title}' updated successfully.");
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }
        public static List<string> GetAllAssessmentTitles()
        {
            List<string> titles = new List<string>();

            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
            {
                connection.Open();

                try
                {
                    string query = "SELECT Title FROM Assessment";
                    SqlCommand command = new SqlCommand(query, connection);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string title = Convert.ToString(reader["Title"]);
                            titles.Add(title);
                        }
                    }

                    return titles;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return titles; 
                }
            }
        }

        public static List<string> GetRubricDetails()
        {
            List<string> rubricDetails = new List<string>();

            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
            {
                connection.Open();

                try
                {
                    string query = "SELECT Details FROM Rubric";
                    SqlCommand sqlCommand = new SqlCommand(query, connection);

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        string details = reader["Details"].ToString();
                        rubricDetails.Add(details);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return rubricDetails;
        }

        public static int GetAssessmentId(string assessmentTitle)
        {
            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
            {
                connection.Open();

                try
                {
                    string query = "SELECT Id FROM Assessment WHERE Title = @title";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@title", assessmentTitle);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("Assessment not found.");
                        return -1; 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return -1; 
                }
            }
        }
        public static int GetRubricId(string rubricdetail)
        {
            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
            {
                connection.Open();

                try
                {
                    string query = "SELECT Id FROM Rubric WHERE details = @title";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@title", rubricdetail);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("Rubric not found.");
                        return -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return -1; 
                }
            }
        }

        public static bool AddAssessmentComponent(AssessmentComponent component)
        {
            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
            {
                connection.Open();
                try
                {
             
                    string checkQuery = "SELECT COUNT(*) FROM AssessmentComponent WHERE Name = @name AND RubricId = @rubricId AND AssessmentId = @assessmentId";
                    SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                    checkCommand.Parameters.AddWithValue("@name", component.Name);
                    checkCommand.Parameters.AddWithValue("@rubricId", component.RubricId);
                    checkCommand.Parameters.AddWithValue("@assessmentId", component.AssessmentId);

                    int existingCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (existingCount == 0)
                    {
        
                        string insertQuery = "INSERT INTO AssessmentComponent (Name, RubricId, TotalMarks, DateCreated, DateUpdated, AssessmentId) " +
                                             "VALUES (@name, @rubricId, @totalMarks, @dateCreated, @dateUpdated, @assessmentId)";
                        SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                        insertCommand.Parameters.AddWithValue("@name", component.Name);
                        insertCommand.Parameters.AddWithValue("@rubricId", component.RubricId);
                        insertCommand.Parameters.AddWithValue("@totalMarks", component.TotalMarks);
                        insertCommand.Parameters.AddWithValue("@dateCreated", component.DateCreated);
                        insertCommand.Parameters.AddWithValue("@dateUpdated", component.DateUpdated);
                        insertCommand.Parameters.AddWithValue("@assessmentId", component.AssessmentId);

                        insertCommand.ExecuteNonQuery();

                        MessageBox.Show("Assessment component added successfully.");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Assessment component with the same name, rubricId, and assessmentId already exists.");
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
        public static bool EditAssessmentComponent(AssessmentComponent component)
        {
            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
            {
                connection.Open();
                try
                {
              
                    string checkQuery = "SELECT COUNT(*) FROM AssessmentComponent WHERE Name = @name AND RubricId = @rubricId AND AssessmentId = @assessmentId";
                    SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                    checkCommand.Parameters.AddWithValue("@name", component.Name);
                    checkCommand.Parameters.AddWithValue("@rubricId", component.RubricId);
                    checkCommand.Parameters.AddWithValue("@assessmentId", component.AssessmentId);

                    int existingCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (existingCount > 0)
                    {
                     
                        string updateQuery = "UPDATE AssessmentComponent SET TotalMarks = @totalMarks, DateUpdated = @dateUpdated " +
                                             "WHERE Name = @name AND RubricId = @rubricId AND AssessmentId = @assessmentId";
                        SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                        updateCommand.Parameters.AddWithValue("@totalMarks", component.TotalMarks);
                        updateCommand.Parameters.AddWithValue("@dateUpdated", component.DateUpdated);
                        updateCommand.Parameters.AddWithValue("@name", component.Name);
                        updateCommand.Parameters.AddWithValue("@rubricId", component.RubricId);
                        updateCommand.Parameters.AddWithValue("@assessmentId", component.AssessmentId);

                        updateCommand.ExecuteNonQuery();

                        MessageBox.Show("Assessment component updated successfully.");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Assessment component with the specified name, rubricId, and assessmentId does not exist.");
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
        public static List<AssessmentComponent> GetAllAssessmentComponents()
        {
            List<AssessmentComponent> assessmentComponents = new List<AssessmentComponent>();

            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
            {
                connection.Open();

                try
                {
                    string query = "SELECT * FROM AssessmentComponent";
                    SqlCommand sqlCommand = new SqlCommand(query, connection);

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        string name = reader["Name"].ToString();
                        int rubricId = Convert.ToInt32(reader["RubricId"]);
                        int totalMarks = Convert.ToInt32(reader["TotalMarks"]);
                        DateTime dateCreated = Convert.ToDateTime(reader["DateCreated"]);
                        DateTime dateUpdated = Convert.ToDateTime(reader["DateUpdated"]);
                        int assessmentId = Convert.ToInt32(reader["AssessmentId"]);

                        AssessmentComponent assessmentComponent = new AssessmentComponent(name, rubricId, totalMarks, dateCreated, dateUpdated, assessmentId);
                        assessmentComponents.Add(assessmentComponent);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return assessmentComponents;
        }
        public static List<string> GetAllAssessmentComponentNames()
        {
            List<string> assessmentComponentNames = new List<string>();

            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
            {
                connection.Open();

                try
                {
                    string query = "SELECT Name FROM AssessmentComponent";
                    SqlCommand sqlCommand = new SqlCommand(query, connection);

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        string name = reader["Name"].ToString();
                        assessmentComponentNames.Add(name);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return assessmentComponentNames;
        }
        public static List<string> GetAllRubricDetails()
        {
            List<string> rubricDetailsList = new List<string>();

            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
            {
                connection.Open();

                try
                {
                    string query = "SELECT Details FROM RubricLevel";
                    SqlCommand sqlCommand = new SqlCommand(query, connection);

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        string details = reader["Details"].ToString();
                        rubricDetailsList.Add(details);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return rubricDetailsList;
        }

        public static int GetStudentId2(string studentName)
        {
            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT StudentId FROM Student WHERE CONCAT(FirstName, ' ', LastName) = @studentName";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@studentName", studentName);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return -1; 
        }

        public static int GetComponentId(string componentName)
        {
            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT ComponentId FROM AssessmentComponent WHERE Name = @componentName";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@componentName", componentName);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return -1;
        }
        public static int GetRubricLevelId(string rubricDetail)
        {
            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT Id FROM RubricLevel WHERE Details = @rubricDetail";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@rubricDetail", rubricDetail);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return -1;
        }
        public static void AddStudentResult(StudentResult studentResult)
        {
            using (SqlConnection connection = new SqlConnection(SqlConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO StudentResult (StudentId, ComponentId, RubricLevelId, Date) " +
                                   "VALUES (@studentId, @componentId, @rubricLevelId, @date)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@studentId", studentResult.StudentId);
                    command.Parameters.AddWithValue("@componentId", studentResult.AssessmentComponentId);
                    command.Parameters.AddWithValue("@rubricLevelId", studentResult.RubricMeasurementId);
                    command.Parameters.AddWithValue("@date", studentResult.EvaluationDate);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }








    }
}
