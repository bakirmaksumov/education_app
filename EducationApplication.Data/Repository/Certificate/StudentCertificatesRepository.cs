using EducationApplication.Data.Infrastructure;
using EducationApplication.Data.Repository.Interfaces.Account;
using EducationApplication.Data.Repository.Interfaces.Certificate;
using EducationApplication.Model.Models;


namespace EducationApplication.Data.Repository.Certificate
{
    public class StudentCertificatesRepository : RepositoryBase<StudentCertificate>, IStudentCertificatesRepository
    {
        public StudentCertificatesRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}
