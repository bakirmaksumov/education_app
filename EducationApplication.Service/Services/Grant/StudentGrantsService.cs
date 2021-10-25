using EducationApplication.Data.Infrastructure;
using EducationApplication.Data.Repository.Interfaces;
using EducationApplication.Data.Repository.Interfaces.Grant;
using EducationApplication.Model.Models;
using EducationApplication.Service.Services.Interfaces.Grant;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EducationApplication.Service.Services.Grant
{
    public class StudentGrantsService : BaseService<StudentGrant>, IStudentGrantsService
    {
        public StudentGrantsService(IStudentGrantsRepository repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
        }
        public bool Create(StudentGrant model)
        {
            try
            {
                this._repository.Add(model);
                Save();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Edit(StudentGrant model)
        {
            try
            {
                this._repository.Update(model);
                Save();
                return true;
            }
            catch
            { return false; }
        }

        public IQueryable<StudentGrant> GetAsQuerable()
        {
            return _repository.GetAny();
        }
      
    }
}
