using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApplication.ViewModel.ViewModels.Account
{
    public class RegisterVM
    {
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Passport Number is required")]
        public string PassportNum { get; set; }

        [Required(ErrorMessage="Email is required")]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        [Required(ErrorMessage = "Date of Birth is required")]
        public string DateBirth { get; set; }

        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage = "Password doesn't match")]
        public string ConfirmPassword { get; set; }

    }
}
