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
    public class AppointmentController : ControllerBase
    {
        [HttpGet("getAppointments")]
        public List<Appointment> Get()
        {
            return CarShopRepository.GetAppointments();
        }

        [HttpPost("getUserAppointments")]
        public List<Appointment> GetUsersAppointments([FromBody] int idUser)
        {
            return CarShopRepository.GetUserAppointments(idUser);
        }
        
        [HttpPost("addAppointment")]
        public Appointment addAppointment([FromBody]Appointment appointment)
        {
            try
            {
                CarShopRepository.AddAppointment(appointment);
                return CarShopRepository.GetAppointment(appointment.User.IDUserMobile);
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
