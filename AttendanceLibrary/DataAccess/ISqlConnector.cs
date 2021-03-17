using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; 

namespace AttendanceLibrary.DataAccess
{
    public interface ISqlConnector
    {
        IDbConnection CreateConnection(string connectionString); 
    }
}
