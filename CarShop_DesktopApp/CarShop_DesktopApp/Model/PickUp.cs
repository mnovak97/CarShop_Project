using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop_DesktopApp.Model
{
    public class PickUp
    {
        public int IDPickup { get; set; }
        public string Address { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public bool Done { get; set; }
        public UserMobile User { get; set; }

        public PickUp(string address,double longitude,double latitude,bool done,UserMobile user)
        {
            Address = address;
            Longitude = longitude;
            Latitude = latitude;
            Done = done;
            User = user;
        }
    }
}
