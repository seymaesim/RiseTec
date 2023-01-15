using FluentAssertions;
using Rehber_CRUD.Controllers;
using Rehber_Report.Controllers;
using RiseCase.DataAcces.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rehber_CRUD.Test.Controller
{
    public  class RiseDirectoryReportControllerTests
    {
        private readonly Context _context;

        [Fact]
        public void GGetUserDetailReport_Ok()
        {
            //Arrange
            RiseDirectoryReportController ct = new RiseDirectoryReportController(_context);

            //Act
            var users = ct.GetUserDetailReport();

            //Assert
            users.Should().NotBeNull();

        }
        [Fact]
        public void GetLocationUserCountReport_Ok()
        {
            //Arrange
            RiseDirectoryReportController ct = new RiseDirectoryReportController(_context);

            //Act
            var users = ct.GetLocationUserCountReport();

            //Assert
            users.Should().NotBeNull();

        }

        [Fact]
        public void GetLocationParameterCountReport_Ok()
        {
            string location = string.Empty;
            
            //Arrange
            RiseDirectoryReportController ct = new RiseDirectoryReportController(_context);

            //Act
            var users = ct.GetLocationParameterCountReport(location);

            //Assert
            users.Should().NotBeNull();

        }
    }
}
