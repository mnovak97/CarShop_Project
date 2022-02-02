using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop_REST_API.Model
{
    public enum State
    {
        NotFinished,
        Working,
        Finished
    }
    public class Appointment
    {
        [Key]
        public int IDAppointment { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public UserMobile User { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public State State { get; set; }

    }
}
