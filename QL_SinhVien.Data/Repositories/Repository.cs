using Microsoft.EntityFrameworkCore;
using QL_SinhVien.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace QL_SinhVien.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly QL_SinhVienDBContext _context;
        protected readonly DbSet<T> _dbSet;
        public Repository(QL_SinhVienDBContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public void Add(T entity)
        {
            _context.Add(entity);
            _context.SaveChangesAsync();
        }
        
        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsQueryable();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public T Insert(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChangesAsync();
            return entity;
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }
        public async void RemoveAsync(T entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public T Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(Update)} entity must not be null");
            }

            try
            {
                _context.Set<T>().Update(entity);
                _context.SaveChanges();

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be updated: {ex.Message}");
            }
        }
    }
}
