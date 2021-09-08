using EducationApplication.Data.Infrastructure;
using EducationApplication.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApplication.Service.Services
{
    public class BaseService<T>
        where T : class
    {
        protected IRepository<T> _repository { get; set; }
        protected IUnitOfWork _unitOfWork { get; set; }

        public BaseService(IRepository<T> repository, IUnitOfWork unitOfWork)
        {
            this._repository = repository;
            this._unitOfWork = unitOfWork;
        }

        public virtual T GetByID(int id)
        {
            return _repository.GetById(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return this._repository.GetAll();
        }

        public virtual IQueryable<T> GetAllAsIQueryable()
        {
            return this._repository.GetAny();
        }

        public virtual void Save()
        {
            _unitOfWork.Commit();
        }
    }
}
