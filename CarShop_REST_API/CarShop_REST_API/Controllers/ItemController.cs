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
    [Authorize]
    public class ItemController : ControllerBase
    {
        [HttpGet("all")]
        public List<Item> GetItems()
        {
            return CarShopRepository.GetItems();
        }

        [HttpPost("addItem")]
        [Authorize]
        public void AddItem([FromBody] Item item)
        {
            try
            {
                CarShopRepository.AddItem(item);
                Response.StatusCode = StatusCodes.Status200OK;
            }
            catch (Exception)
            {
                Response.StatusCode = StatusCodes.Status400BadRequest;
            }
        }

    }
}
