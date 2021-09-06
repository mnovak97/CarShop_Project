using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop_REST_API.Model
{
    public class Item
    {
        [Key]
        public int IDItem { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Code { get; set; }
        public virtual ICollection<WorkOrdersItems> WorkOrdersItems { get; set; }

    }
}
