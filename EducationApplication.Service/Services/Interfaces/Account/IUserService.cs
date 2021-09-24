using EducationApplication.Model.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public bool RemoveFromRole(User user, int roleId);
        public User GetUserAuth(string username, string password);
        List<SelectListItem> GetAllAsSelectList(int selected = 0);
        User GetCurrent();
    }
}
