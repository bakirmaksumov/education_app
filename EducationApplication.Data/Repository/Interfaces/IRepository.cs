using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EducationApplication.Data.Repository.Interfaces
{
   public interface IRepository<T> where T: class
    {
        void Add(T entity);
        T Insert(T entity);
        void Update(T entity);
        void UpdateCollection(ICollection<T> entities);
        void Delete(T entity);
        void Delete(Expression<Func<T, bool>> where);
        T GetById(int id);
        T GetById(string id);
        T Get(Expression<Func<T, bool>> where);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);
        IQueryable<T> GetAny();
        void DeleteCollection(ICollection<T> collection);
    }
}
