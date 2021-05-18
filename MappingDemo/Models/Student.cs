using System;
using System.Collections.Generic;
using System.Text;

namespace MappingDemo.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Mark> Marks { get; set; }
    }
}
