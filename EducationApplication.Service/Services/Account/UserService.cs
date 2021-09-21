using EducationApplication.Data.Infrastructure;
using EducationApplication.Data.Repository.Interfaces.Account;
using EducationApplication.Model.Models;
using EducationApplication.Service.Services.Interfaces.Account;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace EducationApplication.Service.Services.Account
{
   public class UserService : BaseService<User>, IUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UserService(IUserRepository repository,
                            IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
             : base(repository, unitOfWork)
        {
            _httpContextAccessor = httpContextAccessor;
            //    bool.TryParse(INTRANETConfiguration.CheckRoleByPosition, out checkRoleByPosition);
        }

        public bool Create(User user)
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

        public bool Edit(User user)
        {
            try
            {
                this._repository.Update(user);
                Save();
                return true;
            }
            catch
            { return false; }
        }

        public User GetByUserName(string username)
        {
            var user = this._repository.Get(u => u.UserName == username);
            return user;
        }

        public List<User> GetUserListByID(List<int> userIDs)
        {
            if (userIDs == null || userIDs.Count == 0)
                return new List<User>();

            return this._repository.GetAny()
                .Where(m => userIDs.Contains(m.Id))
                .ToList();
        }

        public IQueryable<User> GetUserAsQuerable()
        {
            return _repository.GetAny();
        }

        public User GetUserAuth(string username, string password)
        {
            return _repository.GetAny().FirstOrDefault(u => u.UserName == username && u.Password == password);
        }

        public List<SelectListItem> GetAllAsSelectList(int selected = 0)
        {
            return GetAll().Select(item => new SelectListItem()
            {
                Value = item.Id.ToString(),
                Text = item.FirstName.ToString()+" "+ item.LastName.ToString(),
                Selected = (item.Id == selected) ? true : false
            }).ToList();
        }
        public User GetCurrent()
        {
            if (!_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
                return null;
            string username = _httpContextAccessor.HttpContext.User.Identity.Name.ToString();
            User user = GetByUserName(username);
            return user;
        }
    }
}
