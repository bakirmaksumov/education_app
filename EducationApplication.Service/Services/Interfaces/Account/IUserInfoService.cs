using EducationApplication.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApplication.Service.Services.Interfaces.Account
{
    public interface IUserInfoService : IBaseService<UserInfo>
    {
        bool Create(UserInfo user);
        bool Edit(UserInfo user);   
        IQueryable<UserInfo> GetUserInfoAsQuerable();
    }
}
