using EducationApplication.Model.Models;
using System.Linq;

namespace EducationApplication.Service.Services.Interfaces.Certificate
{
    public interface IStudentCertificatesService : IBaseService<StudentCertificate>
    {
        bool Create(StudentCertificate model);
        bool Edit(StudentCertificate model);
        IQueryable<StudentCertificate> GetAsQuerable();
    }
}
