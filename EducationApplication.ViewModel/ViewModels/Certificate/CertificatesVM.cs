using System;
using EducationApplication.Model.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApplication.ViewModel.ViewModels.Certificate
{
    public class CertificatesVM
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string PINFL { get; set; }
        public int CertificateTypeId { get; set; }
        public string CertificateType { get; set; }
        public string Url { get; set; }
        public DateTime DueDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifyDate { get; set; }

        public CertificatesVM ModeltoVM(StudentCertificate model)
        {
            CertificatesVM vm = new CertificatesVM
            {
                Id = model.Id,
                UserId = model.UserId,
                FullName = model.User.FirstName+" "+ model.User.LastName,
                PINFL= model.User.UserInfoUsers!=null? model.User.UserInfoUsers.First().Pinfl:"no PINFL",
                CertificateTypeId= model.CertificateTypeId,
                CertificateType= model.CertificateType.Name,
                Url= model.Url,
                CreateDate= model.CreateDate,
                CreatedBy= model.CreatedBy,
                ModifiedBy= model.ModifiedBy,
                ModifyDate= model.ModifyDate
            };
            return vm;
        }

        public List<CertificatesVM> VMFromModelList(List<StudentCertificate> modelList)
        {
            List<CertificatesVM> lvm = new List<CertificatesVM>();
            foreach (var item in modelList)
            {
                CertificatesVM vm = this.ModeltoVM(item);
                lvm.Add(vm);
            }
            return lvm;
        }
        public StudentCertificate ModelFromVM(User user)
        {
            StudentCertificate m = new StudentCertificate
            {
                Id = this.Id,
                UserId = this.UserId,               
                CertificateTypeId = this.CertificateTypeId,
                Url = this.Url,
                CreateDate = DateTime.Now,
                CreatedBy = user.Id,
                ModifiedBy = this.ModifiedBy,
                ModifyDate = this.ModifyDate
            };
            return m;
        }
    }
}
