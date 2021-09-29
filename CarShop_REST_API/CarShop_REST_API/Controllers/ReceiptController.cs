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
    public class ReceiptController : ControllerBase
    {
        [HttpGet("all")]
        public List<Receipt> GetReceipts()
        {
            return CarShopRepository.GetReceipts();
        }

        [HttpPost("addReceipt")]
        public void addReceipt([FromBody]ParsingClass parsingClass)
        {
            try
            {
                CarShopRepository.AddReceipt(parsingClass.Receipt);
                CarShopRepository.AddReceiptItems(parsingClass.WorkOrders,parsingClass.Receipt.User.IDUser);
                Response.StatusCode = StatusCodes.Status200OK;
            }
            catch (Exception)
            {
                Response.StatusCode = StatusCodes.Status400BadRequest;
            }
        }
    }
}
