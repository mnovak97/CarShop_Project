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
    public class PickUpController : ControllerBase
    {
        [HttpPost("addPickUp")]
        public PickUp addPickUpRequest([FromBody]PickUp pickUpRequest)
        {
            try
            {
                CarShopRepository.AddPickUpRequest(pickUpRequest);
                return CarShopRepository.GetUserPickUpRequest(pickUpRequest.User.IDUserMobile);
            }
            catch (Exception)
            {
                return null;
            }
        }
        [Authorize]
        [HttpGet("getPickUps")]
        public List<PickUp> Get()
        {
            return CarShopRepository.GetPickups();
        }
        [HttpPost("completePickup")]
        public void completePickup([FromBody] PickUp pickUp)
        {
            try
            {
                CarShopRepository.CompletePickup(pickUp);
                Response.StatusCode = StatusCodes.Status200OK;
            }
            catch (Exception)
            {
                Response.StatusCode = StatusCodes.Status400BadRequest;
            }
        }

    }
}
