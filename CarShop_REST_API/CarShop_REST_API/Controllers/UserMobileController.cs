using CarShop_REST_API.DAL;
using CarShop_REST_API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop_REST_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserMobileController : ControllerBase
    {
        [HttpPost("addUserMobile")]
        public UserMobile addUserMobile([FromBody]UserMobile newUserMobile)
        {
            try
            {
                if (CarShopRepository.GetUserMobile(newUserMobile.Email) != null)
                {
                    return null;
                }
                CarShopRepository.AddUserMobile(newUserMobile);
                return CarShopRepository.GetUserMobile(newUserMobile.Email);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
