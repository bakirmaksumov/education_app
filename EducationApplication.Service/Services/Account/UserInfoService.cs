using EducationApplication.Data.Infrastructure;
using EducationApplication.Data.Repository.Interfaces.Account;
using EducationApplication.Model.Models;
using EducationApplication.Service.Services.Interfaces.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApplication.Service.Services.Account
{
    public class UserInfoService : BaseService<UserInfo>, IUserInfoService
    {
        public UserInfoService(IUserInfoRepository repository,
                           IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            //    bool.TryParse(INTRANETConfiguration.CheckRoleByPosition, out checkRoleByPosition);
        }
        public bool Create(UserInfo user)
        {
            try
            {
                this._repository.Add(user);
                Save();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Edit(UserInfo user)
        {
            try
            {
                this._repository.Update(user);
                Save();
                return true;
            }
            catch
            { return false; }
        }

        public IQueryable<UserInfo> GetUserInfoAsQuerable()
        {
            return _repository.GetAny();
        }


    }
}
