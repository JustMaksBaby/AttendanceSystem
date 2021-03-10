using System;
using Dapper;
using System.Data;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;
using AttendanceLibrary.Models;
using System.Collections.Generic;
using AttendanceLibrary.PasswordProcessing;
using System.Data.Common;

namespace AttendanceLibrary.DataAccess
{
    public class SqlConnector
    {
        private static readonly string _db = "AttandanceDb"; //database  connect to
        private static readonly string _dbConnectionStr = ConfigurationManager.ConnectionStrings[_db].ConnectionString;


        public static bool UserExists(string login)
        {
            int usersInDb = 0; 

            using (SqlConnection connection = new SqlConnection(_dbConnectionStr))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Login", login);

                usersInDb = connection.ExecuteScalar<int>("dbo.spCheckUserExist", p, commandType: CommandType.StoredProcedure);

            }
            
            return usersInDb > 0;
        }
        public static bool TeacherExists(string firstName, string lastName)
        {
            int teachersInDb = 0;  

            using(SqlConnection connection = new SqlConnection(_dbConnectionStr))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@FirstName", firstName);
                p.Add("@LastName", lastName);

                teachersInDb = connection.ExecuteScalar<int>("dbo.spCheckTeacherByFirstLastName", p, commandType:CommandType.StoredProcedure);
            }
            return teachersInDb > 0; 
        }
        public static bool GroupExists(string groupName)
        {
            int groupsInDb = 0; 
            using(SqlConnection connection = new SqlConnection(_dbConnectionStr))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Name", groupName);

                groupsInDb = connection.ExecuteScalar<int>("dbo.spCheckGroupExists", p, commandType: CommandType.StoredProcedure);
            }

            return groupsInDb > 0;
        }
        public static bool LessonExists(string lessonName)
        {
            int lessonsInDb = 0; 
            using(SqlConnection connection = new SqlConnection (_dbConnectionStr))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Name", lessonName);

                lessonsInDb = connection.ExecuteScalar<int>("dbo.spCheckLessonExists", p, commandType: CommandType.StoredProcedure); 
            }

            return lessonsInDb > 0; 
        }
    //
        public static void AddUser(ILoginInfo  loginInfo, Teacher teacher)
        {

            using (SqlConnection connection = new SqlConnection(_dbConnectionStr))
            {
                DynamicParameters p = new DynamicParameters();

                p.Add("@Login", loginInfo.Login);
                p.Add("@Password", loginInfo.CryptedPassword);
                p.Add("@Salt", loginInfo.Salt);
                p.Add("@UserId", AddTeacher(teacher)); 

                connection.Execute("dbo.spAddLoginInfo", p, commandType: CommandType.StoredProcedure);
            }

        } 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="teacher"></param>
        /// <returns>returns id for added row</returns>
        public static int AddTeacher(Teacher teacher)
        {
            int id = -1;  

            using(SqlConnection connection = new SqlConnection(_dbConnectionStr))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Id", dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@FirstName", teacher.FirstName);
                p.Add("@LastName", teacher.LastName);
                p.Add("@Patronymic",teacher.Patronymic);
                p.Add("@SystemStatus", teacher.SystemStatus); 

                connection.Execute("dbo.spAddTeacher", p, commandType: CommandType.StoredProcedure);

                id = p.Get<int>("@Id"); 
            }

            return id;
        }
        public static void  AddGroup(Group group)
        {
            using(SqlConnection connection = new SqlConnection(_dbConnectionStr))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Name", group.Name);
                p.Add("@CuratorId", group.CuratorId);

                connection.Execute("dbo.spAddGroup", p, commandType: CommandType.StoredProcedure);
            }
        }
        public static void AddStudent(Student student)
        {
            using (SqlConnection connection = new SqlConnection(_dbConnectionStr) )
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@FirstName", student.FirstName); 
                p.Add("@LastName", student.LastName); 
                p.Add("@Patronymic", student.Patronymic); 
                p.Add("@CardId", student.CardId);
                p.Add("@GroupName", student.RalatedGroup);

                connection.Execute("dbo.spAddStudent", p, commandType: CommandType.StoredProcedure); 
            }
        }
        public static void AddLesson(Lesson lesson)
        {
            using(SqlConnection connection = new SqlConnection(_dbConnectionStr))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Name", lesson.Name);

                connection.Execute("dbo.spAddLesson", p, commandType: CommandType.StoredProcedure); 
            }
        }
        public static void AddAttendanceInfo(List<AttendanceInfo>  records)
        {
            using(SqlConnection connector = new SqlConnection(_dbConnectionStr))
            {
                foreach(AttendanceInfo record in records)
                {
                    var parameters = new { Date = record.Date, StudentId = record.StudentId, 
                                         Lesson = record.Lesson, Status = record.Status }; 
                    connector.Execute("spAddAttendanceInfo", parameters, commandType: CommandType.StoredProcedure); 
                }
            }
        }

    //
        public static LoggedUser GetLoginInfo(string login)
        {
            LoggedUser output = null; 

            if (UserExists(login))
            {
                using (SqlConnection connection = new SqlConnection(_dbConnectionStr))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@Login",  login);

                    output = connection.Query<LoggedUser>("dbo.spGetLoginInfo", p, commandType: CommandType.StoredProcedure).First();
                }
            }

            return output;
        }
        public static Teacher GetTeacherByLogin(string login)
        {
            Teacher output = null;
          
            if (UserExists(login))
            {
                using (SqlConnection connection = new SqlConnection(_dbConnectionStr))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@Login", login);
                    
                    //TODO test if there is no teacher
                    output = connection.Query<Teacher>("dbo.spGetTeacherByLogin", p, commandType: CommandType.StoredProcedure).FirstOrDefault(); 
                }
            }

            return output; 
        }
        public static Teacher[] GetAllTeachers()
        {
            Teacher[] teachers = null;
            using (SqlConnection connection = new SqlConnection(_dbConnectionStr) )
            {
                teachers = connection.Query<Teacher>("dbo.spGetAllTeachers", commandType: CommandType.StoredProcedure).ToArray(); 
            }

            return teachers; 
        }
        public static Group[] GetAllGroups()
        {
            Group[] groups = null; 

            using(SqlConnection connection = new SqlConnection(_dbConnectionStr) )
            {
                groups = connection.Query<Group>("dbo.spGetAllGroups", commandType: CommandType.StoredProcedure).ToArray();     
            }

            return groups; 
        }
        public static Lesson[] GetAllLessons()
        {
            Lesson[] output = null; 

            using(SqlConnection connection = new SqlConnection(_dbConnectionStr) )
            {
                output = connection.Query<Lesson>("dbo.spGetAllLessons", commandType: CommandType.StoredProcedure).ToArray(); 
            }

            return output;  
        }
        
    //
        public static Student[] GetStudensByGroup(string groupName)
        {
            Student[] students = null; 

            using (SqlConnection connection = new SqlConnection(_dbConnectionStr))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@GroupName", groupName); 
                students = connection.Query<Student>("spGetStudentsByGroup", p, commandType: CommandType.StoredProcedure).ToArray();  
            }

            return students; 
        }
    }
}
