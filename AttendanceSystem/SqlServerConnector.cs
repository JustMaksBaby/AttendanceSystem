using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttendanceLibrary.DataAccess;
using System.Data.SqlClient; 

namespace AttendanceSystem
{
    public class SqlServerConnector : ISqlConnector
    {
        public IDbConnection CreateConnection(string connectionString)
        {
            return new SqlConnection(connectionString);
        }
    }
}
