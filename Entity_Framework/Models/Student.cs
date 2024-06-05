using System;
using System.Collections.Generic;

namespace Entity_Framework.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public required string FirstName { get; set;}
        public required string LastName { get; set;}
        public DateTime DateOfBirth { get; set;}
        public required ICollection<Enrollment> Enrollments { get; set;}
    }
}
