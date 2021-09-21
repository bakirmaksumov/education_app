using EducationApplication.Data.Infrastructure;
using EducationApplication.Data.Repository.Interfaces;
using EducationApplication.Data.Repository.Interfaces.Certificate;
using EducationApplication.Model.Models;
using EducationApplication.Service.Services.Interfaces.Certificate;
using System;
using System.Linq;

namespace EducationApplication.Service.Services.Certificate
{
    public class StudentCertificatesService : BaseService<StudentCertificate>, IStudentCertificatesService
    {
        public StudentCertificatesService(IStudentCertificatesRepository repository, IUnitOfWork unitOfWork) 
            : base(repository, unitOfWork)
        {
        }
        public bool Create(StudentCertificate model)
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

        public bool Edit(StudentCertificate model)
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
        public IQueryable<StudentCertificate> GetAsQuerable()
        {
            return _repository.GetAny();
        }
    }
}
