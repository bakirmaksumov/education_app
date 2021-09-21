using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApplication.ViewModel.ViewModels.Account
{
   public class RoleVM
    {
        [Display(Name = "№")]
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}
