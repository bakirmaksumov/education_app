using EducationApplication.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApplication.ViewModel.ViewModels.Grant
{
    public class GrantVM
    {
            public int Id { get; set; }
            [Display(Name = "Student")]
            [Required(ErrorMessage = "Please select student")]
            public int UserID { get; set; }
            [Display(Name = "Name")]
            public string FullName { get; set; }
            [Display(Name = "PINFL")]
            public string PINFL { get; set; }
            [Display(Name = "Registration Number")]
            [Required(ErrorMessage = "Please enter Registration Number")]
            public string RegistrationNumber { get; set; }
            [Display(Name = "Student")]
            [Required(ErrorMessage = "Please select certificate type")]
            public int GrantTypeId { get; set; }
            [Display(Name = "Grant Type")]
            public string GrantType { get; set; }
            public string Url { get; set; }
            //[Display(Name = "DueDate")]
            //public string DueDate { get; set; }
            [Display(Name = "Created By")]
            public int CreatedBy { get; set; }
            [Display(Name = "Create Date")]
            public DateTime CreateDate { get; set; }
            [Display(Name = "Modified By")]
            public int? ModifiedBy { get; set; }
            [Display(Name = "Modify Date")]
            public DateTime? ModifyDate { get; set; }
            public int StatusID { get; set; }
            public string Status { get; set; }
            public int Amount { get; set; }
            public int SchoolId { get; set; }

            public GrantVM ModeltoVM(StudentGrant model)
            {
            GrantVM modelVM = new GrantVM
            {
                    Id = model.Id,
                    UserID = model.UserId,
                    FullName = model.User.FirstName + " " + model.User.LastName,
                    PINFL = model.User.UserInfoUsers != null ? model.User.UserInfoUsers.First().Pinfl : "no PINFL",
                    GrantTypeId = model.GrantTypeId,
                    GrantType = model.GrantType.Name,
                    Url = model.Url,
                    StatusID=model.StatusId,
                    //DueDate = model.DueDate.ToString(),
                    CreateDate = model.CreateDate,
                    CreatedBy = model.CreatedBy,
                    ModifiedBy = model.ModifiedBy,
                    ModifyDate = model.ModifyDate,
                    Amount=model.Amount,
                    Status = model.Status.Name,
                    RegistrationNumber = model.RegistrationNumber
                };
                return modelVM;
            }

            public List<GrantVM> VMFromModelList(List<StudentGrant> modelList)
            {
                List<GrantVM> listVM = new List<GrantVM>();
                foreach (var item in modelList)
                {
                GrantVM modelVM = this.ModeltoVM(item);
                    listVM.Add(modelVM);
                }
                return listVM;
            }
            public StudentGrant ModelFromVM(User user)
            {
                var cultures = new CultureInfo("en-US");
                StudentGrant m = new StudentGrant
                {
                    Id = this.Id,
                    UserId = this.UserID,
                    GrantTypeId = this.GrantTypeId,
                    Url = this.Url,
                    //DueDate = DateTime.Parse(this.DueDate, cultures),
                    CreateDate = DateTime.Now,
                    CreatedBy = user.Id,
                    ModifiedBy = this.ModifiedBy,
                    ModifyDate = this.ModifyDate,
                    StatusId = this.StatusID,
                    Amount=this.Amount,
                    RegistrationNumber = this.RegistrationNumber
                };
                return m;
            }
        
    }
}
