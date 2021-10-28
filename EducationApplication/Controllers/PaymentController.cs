using EducationApplication.Common;
using EducationApplication.Common.Methods;
using EducationApplication.Service.Services.Interfaces.Account;
using EducationApplication.Service.Services.Interfaces.Payment;
using EducationApplication.Service.Services.Interfaces.School;
using EducationApplication.ViewModel.ViewModels.Payment;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApplication.Controllers
{
    [Authorize]
    public class PaymentController : Controller
    {
        // GET: PaymentController
        private readonly IInvoiceService InvoiceService;
        private readonly IUserService UserService;
        private readonly ISchoolFromAPIService SchoolFromAPIService;
        public PaymentController(IInvoiceService invoiceService, IUserService userService, ISchoolFromAPIService schoolFromAPIService)
        {
            InvoiceService = invoiceService;
            UserService = userService;
            SchoolFromAPIService = schoolFromAPIService;
        }

        [Authorize(Roles = "admin")]
        public ActionResult Index()
        {
            var invoice = new InvoiceListVM();
            var invoicelist = InvoiceService.GetAllInvoice();
            var modelVM = invoice.ToViewModel(invoicelist);
            return View(modelVM);
        }

        // GET: PaymentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PaymentController/Create
        public ActionResult Create()
        {
            ViewBag.StudentList = UserService.GetAllAsSelectList().OrderBy(c => c.Text);
            ViewBag.SchoolList = SchoolFromAPIService.getSelectedListItems();
            return View();
        }

        // POST: PaymentController/Create
        [Authorize(Roles = "admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(InvoiceCreateVM modelVM)
        {
            if (ModelState.IsValid)
            {
                var user = UserService.GetCurrent();
                var invoiceVM = new InvoiceCreateVM();
                InvoiceService.Create(invoiceVM.ToViewModel(modelVM,user));
                return RedirectToAction("Index", "Payment");
            }
            return View(modelVM);
        }

        [Authorize(Roles = "admin")]
        public ActionResult Pay(int amount,int orderId)
        {
            var final = String.Format("https://smartcity-citizenaccount-frontend.azurewebsites.net/payment/request?orderId={0}&amount={1}&serviceId=1",  orderId, amount);
            return Redirect(final);

        }

        public ActionResult Payment(int amount, int studentId)
        {
            var result = InvoiceService.GetUserByID(studentId);
            var modelVM = new PaymentVM();
            return View(modelVM.ToModelView(result));
        }

        [Authorize(Roles = "admin")]
        public ActionResult GenerateInvoice(int Id)
        {
            var invoice = InvoiceService.GetByID(Id);
            if (invoice != null)
            {
                var builder = new StringBuilder();
                var model = new InvoiceBulderString();
                var user = invoice.User;
                var content = model.ReadHtmlFile();
                if (user != null)
                {
                    var result = model.StringToStringBuilder(invoice);
                    string[] delim = { Environment.NewLine, "\n" };
                    string[] lines = result.ToString().Split(delim, StringSplitOptions.None);
                    int i = 0;
                    foreach (var item in lines)
                    {  
                        i++;
                        content = content.Replace("itemcontent"+i.ToString(), item);
                    }
                    return File(PdfConverter.PdfSharpConverter(content), "application/pdf");
                }
                
            }
            return View();
        
        }
       
    }
}
