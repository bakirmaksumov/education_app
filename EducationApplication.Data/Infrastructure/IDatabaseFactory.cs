using EducationApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApplication.Data.Infrastructure
{
    public interface IDatabaseFactory: IDisposable
    {
        EFEdbContext Get();
    }
}
