using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttendanceLibrary.PasswordProcessing;

namespace AttendanceLibrary.Models
{
    public class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string SystemStatus { get; set; } // admin or limited
    }
}
