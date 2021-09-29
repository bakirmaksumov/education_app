using EducationApplication.Controllers;
using EducationApplication.Model.Models;
using EducationApplication.Service.Services.Interfaces.Account;
using EducationApplication.ViewModel.ViewModels.Account;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;
using System.Linq;

namespace EducationApplication.Test
{
    public class AccountControllerTest
    {

        private readonly Mock<IRoleService> _mockRoleService;
        private readonly Mock<IUserService> _mockUserService;
        private readonly Mock<IUserInfoService> _mockUserInfoService;
        private readonly AccountController _controller;

        public AccountControllerTest()
        {

            _mockRoleService = new Mock<IRoleService>();
            _mockUserService=new Mock<IUserService>();
            _mockUserInfoService = new Mock<IUserInfoService>();
            //_mockRoleService.Setup(repo => repo.GetAll()).Returns(getAllRoles());
            _controller = new AccountController(_mockUserService.Object,_mockUserInfoService.Object,_mockRoleService.Object);
        }
        [Fact]
        public void Index_ActionExecutes_ReturnsRoleViewForIndex()
        {
            var result = _controller.Roles();
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_ReturnsRoleViewResultViewModel()
        {
          
            //var controller = new AccountController(_mockUserService.Object, _mockUserInfoService.Object, _mockRoleService.Object);
            //act
            var result = _controller.Roles();

            //Assert
            var viewResult=Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<RoleVM>>(viewResult.Model);
            Assert.Equal(getAllRoles().Count,model.Count());
            Assert.NotNull(viewResult);
            //Assert.Equal(nameof(_controller.Index), viewResult.ViewName);
            //Assert.NotNull(viewResult.ViewData);
            //Assert.Null(viewResult.ViewData);
        }

        [Fact]
        public void Index_AddNewRoleViewModel()
        {
            var mockRole = new Mock<IRoleService>();
            var mockUser=new Mock<IUserService>();
            var mockUserInfo=new Mock<IUserInfoService>();
            var controller = new AccountController(mockUser.Object, mockUserInfo.Object, mockRole.Object);
            var newRole = new RolesCreateVM()
            { Name = "test"};
            //Act
            var result = controller.RolesCreate(newRole);
            var roleVM = new RolesCreateVM();
            var res = roleVM.ToViewModel(newRole);
            //Assert
            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
           // Assert.Null(redirectToActionResult.ControllerName);
            Assert.Equal("Roles", redirectToActionResult.ActionName);
            mockRole.Verify(r => r.Create(res),Times.Once);

        }

        private List<RoleVM> getAllRoles()
        {
            var roles = new List<RoleVM>
            { 
              new RoleVM {Id=1, Name="admin" },
               new RoleVM {Id=2, Name="student" }
            };

            return roles;
        }

    }
}
