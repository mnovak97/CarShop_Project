using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop_REST_API.Model
{
    public class WorkOrder
    {
        [Key]
        public int IDWorkOrder { get; set; }
        public int Number { get; set; }
        public DateTime DateOfWorkOrder { get; set; }
        public string CarType { get; set; }
        public string RegistrationPlate { get; set; }
        public string Description { get; set; }
        public int ManufacturingYear { get; set; }
        public long Km { get; set; }
        public bool Warranty { get; set; }
        public bool Done { get; set; }
        public bool Assigned { get; set; }
        public string Comment { get; set; }
        public double TotalPrice { get; set; }
        public virtual User User { get; set; }
        public virtual Buyer Buyer { get; set; }
        public virtual ICollection<WorkOrdersItems> WorkOrdersItems { get; set; }
        public virtual ICollection<ReceiptWorkOrders> ReceiptWorkOrders { get; set; }

    }
}
