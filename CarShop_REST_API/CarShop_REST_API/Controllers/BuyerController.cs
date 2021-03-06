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
    public class BuyerController : ControllerBase
    {
        [HttpGet]
        public List<Buyer> GetBuyers()
        {
            return CarShopRepository.GetBuyers();
        }

        [HttpPost("addBuyer")]
        public void AddBuyer([FromBody]Buyer buyer)
        {
            try
            {
                CarShopRepository.AddBuyer(buyer);
                Response.StatusCode = StatusCodes.Status200OK;
            }
            catch (Exception)
            {
                Response.StatusCode = StatusCodes.Status400BadRequest;
            }
        }

        [HttpPost("updateBuyer")]
        public void UpdateBuyer([FromBody]Buyer buyerForUpdate)
        {
            try
            {
                CarShopRepository.UpdateBuyer(buyerForUpdate);
                Response.StatusCode = StatusCodes.Status200OK;
            }
            catch (Exception)
            {
                Response.StatusCode = StatusCodes.Status400BadRequest;
            }
        }

    }
}
