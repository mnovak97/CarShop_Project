using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop_DesktopApp.Model
{
    class Buyer
    {
        [Browsable(false)]
        public int IDBuyer { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
        public string Address { get; set; }
        public string OIB { get; set; }


        public Buyer(string name,string email,string mobilePhone,string address,string oib)
        {
            Name = name;
            Email = email;
            MobilePhone = mobilePhone;
            Address = address;
            OIB = oib;
        }
        public override string ToString()
        {
            return Name + "," + OIB;
        }
    }
}
