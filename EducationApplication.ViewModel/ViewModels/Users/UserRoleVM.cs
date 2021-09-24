using EducationApplication.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApplication.ViewModel.ViewModels.Users
{
    public class UserRoleVM
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }


        public List<UserRoleVM> ToViewModel(List<User> list)
        {
            var allUserrolesVM = new List<UserRoleVM>();
            foreach (var item in list)
            {
                allUserrolesVM.Add(new UserRoleVM()
                {
                    Id=item.Id,
                    UserName=item.UserName,
                    FullName=item.FirstName+" "+item.LastName,
                    Email=item.Email
                });
            }

            return allUserrolesVM;
        }

    }
}
