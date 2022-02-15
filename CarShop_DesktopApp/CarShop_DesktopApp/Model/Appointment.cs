using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop_DesktopApp.Model
{
    public enum State
    {
        NotFinished,
        Working,
        Finished
    }
    public class Appointment
    {
        public int IdAppointment { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public UserMobile User { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public State State { get; set; }

        public Appointment(string date,string time,UserMobile user,string customerName,string customerPhone,State state)
        {
            Date = date;
            Time = time;
            User = user;
            CustomerName = customerName;
            CustomerPhone = customerPhone;
            State = State;
        }
        public override string ToString()
        {
            return Date + "," + Time;
        }
    }
}
