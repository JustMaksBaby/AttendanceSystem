using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.PasswordGeneration
{
    public interface IPasswordInfo
    {
        string OriginalPassword { get;  set; } 
        string HashedPassword { get; set; }
        int Salt { get; set; }


    }
}
