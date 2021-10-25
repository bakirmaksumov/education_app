using EducationApplication.Model.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace EducationApplication.Service.Services.Interfaces.Grant
{
    public interface IGrantTypeService : IBaseService<GrantType>
    {
        bool Create(GrantType model);
        bool Edit(GrantType model);
        IQueryable<GrantType> GetAsQuerable();
        List<SelectListItem> GetAllAsSelectList(int selected = 0);
    }
}
