using System;
using System.Collections.Generic;

namespace Entity_Framework.Models
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public DateTime HireDate { get; set; }
        public required ICollection<Course> Courses { get; set; } = new List<Course>();

    }
}
