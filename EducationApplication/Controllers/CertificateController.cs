using EducationApplication.Service.Services.Interfaces.Certificate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationApplication.Model.Models;
using EducationApplication.ViewModel.ViewModels.Certificate;
using Microsoft.AspNetCore.Mvc.Rendering;
using EducationApplication.Service.Services.Interfaces.Account;
using Microsoft.AspNetCore.Authorization;
using EducationApplication.Common.Enums;
using EducationApplication.Service.Services.Interfaces.School;
using EducationApplication.Service.Services.School;

namespace EducationApplication.Controllers
{
    [Authorize]
    public class CertificateController : Controller
    {
        private readonly IStudentCertificatesService StudentCertificatesService;
        private readonly ICertificateTypeService CertificateTypeService;
        private readonly ICertificateTemplatesService CertificateTemplatesService;
        private readonly IUserService UserService;
        private readonly ISchoolFromAPIService SchoolFromAPIService;
        private ISchoolFromAPIService schoolFromAPIService { get; set; }
        public CertificateController(IStudentCertificatesService studentCertificatesService, ICertificateTypeService certificateTypeService, ICertificateTemplatesService certificateTemplatesService, IUserService userService, ISchoolFromAPIService schoolFromAPIService)
        {
            StudentCertificatesService = studentCertificatesService;
            CertificateTypeService = certificateTypeService;
            CertificateTemplatesService = certificateTemplatesService;
            UserService = userService;
            SchoolFromAPIService = schoolFromAPIService;
        }

        // GET: CertificateController
        [Authorize(Roles = "admin")]
        public ActionResult Index()
        {
            var schools=SchoolFromAPIService.GetSchoolsAsync();
            CertificatesVM modelVM = new CertificatesVM();
            List<StudentCertificate> lm= StudentCertificatesService.GetAll().ToList();
            List<CertificatesVM> listVM = modelVM.VMFromModelList(lm);
            return View(listVM);
        }
        [Authorize(Roles = "admin")]
        public ActionResult Assign()
        {
            schoolFromAPIService = new SchoolFromAPIService();
            ViewBag.CertificateTypeslist = CertificateTypeService.GetAllAsSelectList();
            ViewBag.StudentsList = UserService.GetAllAsSelectList();
            ViewBag.SchoolList = schoolFromAPIService.getSelectedListItems();
            CertificatesVM modelVM = new CertificatesVM();
            modelVM.DueDate = DateTime.Now.ToString();
            modelVM.StatusID = 1;
            return View(modelVM); 
        }
        [HttpPost]
        public ActionResult Assign(CertificatesVM modelVM)
        {
            //vm.DueDate = DateTime.Now;
            try
            {
                User user = UserService.GetCurrent();
                if (ModelState.IsValid)
                {
                    bool create = StudentCertificatesService.Create(modelVM.ModelFromVM(user));
                    return Redirect("/Certificate/Index");
                }
                else {
                    ViewBag.CertificateTypeslist = CertificateTypeService.GetAllAsSelectList();
                    ViewBag.StudentsList = UserService.GetAllAsSelectList();
                    return View(modelVM); 
                }
         
            }
            catch (Exception ex)
            {
                ViewBag.CertificateTypeslist = CertificateTypeService.GetAllAsSelectList();
                ViewBag.StudentsList = UserService.GetAllAsSelectList();
                return View(modelVM);
            }

        }
        // GET: CertificateController/Details/5
        public ActionResult Details(int id)
        {
            var modelVM = new CertificatesVM();
            var model= StudentCertificatesService.GetByID(id);
            modelVM = modelVM.ModeltoVM(StudentCertificatesService.GetByID(id));
            return View(modelVM);
        }

        public string ChangeStatus(int id)
        {
            var model = StudentCertificatesService.GetByID(id);
            model.StatusId = model.StatusId == 1 ? 2 : 1;
            string status = Enum.GetName(typeof(StatusEnum), model.StatusId);
            bool changed = StudentCertificatesService.Edit(model);
            if (changed)
            { return status; }
            else { return null; }
        }
        // GET: CertificateController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CertificateController/Create
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

        // GET: CertificateController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CertificateController/Edit/5
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

        // GET: CertificateController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CertificateController/Delete/5
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
    }
}
