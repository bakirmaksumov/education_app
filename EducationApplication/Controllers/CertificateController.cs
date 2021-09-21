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

namespace EducationApplication.Controllers
{
    [Authorize]
    public class CertificateController : Controller
    {
        private readonly IStudentCertificatesService StudentCertificatesService;
        private readonly ICertificateTypeService CertificateTypeService;
        private readonly ICertificateTemplatesService CertificateTemplatesService;
        private readonly IUserService UserService;
        public CertificateController(IStudentCertificatesService studentCertificatesService, ICertificateTypeService certificateTypeService, ICertificateTemplatesService certificateTemplatesService, IUserService userService)
        {
            StudentCertificatesService = studentCertificatesService;
            CertificateTypeService = certificateTypeService;
            CertificateTemplatesService = certificateTemplatesService;
            UserService = userService;
        }

        // GET: CertificateController
        public ActionResult Index()
        {
            CertificatesVM vm = new CertificatesVM();
            List<StudentCertificate> lm= StudentCertificatesService.GetAll().ToList();
            List<CertificatesVM> lvm = vm.VMFromModelList(lm);
            return View(lvm);
        }
        public ActionResult Assign()
        {
            List<SelectListItem> CertificateTypeslist= CertificateTypeService.GetAllAsSelectList();
            ViewBag.CertificateTypeslist = CertificateTypeslist;
            List<SelectListItem> StudentsList = UserService.GetAllAsSelectList();
            ViewBag.StudentsList = StudentsList;
            CertificatesVM vm = new CertificatesVM();
            vm.DueDate = DateTime.Now;
            return View(vm); 
        }
        [HttpPost]
        public ActionResult Assign(CertificatesVM vm)
        {
            //vm.DueDate = DateTime.Now;
            try
            {
                User user = UserService.GetCurrent();
                if (ModelState.IsValid)
                {
                    bool create = StudentCertificatesService.Create(vm.ModelFromVM(user));
                    return Redirect("/Certificate/Index");
                }
                else { return View(vm); }
         
            }
            catch (Exception ex)
            {
                return View(vm);
            }

        }
        // GET: CertificateController/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
