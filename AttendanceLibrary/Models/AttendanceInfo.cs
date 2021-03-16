using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceLibrary.Models
{
    public class AttendanceInfo
    {
        public int Id { get; set; } 
        public string  Date { get; set; }
        public int StudentId { get; set; }
        public string Lesson { get; set; }
        public string Status { get; set; }

        public string StudentFullName { get; set; }
    }
}
