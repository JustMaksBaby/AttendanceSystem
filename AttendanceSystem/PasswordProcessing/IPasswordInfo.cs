using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.PasswordProcessing
{
    public interface IPasswordInfo
    {
        string OriginalPassword { get;  set; } 
        string HashedPassword { get; set; }
        string Salt { get; set; }


    }
}
