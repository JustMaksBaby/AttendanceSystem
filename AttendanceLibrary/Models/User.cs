using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using AttendanceLibrary.PasswordProcessing;

namespace AttendanceLibrary.Models
{
    public class User : IPasswordInfo
    {
        public string Name { get; set; }
        public string OriginalPassword { get; set; }
        public string HashedPassword { get; set; }
        public string Salt { get; set; } 
    }
}
