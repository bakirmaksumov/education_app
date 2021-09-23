using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationApplication.Service.Services.Interfaces.Account;
using EducationApplication.Model.Models;
using EducationApplication.ViewModel.ViewModels.Student;

namespace EducationApplication.Controllers
{
    public class StudentController : Controller
    {
        private readonly IUserService UserService; //{ get; set; }
        private readonly IUserInfoService UserInfoService;// { get; set; }

        public StudentController(IUserInfoService userInfoService, IUserService userService)
        {
            UserInfoService = userInfoService;
            UserService = userService;
        }

        // GET: StudentController
        public ActionResult Index()
        {
            StudentsInfoVM vm = new StudentsInfoVM();
            List<User> listModel = UserService.GetAll().ToList();
            List<StudentsInfoVM> userInfo = vm.VMFromModelList(listModel);
            return View(userInfo);
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            StudentsInfoVM vm = new StudentsInfoVM();
            User m = UserService.GetAll().Where(m => m.Id == id).First();
            vm = vm.VMFromModel(m);
            return View(vm);
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
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

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentController/Edit/5
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

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentController/Delete/5
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
