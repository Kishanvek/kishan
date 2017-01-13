using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace contoso02.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstMidName { get; set; }
        public String LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}