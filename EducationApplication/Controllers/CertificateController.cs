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
            CertificatesVM modelVM = new CertificatesVM();
            List<StudentCertificate> lm= StudentCertificatesService.GetAll().ToList();
            List<CertificatesVM> listVM = modelVM.VMFromModelList(lm);
            return View(listVM);
        }
        public ActionResult Assign()
        {
           
            ViewBag.CertificateTypeslist = CertificateTypeService.GetAllAsSelectList();
            ViewBag.StudentsList = UserService.GetAllAsSelectList();
            CertificatesVM modelVM = new CertificatesVM();
            modelVM.DueDate = DateTime.Now.ToString();
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
