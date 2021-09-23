using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using EducationApplication.Model.Models;

namespace EducationApplication.Data.Infrastructure
{
    public abstract class RepositoryBase<T> where T: class
    {
        private educationdbContext _dataContext;
        private readonly  InternalDbSet<T> _dbset;

        protected RepositoryBase(IDatabaseFactory databaseFactory)
        {
            DatabaseFactory = databaseFactory;
            _dbset = (InternalDbSet<T>)DataContext.Set<T>();
        }
        protected IDatabaseFactory DatabaseFactory
        {
            get;
            private set;
        }

        protected educationdbContext DataContext
        {
            get { return _dataContext ?? (_dataContext = DatabaseFactory.Get()); }
        }

        public virtual void Add(T entity)
        {
            try
            {
                _dbset.Add(entity);
            }
            catch (Exception ex)
            {
                //write down log here
            }
        }

        public virtual T Insert(T entity)
        {
            try
            {
                var result = _dbset.Add(entity);
                return entity;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public virtual void Update(T entity)
        {

            try
            {
                _dbset.Attach(entity);
                _dataContext.Entry(entity).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Modified;
            }
            catch (Exception ex)
            {
                //write down log here
            }
        }

        public virtual void UpdateCollection(ICollection<T> entities)
        {
            try
            {
                foreach (var item in entities)
                {
                    _dbset.Attach(item);
                    _dataContext.Entry(item).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Modified;
                }
            }
            catch (Exception ex)
            {
                //write down log here
            }
        }

        public virtual void Delete(T entity)
        {
            try
            {
                _dbset.Remove(entity);
            }
            catch (Exception ex)
            {
                //write down log here
            }
        }

        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = _dbset.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                _dbset.Remove(obj);
        }

        public virtual void AttachCollection(ICollection<T> collection)
        {
            foreach (var p in collection)
            {
                _dbset.Attach(p);
                _dataContext.Entry(p).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Modified;
            }
        }

        public virtual void DeleteCollection(ICollection<T> collection)
        {
            var count = collection.Count();
            for (int i = count; i > 0; i--)
            {
                var item = collection.ElementAt(i - 1);
                _dbset.Attach(item);
                _dataContext.Entry(item).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Deleted;
            }
        }

        public virtual T GetById(int id)
        {
            try
            {
                var result = _dbset.Find(id);
                return result;
            }
            catch (Exception ex)
            {
                //write down log here
                return null;
            }
        }
        public virtual T GetById(string id)
        {
            try
            {
                var result = _dbset.Find(id);
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public virtual IEnumerable<T> GetAll()
        {
            try
            {
                var result = _dbset.ToList();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            try
            {
                var result = _dbset.Where(where).ToList();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public virtual IQueryable<T> GetAny()
        {
            try
            {
                var result = _dataContext.Set<T>();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            try
            {
                var result = _dbset.Where(where).FirstOrDefault<T>();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public bool ExistsInSet(T entity)
        {
            return _dbset.Local.Any(e => e == entity);
        }


    }
}
