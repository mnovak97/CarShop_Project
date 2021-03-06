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

        [HttpGet("getWorkOrderItems/{workOrderID:int}")]
        public List<ItemQuantity> GetWorkOrderItems([FromRoute]int workOrderID)
        {
            List<ItemQuantity> workOrderItems = CarShopRepository.GetWorkOrderItems(workOrderID);
            return workOrderItems;
        }

        [HttpPost("updateItem")]
        public void UpdateItem([FromBody]Item itemForUpdate)
        {
            try
            {
                CarShopRepository.UpdateItem(itemForUpdate);
                Response.StatusCode = StatusCodes.Status200OK;
            }
            catch (Exception)
            {
                Response.StatusCode = StatusCodes.Status400BadRequest;
            }
        }

        [HttpPost("deleteItem")]
        public void DeleteItem([FromBody]int itemID)
        {
            try
            {
                CarShopRepository.DeleteItem(itemID);
                Response.StatusCode = StatusCodes.Status200OK;
            }
            catch (Exception)
            {
                Response.StatusCode = StatusCodes.Status400BadRequest;
            }
        }

    }
}
