using EducationApplication.Data.Infrastructure;
using EducationApplication.Data.Repository.Interfaces.Payment;
using EducationApplication.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApplication.Data.Repository.Payment
{
   public class InvoiceRepository : RepositoryBase<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}
