using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using ExcerciseASP.Interfaces;
using System.Data.Entity.Validation;

namespace ExcerciseASP.DataAccess.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext Context;

        protected readonly DbSet<T> DbSet;

        protected string errorMessage = string.Empty;

        public Repository(DbContext context)
        {
            Context = context;
            DbSet = Context.Set<T>();
        }

        public T Get(params object[] keys)
        {
            return DbSet.Find(keys);
        }

        public IEnumerable<T> GetAll()
        {
            return DbSet.ToList();
        }

        public void Add(T entry)
        {
            DbSet.Add(entry);
            Context.SaveChanges();
        }

        public void Remove(T entry)
        {
            DbSet.Remove(entry);
            Context.SaveChanges();
        }

    }
}