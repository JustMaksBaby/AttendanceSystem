using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceLibrary.Models
{
    public class Student
    {
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public string Patronymic { get; set; }
       public int CardId { get; set; }
       public string RalatedGroup { get; set; }
       public string FullName { get; set; }
    }
}
