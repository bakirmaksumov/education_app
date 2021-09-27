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
        public Invoice ToViewModel(InvoiceCreateVM modelVM)
        {
            var ViewToModelInvoice = new Invoice()
            {
                UserId=modelVM.studentList,
                //change for schoolName
                //SchoolName=modelVM.UniversityName,
                Amount =Convert.ToInt16(modelVM.Amount),
                //create paytype
                //PayType=modelVM.isCashCard,
                CreateDate=DateTime.Now,
                ModifyDate=DateTime.Now,
                //CreatedBy=
                //ModifiedBy=
                //dateofpayment make nullable

            };

            return ViewToModelInvoice;

        }

    }
}
