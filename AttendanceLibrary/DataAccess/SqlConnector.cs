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

namespace AttendanceLibrary.DataAccess
{
    public class SqlConnector
    {
        private static readonly string _db = "AttandanceDb"; //database  connect to
        private static readonly string _dbConnectionStr = ConfigurationManager.ConnectionStrings[_db].ConnectionString;


        /// <summary>
        /// Checks if the user with certain name already exists in the DB
        /// </summary> 
        public static bool UserExists(string userName)
        {
            using (SqlConnection connection = new SqlConnection(_dbConnectionStr))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Name", userName);

                int usersInDb = connection.ExecuteScalar<int>("dbo.spCheckUserByName", p, commandType: CommandType.StoredProcedure);

                return usersInDb > 0;
            }
        }
        public static bool AddUser(User user)
        {
            if (!UserExists(user.Name)) // if user name is  available
            {
                using (SqlConnection connection = new SqlConnection(_dbConnectionStr))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@Name", user.Name);
                    p.Add("@Password", user.HashedPassword);
                    p.Add("@Salt", user.Salt);

                    connection.Execute("dbo.spAddUser", p, commandType: CommandType.StoredProcedure);
                }
                return true;
            }
            else return false;

        }
        /// <summary>
        /// Gets a user by name
        /// </summary>
        public static User GetUserByName(string userName)
        {
            User output = null;
            if (UserExists(userName))
            {
                using (SqlConnection connection = new SqlConnection(_dbConnectionStr))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@Name",  userName);

                    output = connection.Query<User>("dbo.spGetUserByName", p, commandType: CommandType.StoredProcedure).First();
                }
            }

            return output;
        }

    }
}
