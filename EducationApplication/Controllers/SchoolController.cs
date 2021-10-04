using EducationApplication.Service.Services.Interfaces.School;
using EducationApplication.Service.Services.School;
using EducationApplication.ViewModel.ViewModels.School;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationApplication.Controllers
{
    public class SchoolController : Controller
    {
        private ISchoolFromAPIService schoolFromAPIService { get;set; }
        // GET: SchoolController
        public ActionResult Index()
        {
            schoolFromAPIService = new SchoolFromAPIService();
            var final = schoolFromAPIService.GetJsonToObject();
            return View(final);
        }

        // GET: SchoolController/Details/5
        public ActionResult Details(int id)
        {
            schoolFromAPIService = new SchoolFromAPIService();
            if (id != 0) {
                var final = schoolFromAPIService.GetJsonToObjectById(id);
                return View(final);
            }
            return View();
        }

        // GET: SchoolController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SchoolController/Create
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

        // GET: SchoolController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SchoolController/Edit/5
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

        // GET: SchoolController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SchoolController/Delete/5
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
