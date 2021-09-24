using EducationApplication.Data.Infrastructure;
using EducationApplication.Data.Repository.Interfaces.Account;
using EducationApplication.Model.Models;
using EducationApplication.Service.Services.Interfaces.Account;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApplication.Service.Services.Account
{
    public class RoleService : BaseService<Role>, IRoleService
    {
        public RoleService(IRoleRepository repository,
                         IUnitOfWork unitOfWork)
          : base(repository, unitOfWork)
        {
        }

        public bool Create(Role user)
        {
            try
            {
                this._repository.Add(user);
                Save();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Edit(Role role)
        {
            try
            {
                this._repository.Update(role);
                Save();
                return true;
            }
            catch
            { return false; }
        }

        public Role GetUserByID(int id)
        {
            var roles = this._repository.Get(u => u.Id == id);
            return roles;
        }

        public List<Role> GetAllRoles()
        {
            var roles = _repository.GetAll().ToList();
            return roles;
        }

        public List<SelectListItem> getAllAsSelectedList(int selected = 0)
        {
            var list = new List<SelectListItem>()
            { 
              new SelectListItem{Value="0", Text="--Select--"}
            };

            var getList = GetAll().Select(item => new SelectListItem()
            {

                Value = item.Id.ToString(),
                Text = item.Name.ToString(),
                Selected = (item.Id == selected) ? true : false

            }).ToList();
            //getList.AddRange(getList);
            list.AddRange(getList);

            return list;
        }

   
        
    }
}
