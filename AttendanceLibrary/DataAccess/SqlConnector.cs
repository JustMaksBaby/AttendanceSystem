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
        private  static readonly string _db = "AttendanceDb"; //database  connect to
        private  readonly string _dbConnectionStr =  ConfigurationManager.ConnectionStrings[_db]?.ConnectionString;
        private  ISqlConnector _connector; 
        
        public SqlConnector(ISqlConnector connector)
        {
            _connector = connector;
        } 

        /// <summary>
        /// This method shoud be used to check a connection to db server
        /// </summary>
        public (bool,Exception)  TestConnection()
        {
            using (IDbConnection connection = _connector.CreateConnection(_dbConnectionStr))
            {
                try
                {
                    connection.Open();
                } 
                catch(System.InvalidOperationException ex)
                {
                    return (false, ex);
                }
                catch(System.Data.Common.DbException ex)
                {
                    return (false, ex);
                }
            }

            return (true, null); 
        }

        public bool UserExists(string login)
        {
            int usersInDb = 0;

            using (IDbConnection connection = _connector.CreateConnection(_dbConnectionStr))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Login", login); 
                usersInDb = connection.ExecuteScalar<int>("dbo.spCheckUserExist", p, commandType: CommandType.StoredProcedure);
            }
            return usersInDb > 0;
        }
        public bool TeacherExists(string firstName, string lastName)
        {
            int teachersInDb = 0;

            using (IDbConnection connection = _connector.CreateConnection(_dbConnectionStr))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@FirstName", firstName);
                p.Add("@LastName", lastName);

                teachersInDb = connection.ExecuteScalar<int>("dbo.spCheckTeacherByFirstLastName", p, commandType: CommandType.StoredProcedure);
            }

            return teachersInDb > 0; 
        }
        public bool GroupExists(string groupName)
        {
            int groupsInDb = 0;

            using (IDbConnection connection = _connector.CreateConnection(_dbConnectionStr))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Name", groupName);

                groupsInDb = connection.ExecuteScalar<int>("dbo.spCheckGroupExists", p, commandType: CommandType.StoredProcedure);
            }
            
            
            return groupsInDb > 0;
        }
        public bool LessonExists(string lessonName)
        {
            int lessonsInDb = 0;

            using (IDbConnection connection = _connector.CreateConnection(_dbConnectionStr))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Name", lessonName);

                lessonsInDb = connection.ExecuteScalar<int>("dbo.spCheckLessonExists", p, commandType: CommandType.StoredProcedure);
            }
            
            return lessonsInDb > 0; 
        }
    //
        public void AddUser(ILoginInfo  loginInfo, Teacher teacher)
        {
            using (IDbConnection connection = _connector.CreateConnection(_dbConnectionStr))
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
        public int AddTeacher(Teacher teacher)
        {
            int id = -1;

            using (IDbConnection connection = _connector.CreateConnection(_dbConnectionStr))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Id", dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@FirstName", teacher.FirstName);
                p.Add("@LastName", teacher.LastName);
                p.Add("@Patronymic", teacher.Patronymic);
                p.Add("@SystemStatus", teacher.SystemStatus);

                connection.Execute("dbo.spAddTeacher", p, commandType: CommandType.StoredProcedure);

                id = p.Get<int>("@Id");
            }
            return id;
        }
        public void  AddGroup(Group group)
        {
            using (IDbConnection connection = _connector.CreateConnection(_dbConnectionStr))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Name", group.Name);
                p.Add("@CuratorId", group.CuratorId);

                connection.Execute("dbo.spAddGroup", p, commandType: CommandType.StoredProcedure);
            }
        }
        public void AddStudent(Student student)
        {
            using (IDbConnection connection = _connector.CreateConnection(_dbConnectionStr))
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
        public void AddLesson(Lesson lesson)
        {
            using (IDbConnection connection = _connector.CreateConnection(_dbConnectionStr))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Name", lesson.Name);

                connection.Execute("dbo.spAddLesson", p, commandType: CommandType.StoredProcedure); 
            }
        }
        public void AddAttendanceInfo(List<AttendanceInfo>  records)
        {
            using (IDbConnection connection = _connector.CreateConnection(_dbConnectionStr))
            {
                foreach(AttendanceInfo record in records)
                {
                    var parameters = new { Date = record.Date, StudentId = record.StudentId, 
                                         Lesson = record.Lesson, Status = record.Status }; 
                    connection.Execute("spAddAttendanceInfo", parameters, commandType: CommandType.StoredProcedure); 
                }
            }
        }

    //
        public LoggedUser GetLoginInfo(string login)
        {
            LoggedUser output = null; 

            if (UserExists(login))
            {
                using (IDbConnection connection = _connector.CreateConnection(_dbConnectionStr))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@Login",  login);

                    output = connection.Query<LoggedUser>("dbo.spGetLoginInfo", p, commandType: CommandType.StoredProcedure).First();
                }
            }

            return output;
        }
        public Teacher GetTeacherByLogin(string login)
        {
            Teacher output = null;
          
            if (UserExists(login))
            {
                using (IDbConnection connection = _connector.CreateConnection(_dbConnectionStr))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@Login", login);
                    
                    
                    output = connection.Query<Teacher>("dbo.spGetTeacherByLogin", p, commandType: CommandType.StoredProcedure).FirstOrDefault(); 
                }
            }

            return output; 
        }
        public Teacher[] GetAllTeachers()
        {
            Teacher[] teachers = null;
            using (IDbConnection connection = _connector.CreateConnection(_dbConnectionStr))
            {
                teachers = connection.Query<Teacher>("dbo.spGetAllTeachers", commandType: CommandType.StoredProcedure).ToArray(); 
            }

            return teachers; 
        }
        public Group[] GetAllGroups()
        {
            Group[] groups = null;

            using (IDbConnection connection = _connector.CreateConnection(_dbConnectionStr))
            {   
                groups = connection.Query<Group>("dbo.spGetAllGroups", commandType: CommandType.StoredProcedure).ToArray();     
            }

            return groups; 
        }
        public Lesson[] GetAllLessons()
        {
            Lesson[] output = null;

            using (IDbConnection connection = _connector.CreateConnection(_dbConnectionStr))
            {
                output = connection.Query<Lesson>("dbo.spGetAllLessons", commandType: CommandType.StoredProcedure).ToArray(); 
            }

            return output;  
        }
        public AttendanceInfo[] GetStudentsAttendance(string group,string lesson, string date)
        {
            AttendanceInfo[] output = null;
            using (IDbConnection connection = _connector.CreateConnection(_dbConnectionStr))
            {
                var parameters = new { GroupName = group, LessonName = lesson, Date = date };
                output = connection.Query<AttendanceInfo>("spGetStudentsAttendanceStatusBy_Group_Lesson_Date", parameters, commandType: CommandType.StoredProcedure).ToArray(); 

            }
            return output; 
        }
        
    /// <summary>
    /// 
    /// </summary>
    /// <param name="groupName"></param>
    /// <returns>Returns stunets in alphabetic order by name</returns>
        public Student[] GetStudensByGroup(string groupName)
        {
            Student[] students = null; 

            using (IDbConnection connection = _connector.CreateConnection(_dbConnectionStr))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@GroupName", groupName); 
                students = connection.Query<Student>("spGetStudentsByGroup", p, commandType: CommandType.StoredProcedure).ToArray();  
            }

            return students; 
        }
    }
}
