using MappingDemo.Data;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MappingDemo.Abstractions
{
    public interface ICrudable
    {
        public static T Create<T>(T model)
            where T : IDbModel
        {
            using var context = new ApplicationDbContext();
            var set = context.Set<T>();
            set.Add(model);
            context.SaveChanges();
            return model;
        }

        public static T Update<T>(T model)
            where T : IDbModel
        {
            using var context = new ApplicationDbContext();
            var set = context.Set<T>();
            set.Update(model);
            context.SaveChanges();
            return model;
        }

        public static List<T> GetAll<T>(Func<T, bool> wherePredicate = null)
            where T : IDbModel
        {
            using var context = new ApplicationDbContext();
            var set = context.Set<T>();

            var data = new List<T>();
            if (wherePredicate != null)
            {
                data = set.Where(wherePredicate).ToList();
            }
            else
            {
                data = set.ToList();
            }           

            return data;
        }

        public static void Destroy<T>(T model)
            where T : IDbModel
        {
            using var context = new ApplicationDbContext();
            var set = context.Set<T>();
            set.Remove(model);
            context.SaveChanges();
        }
    }
}
