﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace AttendanceSystem.DataAccess
{
    public class SqlCon
    {
        private static readonly string _db = "AttandanceDb"; //database  connect to
        private static readonly string _dbConnectionStr = ConfigurationManager.ConnectionStrings[_db].ConnectionString;

        /// <summary>
        /// Checks if the user with certain name already exists in the DB
        /// </summary> 
        public static bool UserExists(User user)
        {
            using (SqlConnection connection = new SqlConnection(_dbConnectionStr))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Name", user.Name);

                int usersInDb = connection.ExecuteScalar<int>("dbo.spCheckUserByName", p, commandType: CommandType.StoredProcedure);

                return usersInDb > 0;
            }
        }
        public static bool AddUser(User user)
        {
            if (!UserExists(user)) // if user name is  available
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
        public static bool GetUser(User user)
        {
            if (UserExists(user))
            {
                using (SqlConnection connection = new SqlConnection(_dbConnectionStr))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@Name", user.Name);

                    user = connection.Query<User>("dbo.spGetUserByName", p, commandType: CommandType.StoredProcedure).First();
                }

                return true;
            }
            else return false;
        }

    }
}
