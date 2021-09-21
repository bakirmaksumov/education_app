using EducationApplication.Common;
using EducationApplication.Service.Services.Interfaces.Account;
using EducationApplication.ViewModel.ViewModels.Account;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EducationApplication.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService UserService;
        private readonly IUserInfoService UserInfoService;
        // GET: AccountController
        public AccountController(IUserService userService, IUserInfoService userInfoService)
        {
            UserService = userService;
            UserInfoService = userInfoService;
        }
       
        
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginVM modelVM)
        {
            if (ModelState.IsValid)
            {
                var result = UserService.GetByUserName(modelVM.UserName);
                if (result != null)
                {
                    var decryptedData = EncryptDecrypt.Decrypt(result.Password);
                    if (modelVM.Password == decryptedData)
                    {
                        await Authenticate(modelVM.UserName);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                        ModelState.AddModelError("", "Password or Username is incorrect");
                }
                else 
                ModelState.AddModelError("", "Password or Username is incorrect");
            }
            return View(modelVM);
        }
        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Registration(RegisterVM modelVM)
        {
            if (ModelState.IsValid)
            {
                var isUserExist = UserService.GetByUserName(modelVM.UserName);
                if (isUserExist == null)
                {
                    var encryptedData = EncryptDecrypt.Encrypt(modelVM.Password);
                    var register = new RegisterVM();
                    var result = register.ToViewModel(modelVM,encryptedData);
                    UserService.Create(result);
                    await Authenticate(modelVM.UserName);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "User already eixist");
                }
            }
            return View(modelVM);
        }
        // GET: AccountController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AccountController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Roles()
        {
            return View();
        }

        public ActionResult RolesCreate()
        {
            return View();
        }

       
        [HttpPost]
        public ActionResult RolesCreate(RolesCreateVM modelVM)
        {
            return View();
        }

        //public ActionResult RolesEdit(int id)
        public ActionResult RolesEdit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RolesEdit(RolesEditVM modelVM)
        {
            return View();
        }

        public ActionResult AssignRole()
        {
            return View();
        }

        [HttpGet]
        public IActionResult LoadUserPartailList()
        {
            return PartialView("_PartialViewUsers");
        }

        public IActionResult RolePartailList()
        {
            return PartialView("_PartialViewRoles");
        }
        // GET: AccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AccountController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        private async Task Authenticate(string userName)
        {
            var claims = new List<Claim> {

              new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };
            //create objet ClaimsIndentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);

            //set authen cookies
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
    }
}
