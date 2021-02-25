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
namespace AttendanceLibrary.DataAccess
{
    public class SqlConnector
    {
        private static readonly string _db = "AttandanceDb"; //database  connect to
        private static readonly string _dbConnectionStr = ConfigurationManager.ConnectionStrings[_db].ConnectionString;


        public static bool UserExists(string login)
        {
            using (SqlConnection connection = new SqlConnection(_dbConnectionStr))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Login", login);

                int usersInDb = connection.ExecuteScalar<int>("dbo.spCheckUserExist", p, commandType: CommandType.StoredProcedure);

                return usersInDb > 0;
            }
        }
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
        public static int AddTeacher(Teacher teacher)
        {
            //TODO check what will if there is no connection to database
            int output = -1;  

            using(SqlConnection connection = new SqlConnection(_dbConnectionStr))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Id", dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@FirstName", teacher.FirstName);
                p.Add("@LastName", teacher.LastName);
                p.Add("@Patronymic",teacher.Patronymic);
                p.Add("@SystemStatus", teacher.SystemStatus); 

                connection.Execute("dbo.spAddTeacher", p, commandType: CommandType.StoredProcedure);

                output = p.Get<int>("@Id"); 
            }

            return output;
        }
        public static bool TeacherExists(string firstName, string lastName)
        {
            int teachers = 0;  

            using(SqlConnection connection = new SqlConnection(_dbConnectionStr))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@FirstName", firstName);
                p.Add("@LastName", lastName);

                teachers = connection.ExecuteScalar<int>("dbo.spCheckTeacherByFirstLastName", p, commandType:CommandType.StoredProcedure);
            }
            return teachers != 0; 
        }
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
                    output = connection.Query<Teacher>("dbo.GetTeacherByLogin", p, commandType: CommandType.StoredProcedure).First();
                }
            }

            return output; 
        }

    }
}
