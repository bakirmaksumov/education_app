using EducationApplication.Model.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EducationApplication.Service.Services.Interfaces.Certificate
{
    public interface ICertificateTypeService : IBaseService<CertificateType>
    {
        bool Create(CertificateType model);
        bool Edit(CertificateType model);
        IQueryable<CertificateType> GetAsQuerable();
        List<SelectListItem> GetAllAsSelectList(int selected = 0);
    }
}
