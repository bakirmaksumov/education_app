using EducationApplication.Data.Infrastructure;
using EducationApplication.Data.Repository.Interfaces.Payment;
using EducationApplication.Model.Models;
using EducationApplication.Service.Services.Interfaces.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApplication.Service.Services.Payment
{
   public class InvoiceService : BaseService<Invoice>, IInvoiceService
    {
        public InvoiceService(IInvoiceRepository repository,
                        IUnitOfWork unitOfWork)
         : base(repository, unitOfWork)
        {
        }

        public bool Create(Invoice invoice)
        {
            try
            {
                this._repository.Add(invoice);
                Save();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Edit(Invoice invoice)
        {
            try
            {
                this._repository.Update(invoice);
                Save();
                return true;
            }
            catch
            { return false; }
        }

        public Invoice GetUserByID(int id)
        {
            var roles = this._repository.Get(u => u.Id == id);
            return roles;
        }

        public List<Invoice> GetAllInvoice()
        {
            var invoice= _repository.GetAll().ToList();
            return invoice;
        }
    }
}
