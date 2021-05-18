using MappingDemo.Models;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MappingDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Mark> Marks { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-HETAGUROV;Database=testdb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Student>()
                .HasMany(e => e.Marks)
                .WithOne(e => e.Student)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<Lesson>()
                .HasMany(e => e.Marks)
                .WithOne(e => e.Lesson)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
