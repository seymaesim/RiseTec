using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rehber_CRUD.DAL;
using RiseCase.Bussines.Concrete;
using RiseCase.DataAcces.Concrete;
using RiseCase.DataAcces.EntityFramework;
using RiseCase.Entity.Concrete;
using System.Net.Mime;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Rehber_CRUD.Controllers
{
    [Route("api/[controller]/[action]")]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    [ApiController]
    public class RiseDirectoryController : ControllerBase
    {
        private readonly Context _context;
        UserManager _userManager = new UserManager(new EfUserDAL());
        ContactManager _contactManager = new ContactManager(new EfContactDAL());
        KindManager _kindManager = new KindManager(new EfKindDAL());

        bool Sonuc = false;

        public RiseDirectoryController(Context context)
        {
            _context = context;
        }

        [HttpPost(Name = "AddUser")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult UserSaveOrder([FromBody]User orderModel)
        {
            //create
            if (orderModel == null)
                return BadRequest(ModelState);

            var users = _userManager.T_GetList().Where(x => x.Ad?.Trim().ToUpper() == orderModel.Ad?.Trim().ToUpper()).FirstOrDefault();

            if (users != null)
            {
                ModelState.AddModelError("", "Kişi bilgileri rehberde mevcuttur.");
                return StatusCode(422, ModelState);
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (string.IsNullOrEmpty(orderModel.Ad) || string.IsNullOrEmpty(orderModel.SoyAd) || string.IsNullOrEmpty(orderModel.Firma))
            {
                ModelState.AddModelError("", "Yetersiz Bilgi");
                return StatusCode(203, orderModel);
            }
            if (orderModel.Ad == " " || orderModel.SoyAd == " " || orderModel.Firma == " ")
            {
                ModelState.AddModelError("", "Yetersiz Bilgi");
                return StatusCode(203, ModelState);
            }

            _userManager.T_Add(orderModel);

            return Ok("Kişi rehbere eklenmiştir.");
        }


        [HttpPost(Name = "AddContact")]
        public bool ContactSaveOrder([FromBody]Contact orderModel)
        {
            try
            {
                var kind = _kindManager.T_GetByID(orderModel.KindID);
                var user = _userManager.T_GetByID(orderModel.UserID);
                var contact = _contactManager.T_GetList().Where(x => x.KindID == orderModel.KindID && x.UserID == orderModel.UserID && x.ContactValue == orderModel.ContactValue);

                if (kind == null || user == null)
                {
                    return Sonuc;
                }
                else if (contact == null)
                {
                    _contactManager.T_Add(orderModel);
                    Sonuc = true;
                }
                else
                {
                    _contactManager.T_Update(orderModel);
                    Sonuc = true;
                }
                return Sonuc;
            }
            catch (Exception)
            {
                return Sonuc;
            }

        }

        [HttpPut(Name = "UpdateContact")]
        public bool ContactUpdateOrder([FromBody] Contact orderModel)
        {
            try
            {
                var kind = _kindManager.T_GetByID(orderModel.KindID);
                var user = _userManager.T_GetByID(orderModel.UserID);
                var contact = _contactManager.T_GetList().Where(x => x.KindID == orderModel.KindID && x.UserID == orderModel.UserID && x.ContactValue == orderModel.ContactValue);

                if (kind == null || user == null)
                {
                    return Sonuc;
                }
                else
                {
                   _contactManager.T_Update(orderModel);
                    Sonuc = true;
                }
                return Sonuc;
            }
            catch (Exception)
            {
                return Sonuc;
            }

        }

        [HttpDelete(Name = "DeleteByIDUser")]
        public bool DeleteUserById([FromQuery] int id)
        {
            User userModel = new User();
            try
            {
                userModel = _userManager.T_GetByID(id);
                if (userModel != null)
                {
                    _userManager.T_Delete(userModel);
                    Sonuc = true;
                }
                return Sonuc;
            }
            catch (Exception)
            {
                return Sonuc;
            }
        }


        [HttpGet(Name = "ListUser")]
        public IActionResult GetUser()
        {
            var users = _userManager.T_GetList().ToList<User>();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(users);
        }

        [HttpGet(Name = "ListByIdUser")]
        public IActionResult GetUserById([FromQuery]int id)
        {
           
            var row = _userManager.T_GetByID(id);
            if (row != null)
            {
                return Ok(new UserDAL()
                {
                    Ad = row.Ad ?? string.Empty,
                    Soyad = row.SoyAd ?? string.Empty,
                    Firma = row.Firma ?? string.Empty
                });
            }
            else
            {

                return NoContent();
            }

        }



    }
}
