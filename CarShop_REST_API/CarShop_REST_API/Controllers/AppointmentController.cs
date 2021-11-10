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

        [HttpGet("getUserAppointments/{idUser}")]
        public List<Appointment> GetUsersAppointments(int idUser)
        {
            return CarShopRepository.GetUserAppointments(idUser);
        }
        [HttpGet("getDateAppointments/{date}")]
        public List<Appointment> GetDateAppointments(string date)
        {
            var dateString = date.Replace("%2F", "/");
            return CarShopRepository.GetDateAppointments(dateString);
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
