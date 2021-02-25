using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceLibrary.PasswordProcessing
{
    public interface ILoginInfo
    {
        string Login { get; set; }
        string OriginalPassword { get;  set; }  // password gotten from a user
        string CryptedPassword { get; set; }    // crypted password + salt 
        string Salt { get; set; }

    }
}
