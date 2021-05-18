using MappingDemo.Data;
using MappingDemo.ViewModels;
using MappingDemo.Abstractions;
using MappingDemo.Models;
using System;
using System.Linq;

namespace MappingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, I`m mapping!");

            // Mapping example.
            var students = ICrudable.GetAll<Student>();         

            foreach (var student in students)
            {
                var viewModel = StudentViewModel.Map(student);
                Console.WriteLine($"{viewModel.UniqName} - {viewModel.AvgMark}");
            }

            Console.ReadKey();
        }
    }
}
