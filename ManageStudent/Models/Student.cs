using System;

namespace StudentManagement.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Major { get; set; }
        public double GPA { get; set; }
    }
}
