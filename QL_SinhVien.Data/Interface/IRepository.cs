using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace QL_SinhVien.Data.Interface
{
    public interface IRepository<T> where T : class
    {
        T GetById(int id);
        IQueryable<T> GetAll();

        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        void Add(T entity);
        bool Remove(T entity);
        T Update(T entity);
        T Insert(T entity);
    }
}
