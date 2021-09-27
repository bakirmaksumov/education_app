using EducationApplication.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApplication.ViewModel.ViewModels.Payment
{
    public class InvoiceListVM
    {
        public int Id { get; set; }

        [Display(Name = "Student Name")]
        public string StudentFullName { get; set; }
        
        [Display(Name = "School Name")]
        public string SchoolName { get; set; }

        [Display(Name = "Amount")]
        public int Amount { get; set; }

        [Display(Name = "Payment Type")]
        public string PaymentType { get; set; }

        [Display(Name = "Status Name")]
        public string StatusName { get; set; }

        public List<InvoiceListVM> ToViewModel(List<Invoice> list)
        {
            var allInvoiceVM = new List<InvoiceListVM>();
            foreach (var item in list)
            {
                allInvoiceVM.Add(new InvoiceListVM()
                {
                    Id = item.Id,
                   // SchoolName = item.SchoolId,
                    StudentFullName= item.User.FirstName + " " + item.User.LastName,
                    Amount = item.Amount,
                    //PaymentType=item.PaymentType
                    //StatusName=item.statusId
                });
            }

            return allInvoiceVM;
        }

    }
}
