using EducationApplication.Data.Infrastructure;
using EducationApplication.Data.Repository.Interfaces.Grant;
using EducationApplication.Model.Models;

namespace EducationApplication.Data.Repository.Grant
{
    public class StudentGrantsRepository : RepositoryBase<StudentGrant>, IStudentGrantsRepository
    {
        public StudentGrantsRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}
