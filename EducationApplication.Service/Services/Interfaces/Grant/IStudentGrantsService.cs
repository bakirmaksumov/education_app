using EducationApplication.Model.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace EducationApplication.Service.Services.Interfaces.Grant
{
    public interface IStudentGrantsService : IBaseService<StudentGrant>
    {
        bool Create(StudentGrant model);
        bool Edit(StudentGrant model);
        IQueryable<StudentGrant> GetAsQuerable();
    }
}
