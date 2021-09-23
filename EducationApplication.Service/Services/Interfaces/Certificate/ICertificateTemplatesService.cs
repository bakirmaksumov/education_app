using EducationApplication.Model.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace EducationApplication.Service.Services.Interfaces.Certificate
{
    public interface ICertificateTemplatesService : IBaseService<CertificateTemplate>
    {
        bool Create(CertificateTemplate model);
        bool Edit(CertificateTemplate model);
        IQueryable<CertificateTemplate> GetAsQuerable();
        List<SelectListItem> GetAllAsSelectList(int selected = 0);
    }
}
