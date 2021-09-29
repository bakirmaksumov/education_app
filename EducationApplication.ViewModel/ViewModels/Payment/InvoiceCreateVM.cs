using EducationApplication.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApplication.ViewModel.ViewModels.Payment
{
    public class InvoiceCreateVM
    {
        [Display(Name = "Student Name")]
        public int studentList { get; set; }

        [Display(Name = "University Name")]
        public string UniversityName { get; set; }
        
        [Display(Name = "Amount")]
        public string Amount { get; set; }
        public bool isCashCard { get; set; }
        public Invoice ToViewModel(InvoiceCreateVM modelVM, User usr)
        {
            var ViewToModelInvoice = new Invoice()
            {
                UserId=modelVM.studentList,
                SchoolId=1,
                Amount =Convert.ToInt16(modelVM.Amount),
                IsCash=isCashCard,
                CreateDate=DateTime.Now,
                ModifyDate=DateTime.Now,
                CreatedBy=usr.Id,
                ModifiedBy=usr.Id
            };

            return ViewToModelInvoice;

        }

    }
}
