using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop_DesktopApp.Model
{
    class WorkOrder
    {
        [Browsable(false)]
        public int IDWorkOrder { get; set; }
        public int Number { get; set; }
        public DateTime DateOfWorkOrder { get; set; }
        [Browsable(false)]
        public string CarType { get; set; }
        [Browsable(false)]
        public string RegistrationPlate { get; set; }
        public string Description { get; set; }
        [Browsable(false)]
        public int ManufacturingYear { get; set; }
        [Browsable(false)]
        public long Km { get; set; }
        [Browsable(false)]
        public bool Warranty { get; set; }
        [Browsable(false)]
        public bool Done { get; set; }
        [Browsable(false)]
        public string Comment { get; set; }
        public double TotalPrice { get; set; }
        [Browsable(false)]
        public virtual User User { get; set; }
        [Browsable(false)]
        public virtual Buyer Buyer { get; set; }

        public WorkOrder(int number,DateTime date,string carType,string registrationPlate,string description,int manufacturingYear,long km,bool warranty,bool done,string comment,double totalPrice,User user,Buyer buyer)
        {
            Number = number;
            DateOfWorkOrder = date;
            CarType = carType;
            RegistrationPlate = registrationPlate;
            Description = description;
            ManufacturingYear = manufacturingYear;
            Km = km;
            Warranty = warranty;
            Done = done;
            Comment = comment;
            TotalPrice = totalPrice;
            User = user;
            Buyer = buyer;
        }

       
    }
}
