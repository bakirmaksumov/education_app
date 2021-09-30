using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationApplication.Service.Services.Interfaces.Payment;
using EducationApplication.Model.Models;

namespace EducationApplication.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentControllerAPI : ControllerBase
    {
        private readonly IInvoiceService InvoiceService;
        public PaymentControllerAPI(IInvoiceService _InvoiceService)
        {
            InvoiceService = _InvoiceService;
        }


        [HttpPut("{id}")]
        public IActionResult ConfirmPayment(int id)
        {
            Invoice invoice= InvoiceService.GetByID(id);
            if (invoice != null)
            {
                invoice.Payed = true;
                bool edited = InvoiceService.Edit(invoice);
                if (edited) { return Ok(); }
                else return BadRequest();
            }
            else { return NotFound(); }
          //  return 
           
        }
    }
}
