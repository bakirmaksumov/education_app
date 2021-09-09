using Autofac;
using EducationApplication.Data.Repository.Account;
using EducationApplication.Data.Repository.Interfaces.Account;
using EducationApplication.Service.Services.Account;
using EducationApplication.Service.Services.Interfaces.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationApplication.Common
{
    public class MyAutofacModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            //repository
            builder.RegisterType<UserRepository>().As<IUserRepository>().InstancePerLifetimeScope();

            //services
            builder.RegisterType<UserService>().As<IUserService>().InstancePerLifetimeScope();
        }
    }
}
