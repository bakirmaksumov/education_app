using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducationApplication.Model.Models;
using EducationApplication.ViewModel.ViewModels.Certificate;

namespace EducationApplication.ViewModel.ViewModels.Certificate
{
    public class CertificateTemplateVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cktext { get; set; }
        public int CertificateTypeId { get; set; }
        public string CertificateType { get; set; }
        public bool Active { get; set; }
        public bool Removed { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public CertificateTemplateVM VMFromModel(CertificateTemplate m)
        {
            CertificateTemplateVM vm = new CertificateTemplateVM
            {
                Id=m.Id,
                Active=m.Active,
                CertificateTypeId=m.CertificateTypeId,
                CertificateType=m.CertificateType.Name,
                Name=m.Name,
                Cktext=m.Cktext,
                CreateDate=m.CreateDate,
                CreatedBy=m.CreatedBy,
                ModifiedBy=m.ModifiedBy,
                ModifyDate=m.ModifyDate,
                Removed=m.Removed
            };
            return vm;
        }
    }
}
