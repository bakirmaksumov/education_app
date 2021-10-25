using EducationApplication.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApplication.ViewModel.ViewModels.Account
{
    public class RolesEditVM
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Update Date")]
        public string UpdateDate { get; set; }
        [Display(Name = "Updated By")]
        public string UpdatedBy { get; set; }

        public RolesEditVM toModelView(Role role)
        {
            var roles = new RolesEditVM() {
                Id=role.Id,
                Name = role.Name
            };
            return roles;
        }

        public Role ToViewModel(RolesEditVM modelVM, Role role, int UserId)
        {

            role.Name = modelVM.Name;
            //role.UpdateDate = DateTime.Now;
            //role.UpdatedBy = UserId;

            return role;
        }


    }
}
