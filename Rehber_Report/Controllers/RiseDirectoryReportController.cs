using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RiseCase.Bussines.Concrete;
using RiseCase.Bussines.DAL;
using RiseCase.Bussines.SqlInjection;
using RiseCase.DataAcces.Concrete;
using RiseCase.DataAcces.EntityFramework;
using System.Net.Mime;

namespace Rehber_Report.Controllers
{
    [Route("api/[controller]/[action]")]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    [ApiController]
    public class RiseDirectoryReportController : ControllerBase
    {

        private readonly Context _context;
        UserManager _userManager = new UserManager(new EfUserDAL());
        ContactManager _contactManager = new ContactManager(new EfContactDAL());
        KindManager _kindManager = new KindManager(new EfKindDAL());
        ReportsManager _reportManager = new ReportsManager(new Context());

        bool Sonuc = false;
        public RiseDirectoryReportController(Context context)
        {
            _context = context;

        }


        [HttpGet(Name = "ListByIdUser")]
        public IActionResult GetUserDetailReport()
        {

            var row = _reportManager.UserDetailList();
            if (row != null)
            {
                return Ok(row);
            }
            else
            {

                return NoContent();
            }
          
        }
        [HttpGet(Name = "ListLotaciotUserCount")]
        public IActionResult GetLocationUserCountReport()
        {

            var row = _reportManager.UserLogationCountList();
            if (row != null)
            {
                return Ok(row);
            }
            else
            {

                return NoContent();
            }

        }

        [HttpGet(Name = "ListLotaciotParameterUserCount")]
        public IActionResult GetLocationParameterCountReport(string Location)
        {
            //sql injection control
            Location = QueryStringControl.QueryClear(Location);

            var row = _reportManager.UserLocationCountParameterList(Location);
            if (row != null)
            {
                return Ok(row);
            }
            else
            {
                return NoContent();
            }

        }

    

        [HttpGet(Name = "ListLotaciotParameterUserNumberCount")]
        public IActionResult GetLocationParameterUserNumberCountReport(string Location)
        {
            //sql injection control
            Location = QueryStringControl.QueryClear(Location);

            var row = _reportManager.UserLocationNumberCountParameterList(Location);
            if (row != null)
            {
                return Ok(row);
            }
            else
            {
                return NoContent();
            }

        }
    }
}
