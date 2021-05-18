using System;
using System.Collections.Generic;
using System.Text;

namespace MappingDemo.Models
{
    public class Mark
    {
        public int Id { get; set; }
        public int LessonId { get; set; }
        public int StudentId { get; set; }
        public int Points { get; set; }
        public Student Student { get; set; }
        public Lesson Lesson { get; set; }
    }
}
