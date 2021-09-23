﻿using Autofac;
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
            builder.RegisterType<UserInfoRepository>().As<IUserInfoRepository>().InstancePerLifetimeScope();
            builder.RegisterType<RoleRepository>().As<IRoleRepository>().InstancePerLifetimeScope();

            //services
            builder.RegisterType<UserService>().As<IUserService>().InstancePerLifetimeScope();
            builder.RegisterType<UserInfoService>().As<IUserInfoService>().InstancePerLifetimeScope();
            builder.RegisterType<RoleService>().As<IRoleService>().InstancePerLifetimeScope();
        }
    }
}
