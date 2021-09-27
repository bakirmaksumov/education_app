using EducationApplication.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApplication.Service.Services.Interfaces.Payment
{
    public interface IInvoiceService : IBaseService<Invoice>
    {
        bool Create(Invoice invoice);
        bool Edit(Invoice invoice);
        Invoice GetUserByID(int id);
        List<Invoice> GetAllInvoice();
    }
}
