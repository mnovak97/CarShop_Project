using CarShop_REST_API.Context;
using CarShop_REST_API.DAL;
using CarShop_REST_API.Model;
using Microsoft.AspNetCore.Authorization;
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
    public class UserController : ControllerBase
    {
      
        [HttpGet]
        public List<User> GetUsers()
        {
            return CarShopRepository.GetUsers();
        }
        [Authorize]
        [HttpGet("getWorkers")]
        public List<User> GetWorkers()
        {
            return CarShopRepository.GetWorkers();
        }

      
    }
}
