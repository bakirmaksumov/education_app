using EducationApplication.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApplication.ViewModel.ViewModels.Account
{
    public class RolesCreateVM
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }


        public Role ToViewModel(RolesCreateVM modelVM)
        {
            var ViewToModelRole = new Role()
            { 
              Name=modelVM.Name
            };

            return ViewToModelRole;
        }
    }

}
