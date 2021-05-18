using MappingDemo.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MappingDemo.ViewModels
{
    /// <summary>
    /// For example with automapper.
    /// </summary>
    public class StudentViewModel
    {
        public string UniqName { get; set; }
        public string AvgMark { get; set; }

        public static StudentViewModel Map(Student student)
        {
            var config = new MapperConfiguration(c => c.CreateMap<Student, StudentViewModel>()
                .ForMember("UniqName", o => o.MapFrom(x => $"{x.Id}. {x.Name}"))
                .ForMember("AvgMark", o => o.MapFrom(x => x.Marks.Sum(x => x.Points))));

            var entry = new Mapper(config).Map<StudentViewModel>(student);

            return entry;
        }
    }
}
