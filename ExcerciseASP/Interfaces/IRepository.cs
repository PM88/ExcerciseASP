using System;
using System.Collections.Generic;
using System.Linq.Expressions;


namespace ExcerciseASP.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T Get(params object[] keys);
        IEnumerable<T> GetAll();

        void Add(T entity);

        void Remove(T entity);
    }
}