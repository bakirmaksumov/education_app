using EducationApplication.Data.Infrastructure;
using EducationApplication.Data.Repository.Interfaces.Account;
using EducationApplication.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApplication.Data.Repository.Account
{
    public class UserInfoRepository : RepositoryBase<UserInfo>, IUserInfoRepository
    {
        public UserInfoRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        { 
        }
    }
}
