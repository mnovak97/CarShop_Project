using CarShop_REST_API.DAL;
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
    public class TasksController : ControllerBase
    {
        [HttpPost("assignTask")]
        public void assignTask([FromBody]Model.Task newTask)
        {
            try
            {
                CarShopRepository.AssignTask(newTask);
                CarShopRepository.UpdateWorkOrder(newTask.WorkOrder);
                Response.StatusCode = StatusCodes.Status200OK;
            }
            catch (Exception)
            {
                Response.StatusCode = StatusCodes.Status400BadRequest;
            }
        }
    }
}
