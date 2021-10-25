using EducationApplication.Data.Infrastructure;
using EducationApplication.Data.Repository.Interfaces.Grant;
using EducationApplication.Model.Models;

namespace EducationApplication.Data.Repository.Grant
{
    public class GrantTypeRepository : RepositoryBase<GrantType>, IGrantTypeRepository
    {
        public GrantTypeRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}
