using EducationApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApplication.Service.Services.Interfaces.Account
{
   public interface IUserService: IBaseService<User>
    {
        bool Create(User user);
        bool Edit(User user);
        User GetByUserName(string username);
        List<User> GetUserListByID(List<int> userIDs);
        IQueryable<User> GetUserAsQuerable();
    }
}
