using EducationApplication.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApplication.ViewModel.ViewModels.Users
{
   public class UserRoleViewVM
    {
       
        [Display(Name = "User ID")]
        public int Id { get; set; }

        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public List<UserRoleList> getRoleList { get; set; }


        public UserRoleViewVM modelToView(User model)
        {
            var allUsers = new UserRoleViewVM { 
                Id=model.Id,
                UserName=model.UserName,
                FirstName=model.FirstName,
                LastName=model.LastName
            };

            if (model.UserRoles.Count() != 0 && model.UserRoles!=null)
            {
                allUsers.getRoleList = new List<UserRoleList>();
                foreach (var item in model.UserRoles)
                {
                    var role = new UserRoleList();
                    role.RoleId = item.RoleId;
                    role.Name = item.Role.Name;
                    allUsers.getRoleList.Add(role);
                }
            }
            else
            { allUsers.getRoleList = new List<UserRoleList>(); }
            return allUsers;
        }

        public User viewToModel(int userId, int rolId, User user)
        {
            user.UserRoles.Add(new UserRole { RoleId = rolId, UserId = userId });
            return user;
        }
    }

    public class UserRoleList
    { 
      public int RoleId { get; set; }
      public string Name { get; set; }
    }
}
