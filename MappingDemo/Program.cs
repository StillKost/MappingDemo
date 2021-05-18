using MappingDemo.Data;
using MappingDemo.ViewModels;
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
            using var context = new ApplicationDbContext();

            var students = context.Students.ToList();
            foreach (var student in students)
            {
                var viewModel = StudentViewModel.Map(student);
                Console.WriteLine($"{viewModel.UniqName} - {viewModel.AvgMark}");
            }

            Console.ReadKey();
        }
    }
}
