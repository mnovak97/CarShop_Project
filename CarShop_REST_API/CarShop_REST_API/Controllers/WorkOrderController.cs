﻿using CarShop_REST_API.Context;
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
    public class WorkOrderController : ControllerBase
    {
        [HttpGet("all")]
        public List<WorkOrder> GetWorkOrders()
        {
            return CarShopRepository.GetWorkOrders();
        }

        [HttpGet("number")]
        public int GetNumber()
        {
            List<WorkOrder> workOrders = CarShopRepository.GetWorkOrders();
            int number = workOrders[workOrders.Count - 1].IDWorkOrder;
            return number;
        }

        [HttpPost("addWorkOrder")]
        public void addWorkOrder([FromBody]ParsingClass parsingClass)
        {
            try
            {
                CarShopRepository.AddWorkOrder(parsingClass.WorkOrder);
                CarShopRepository.AddWorkOrderItems(parsingClass.Items, parsingClass.WorkOrder.User.IDUser);
                Response.StatusCode = StatusCodes.Status200OK;
            }
            catch (Exception)
            {
                Response.StatusCode = StatusCodes.Status400BadRequest;
            }
        }
    }
}
