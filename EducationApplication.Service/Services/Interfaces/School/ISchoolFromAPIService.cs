using EducationApplication.ViewModel.ViewModels.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApplication.Service.Services.Interfaces.School
{
    public  interface ISchoolFromAPIService
    {
         Task<SchoolVM> GetSchoolsAsync();
    }
  
}
