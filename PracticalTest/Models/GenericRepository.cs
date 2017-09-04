using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace PracticalTest.Models
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DbSet<T> _dbSet;

        public GenericRepository(DbSet<T> dbSet)
        {
            _dbSet = dbSet;
        }

        #region IGenericRepository<T> implementation

        public virtual IQueryable<T> AsQueryable()
        {
            return _dbSet.AsQueryable();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet;
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

        IQueryable<T> IGenericRepository<T>.AsQueryable()
        {
            throw new NotImplementedException();
        }

        IEnumerable<T> IGenericRepository<T>.GetAll()
        {
            throw new NotImplementedException();
        }

        IEnumerable<T> IGenericRepository<T>.Find(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        T IGenericRepository<T>.Single(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        T IGenericRepository<T>.SingleOrDefault(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        T IGenericRepository<T>.First(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        T IGenericRepository<T>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        void IGenericRepository<T>.Add(T entity)
        {
            throw new NotImplementedException();
        }

        void IGenericRepository<T>.Delete(T entity)
        {
            throw new NotImplementedException();
        }

        void IGenericRepository<T>.Attach(T entity)
        {
            throw new NotImplementedException();
        }

        // And so on ...

        #endregion
    }
}