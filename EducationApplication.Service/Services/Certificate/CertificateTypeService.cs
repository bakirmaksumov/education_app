using EducationApplication.Data.Infrastructure;
using EducationApplication.Data.Repository.Interfaces;
using EducationApplication.Data.Repository.Interfaces.Certificate;
using EducationApplication.Model.Models;
using EducationApplication.Service.Services.Interfaces.Certificate;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EducationApplication.Service.Services.Certificate
{
    public class CertificateTypeService : BaseService<CertificateType>, ICertificateTypeService
    {
        public CertificateTypeService(ICertificateTypeRepository repository, IUnitOfWork unitOfWork) 
            : base(repository, unitOfWork)
        {
        }
        public bool Create(CertificateType model)
        {
            try
            {
                this._repository.Add(model);
                Save();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Edit(CertificateType model)
        {
            try
            {
                this._repository.Update(model);
                Save();
                return true;
            }
            catch
            { return false; }
        }

        public IQueryable<CertificateType> GetAsQuerable()
        {
            return _repository.GetAny();
        }
        public List<SelectListItem> GetAllAsSelectList(int selected = 0)
        {
                return GetAll().Select(item => new SelectListItem()
                {
                    Value = item.Id.ToString(),
                    Text = item.Name.ToString(),
                    Selected = (item.Id == selected) ? true : false
                }).ToList();
            
        }
    }
}
