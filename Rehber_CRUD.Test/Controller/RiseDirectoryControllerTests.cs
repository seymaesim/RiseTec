using FakeItEasy;
using FluentAssertions;
using NUnit.Framework;
using Rehber_CRUD.Controllers;
using RiseCase.Bussines.Concrete;
using RiseCase.DataAcces.Concrete;
using RiseCase.DataAcces.EntityFramework;
using RiseCase.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rehber_CRUD.Test.Controller
{
    public class RiseDirectoryControllerTests
    {
        private readonly Context _context;

        [Fact]
        public void GGetUserDetailReport_Ok()
        {
            //Arrange
            RiseDirectoryController ct = new RiseDirectoryController(_context);

            //Act
            var users = ct.GetUser();

            //Assert
            users.Should().NotBeNull();

        }

        [Fact]
        public void GetUserById_Return_Ok()
        {
            //userID
            int id = 0;
            //Arrange
            RiseDirectoryController ct = new RiseDirectoryController(_context);

            //Act
            var users = ct.GetUserById(id);

            //Assert
            users.Should().NotBeNull();

        }

        [Fact]
        public void UserSaveOrder_Return_Ok()
        {
            //kayıt edilecek paratmetrelerin yazılması gerekmektedir.
            User model = new User();
            model.ID = 0;
            model.Ad = "";
            model.SoyAd = "";
            model.Firma = "";

            //Arrange
            RiseDirectoryController ct = new RiseDirectoryController(_context);

            //Act
            var users = ct.UserSaveOrder(model);

            //Assert
            if (users != null)
            {
                users.Should().NotBeNull();
            }

        }


        [Fact]
        public void DeleteUserById_Return_Ok()
        {
            //silinecek userID verilir.
            int id = 0;
            //Arrange
            RiseDirectoryController ct = new RiseDirectoryController(_context);

            //Act
            var users = ct.DeleteUserById(id);

            //Assert
            if (users != null)
            {
                users.Should().BeTrue();
            }
            users.Should().BeFalse();
        }
    }
}
