using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApplication.ViewModel.ViewModels.Account
{
   public class AssignRoleVM
    {
        [Display(Name = "User ID")]
        public string UserID { get; set; }

        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        List<Roles> RoleList { get; set; }
    }

    public class Roles
    { 
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
