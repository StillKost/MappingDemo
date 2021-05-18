using System;
using System.Collections.Generic;
using System.Text;

namespace MappingDemo.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Duration { get; set; }

        public List<Mark> Marks { get; set; }
    }
}
