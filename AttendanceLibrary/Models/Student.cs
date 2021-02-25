using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceLibrary.Models
{
    class Student
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Patronymic { get; set; }
        int CardId { get; set; }
        Group RalatedGroup { get; set; }
    }
}
