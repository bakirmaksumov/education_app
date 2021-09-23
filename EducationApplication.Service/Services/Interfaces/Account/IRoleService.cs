using EducationApplication.Model.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApplication.Service.Services.Interfaces.Account
{
    public interface IRoleService : IBaseService<Role>
    {
        bool Create(Role user);
        bool Edit(Role user);
        Role GetUserByID(int id);
        List<Role> GetAllRoles();
        List<SelectListItem> getAllAsSelectedList(int selected = 0);
    }
}
