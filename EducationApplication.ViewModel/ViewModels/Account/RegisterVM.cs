using EducationApplication.Model.Models;
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
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        [Display(Name = "Passport Number")]
        public string PassportNum { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage="Email is required")]
        [StringLength(30, ErrorMessage = "Must be between 5 and 50 characters", MinimumLength = 5)]
        [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Must be a valid email")]
        public string Email { get; set; }

        [Display(Name = "Phone Number")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Wrong mobile")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Display(Name = "Date of Birth")]
        [Required(ErrorMessage = "Date of Birth is required")]
        public string DateBirth { get; set; }

        [Display(Name = "Username")]
        [Required(ErrorMessage = "Username is required")]
        [StringLength(16, ErrorMessage = "Must be between 3 and 16 characters", MinimumLength = 3)]
        public string UserName { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [Compare("Password",ErrorMessage = "Password doesn't match")]
        public string ConfirmPassword { get; set; }

        public User ToViewModel(RegisterVM modelVM, string encryptedData)
        {
            var ViewToModelUser = new User()
            {
                FirstName = modelVM.FirstName,
                LastName = modelVM.LastName,
                UserName = modelVM.UserName,
                Password = encryptedData,
                CreateDate = DateTime.Now,
                Email = modelVM.Email!=null? modelVM.Email:String.Empty,
                //temporary
                Status = 1
                
            };

            var ViewToModelUserInfo = new UserInfo()
            {
                Phone = modelVM.PhoneNumber!=null? modelVM.PhoneNumber:String.Empty,
                Pinfl = modelVM.PassportNum !=null? modelVM.PassportNum: String.Empty,
                Adress = modelVM.Address,
                DateofBirth = Convert.ToDateTime(modelVM.DateBirth),
                CreateDate = DateTime.Now
            };
            ViewToModelUser.UserInfoUsers.Add(ViewToModelUserInfo);
            return ViewToModelUser;
        }

    }
}
