using EducationApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApplication.Data.Infrastructure
{
   public class DatabaseFactory: Disposable, IDatabaseFactory
    {
        private EFEdbContext _dataContext;
        public EFEdbContext Get()
        {
            return _dataContext ?? (_dataContext = new EFEdbContext());
        }
        protected override void DisposeCore()
        {
            _dataContext?.Dispose();
        }
    }
}
