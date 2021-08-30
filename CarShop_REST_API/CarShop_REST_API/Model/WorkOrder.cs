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
        public bool Warranty { get; set; }
        public bool Done { get; set; }
        public double TotalPrice { get; set; }
        public virtual User User { get; set; }
        public virtual Buyer Buyer { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
