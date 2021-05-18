using MappingDemo.Abstractions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MappingDemo.Models
{
    public class Student : IDbModel
    {
        public string Name { get; set; }
        
        public List<Mark> Marks { get; set; }

        public List<Mark> LoadMarks() => ICrudable.GetAll<Mark>(x => x.StudentId == Id).ToList();
        
    }
}
