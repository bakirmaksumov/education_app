using Autofac;
using EducationApplication.Data.Repository.Account;
using EducationApplication.Data.Repository.Certificate;
using EducationApplication.Data.Repository.Grant;
using EducationApplication.Data.Repository.Interfaces.Account;
using EducationApplication.Data.Repository.Interfaces.Certificate;
using EducationApplication.Data.Repository.Interfaces.Grant;
using EducationApplication.Data.Repository.Interfaces.Payment;
using EducationApplication.Data.Repository.Payment;
using EducationApplication.Service.Services.Account;
using EducationApplication.Service.Services.Certificate;
using EducationApplication.Service.Services.Grant;
using EducationApplication.Service.Services.Interfaces.Account;
using EducationApplication.Service.Services.Interfaces.Certificate;
using EducationApplication.Service.Services.Interfaces.Grant;
using EducationApplication.Service.Services.Interfaces.Payment;
using EducationApplication.Service.Services.Interfaces.School;
using EducationApplication.Service.Services.Payment;
using EducationApplication.Service.Services.School;
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
            builder.RegisterType<RoleRepository>().As<IRoleRepository>().InstancePerLifetimeScope();
            builder.RegisterType<InvoiceRepository>().As<IInvoiceRepository>().InstancePerLifetimeScope();
            builder.RegisterType<GrantTypeRepository>().As<IGrantTypeRepository>().InstancePerLifetimeScope();
            builder.RegisterType<StudentGrantsRepository>().As<IStudentGrantsRepository>().InstancePerLifetimeScope();


            //services
            builder.RegisterType<UserService>().As<IUserService>().InstancePerLifetimeScope();
            builder.RegisterType<UserInfoService>().As<IUserInfoService>().InstancePerLifetimeScope();
            builder.RegisterType<CertificateTypeService>().As<ICertificateTypeService>().InstancePerLifetimeScope();
            builder.RegisterType<StudentCertificatesService>().As<IStudentCertificatesService>().InstancePerLifetimeScope();
            builder.RegisterType<CertificateTemplatesService>().As<ICertificateTemplatesService>().InstancePerLifetimeScope();
            builder.RegisterType<RoleService>().As<IRoleService>().InstancePerLifetimeScope();
            builder.RegisterType<InvoiceService>().As<IInvoiceService>().InstancePerLifetimeScope();
            builder.RegisterType<SchoolFromAPIService>().As<ISchoolFromAPIService>().InstancePerLifetimeScope();
            builder.RegisterType<GrantTypeService>().As<IGrantTypeService>().InstancePerLifetimeScope();
            builder.RegisterType<StudentGrantsService>().As<IStudentGrantsService>().InstancePerLifetimeScope();
        }
    }
}
