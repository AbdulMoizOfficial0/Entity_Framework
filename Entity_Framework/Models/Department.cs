using System;
using System.Collections.Generic;


namespace Entity_Framework.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public required string Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
        public int InstructorId { get; set; }
        public required Instructor Administrator { get; set; }

    }
}
