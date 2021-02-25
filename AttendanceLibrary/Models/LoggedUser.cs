using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttendanceLibrary.PasswordProcessing;

namespace AttendanceLibrary.Models
{
    public class LoggedUser : ILoginInfo
    {
        public string Login { get; set; }
        public string OriginalPassword { get; set; }
        public string CryptedPassword { get; set; }
        public string Salt { get; set; }
    }
}
