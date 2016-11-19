using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace pl.lodz.p.ftims.edu.pai.central.dal
{
    public class EfGenericRepository<T> : IGenericRepository<T> where T : class
    {
        private DbSet<T> _dbSet;

        public EfGenericRepository(DbSet<T> dbSet)
        {
            _dbSet = dbSet;
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public IQueryable<T> AsQueryable()
        {
            return _dbSet.AsQueryable();
        }

        public void Attach(T entity)
        {
            _dbSet.Attach(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

        public T First(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.First(predicate);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet;
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);

        }

        public T Single(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Single(predicate);
        }

        public T SingleOrDefault(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.SingleOrDefault(predicate);
        }
    }
}

