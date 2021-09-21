using Autofac;
using EducationApplication.Data.Repository.Account;
using EducationApplication.Data.Repository.Certificate;
using EducationApplication.Data.Repository.Interfaces.Account;
using EducationApplication.Data.Repository.Interfaces.Certificate;
using EducationApplication.Service.Services.Account;
using EducationApplication.Service.Services.Certificate;
using EducationApplication.Service.Services.Interfaces.Account;
using EducationApplication.Service.Services.Interfaces.Certificate;
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
            builder.RegisterType<UserInfoRepository>().As<IUserInfoRepository>().InstancePerLifetimeScope();
            builder.RegisterType<CertificateTypeRepository>().As<ICertificateTypeRepository>().InstancePerLifetimeScope();
            builder.RegisterType<StudentCertificatesRepository>().As<IStudentCertificatesRepository>().InstancePerLifetimeScope();
            builder.RegisterType<CertificateTemplatesRepository>().As<ICertificateTemplatesRepository>().InstancePerLifetimeScope();

            //services
            builder.RegisterType<UserService>().As<IUserService>().InstancePerLifetimeScope();
            builder.RegisterType<UserInfoService>().As<IUserInfoService>().InstancePerLifetimeScope();
            builder.RegisterType<CertificateTypeService>().As<ICertificateTypeService>().InstancePerLifetimeScope();
            builder.RegisterType<StudentCertificatesService>().As<IStudentCertificatesService>().InstancePerLifetimeScope();
            builder.RegisterType<CertificateTemplatesService>().As<ICertificateTemplatesService>().InstancePerLifetimeScope();
        }
    }
}
