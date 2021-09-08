using EducationApplication.Data.Infrastructure;
using EducationApplication.Data.Repository.Interfaces.Account;
using EducationApplication.Model;
using EducationApplication.Service.Services.Interfaces.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApplication.Service.Services.Account
{
   public class UserService : BaseService<User>, IUserService
    {
        public UserService(IUserRepository repository,
                            IUnitOfWork unitOfWork)
             : base(repository, unitOfWork)
        {
        //    bool.TryParse(INTRANETConfiguration.CheckRoleByPosition, out checkRoleByPosition);
        }

        public bool Create(User user)
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

        public bool Edit(User user)
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

        public User GetByUserName(string username)
        {
            var user = this._repository.Get(u => u.UserName == username);
            return user;
        }

        public List<User> GetUserListByID(List<int> userIDs)
        {
            if (userIDs == null || userIDs.Count == 0)
                return new List<User>();

            return this._repository.GetAny()
                .Where(m => userIDs.Contains(m.Id))
                .ToList();
        }

        public IQueryable<User> GetUserAsQuerable()
        {
            return _repository.GetAny();
        }



    }
}
