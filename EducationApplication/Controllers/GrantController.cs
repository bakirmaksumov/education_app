using EducationApplication.Common.Enums;
using EducationApplication.Model.Models;
using EducationApplication.Service.Services.Interfaces.Account;
using EducationApplication.Service.Services.Interfaces.Grant;
using EducationApplication.Service.Services.Interfaces.School;
using EducationApplication.ViewModel.ViewModels.Grant;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationApplication.Controllers
{
    public class GrantController : Controller
    {
        private readonly IStudentGrantsService StudentGrantsService;
        private readonly IGrantTypeService GrantTypeService;
        private readonly IUserService UserService;
        private readonly ISchoolFromAPIService SchoolFromAPIService;
        public GrantController(IStudentGrantsService studentGrantsService, IGrantTypeService grantTypeService, IUserService userService, ISchoolFromAPIService schoolFromAPIService)
        {
            StudentGrantsService = studentGrantsService;
            GrantTypeService = grantTypeService;
            UserService = userService;
            SchoolFromAPIService = schoolFromAPIService;
        }

        [Authorize(Roles = "admin")]
        public ActionResult Index()
        {
            var schools = SchoolFromAPIService.GetSchoolsAsync();
            GrantVM modelVM = new GrantVM();
            List<StudentGrant> lm = StudentGrantsService.GetAll().ToList();
            List<GrantVM> listVM = modelVM.VMFromModelList(lm);
            return View(listVM);
        }
        [Authorize(Roles = "admin")]
        public ActionResult Assign()
        {
            //SchoolFromAPIService = new SchoolFromAPIService();
            ViewBag.GrantTypeslist = GrantTypeService.GetAllAsSelectList();
            ViewBag.StudentsList = UserService.GetAllAsSelectList();
            ViewBag.SchoolList = SchoolFromAPIService.getSelectedListItems();
            GrantVM modelVM = new GrantVM();
            modelVM.StatusID = 1;
            return View(modelVM);
        }
        [HttpPost]
        public ActionResult Assign(GrantVM modelVM)
        {
            //vm.DueDate = DateTime.Now;
            try
            {
                User user = UserService.GetCurrent();
                if (ModelState.IsValid)
                {
                    bool create = StudentGrantsService.Create(modelVM.ModelFromVM(user));
                    return Redirect("/Grant/Index");
                }
                else
                {
                    ViewBag.CertificateTypeslist = GrantTypeService.GetAllAsSelectList();
                    ViewBag.StudentsList = UserService.GetAllAsSelectList();
                    return View(modelVM);
                }

            }
            catch (Exception ex)
            {
                ViewBag.CertificateTypeslist = GrantTypeService.GetAllAsSelectList();
                ViewBag.StudentsList = UserService.GetAllAsSelectList();
                return View(modelVM);
            }

        }

        [Authorize(Roles = "admin")]
        public ActionResult Details(int id)
        {
            var modelVM = new GrantVM();
            var model = StudentGrantsService.GetByID(id);
            modelVM = modelVM.ModeltoVM(model);
            return View(modelVM);
        }
        public string ChangeStatus(int id, string value)
        {
            var model = StudentGrantsService.GetByID(id);
            model.StatusId = value == "true" ? 1 : 2;
            string status = Enum.GetName(typeof(StatusEnum), model.StatusId);
            bool changed = StudentGrantsService.Edit(model);
            if (changed)
            { return status; }
            else { return null; }
        }

    }
}
