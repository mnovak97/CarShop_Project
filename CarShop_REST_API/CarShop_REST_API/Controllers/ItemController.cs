using CarShop_REST_API.Context;
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
    public class ItemController : ControllerBase
    {
        private DatabaseContext db = new DatabaseContext();

        [HttpGet]
        public List<Item> GetItems()
        {
            return db.Items.ToList();
        }
    }
}
