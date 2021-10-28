using EducationApplication.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApplication.ViewModel.ViewModels.Payment
{
   public class PaymentVM
    {
        [Display(Name = "Student Name")]
        public string studentName { get; set; }

        [Display(Name = "Amount")]
        public string amount { get; set; }

        public PaymentVM ToModelView(Invoice invoice)
        {
            var ViewToModelInvoice = new PaymentVM()
            {
                studentName = invoice.User.FirstName + " " + invoice.User.LastName,
                amount = Convert.ToString(invoice.Amount)
            };

            return ViewToModelInvoice;

        }
    }
}
