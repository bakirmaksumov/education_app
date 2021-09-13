using EducationApplication.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApplication.Data.Infrastructure
{
   public class DatabaseFactory: Disposable, IDatabaseFactory
    {
        private educationdbContext _dataContext;
        public educationdbContext Get()
        {
            return _dataContext ?? (_dataContext = new educationdbContext());
        }
        protected override void DisposeCore()
        {
            _dataContext?.Dispose();
        }
    }
}
