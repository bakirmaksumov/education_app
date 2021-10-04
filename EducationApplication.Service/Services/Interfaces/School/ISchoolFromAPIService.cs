using EducationApplication.ViewModel.ViewModels.School;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApplication.Service.Services.Interfaces.School
{
    public  interface ISchoolFromAPIService
    {
         Task<string> GetSchoolsAsync();
         List<SchoolVM> GetJsonToObject();
         SchoolVM GetJsonToObjectById(int id);
        List<SelectListItem> getSelectedListItems(int selected = 0);
    }
  
}
