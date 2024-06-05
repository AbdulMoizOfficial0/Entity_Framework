using System;
using System.Collections.Generic;

namespace Entity_Framework.Models
{
    public class Enrollment
    {
        public int EnrollmentId {  get; set; }
        public int CourseId { get; set; }
        public required Course Course { get; set; }
        public int StudentId { get; set; }
        public required Student Student { get; set; }
        public int Grade { get; set; }
    }
}
