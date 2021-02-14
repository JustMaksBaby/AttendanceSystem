using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttendanceSystem.PasswordProcessing;

namespace AttendanceSystem
{
    public class User : IPasswordInfo
    {
        public string Name { get; set; }
        public string OriginalPassword { get; set; } 
        public string HashedPassword { get; set; }
        public string Salt { get; set; }
    }
}
