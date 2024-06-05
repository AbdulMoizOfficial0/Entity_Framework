using System;
using System.Collections.Generic;

namespace Entity_Framework.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public required string Title { get; set; }
        public int Credits { get; set; }
        public required ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
        public int InstructorId { get; set; }
        public required Instructor Instructor { get; set; }
    }
}
