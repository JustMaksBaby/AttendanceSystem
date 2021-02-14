using System;
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
    public static class SqlConnector
    {
        /// <summary>
        /// Checks if the user with certain name already exists in the DB
        /// </summary>
        public static bool UserExists(string userName, string databaseName)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[databaseName].ConnectionString))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Name", userName);

                int usersInDb = connection.ExecuteScalar<int>("dbo.spCheckUserByName", p, commandType: CommandType.StoredProcedure);

                return usersInDb > 0; 
            }
        }
         
    }
}
