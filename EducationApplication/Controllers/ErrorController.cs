using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationApplication.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{StatusCode}")]
        public IActionResult HttpStatusCodeHandle(int statusCode)
        {
            switch(statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "404";
                    break;
                case 500:
                    ViewBag.ErrorMessage = "500";
                    break;            
            }
            return View("NotFound");
        }
    }
}
