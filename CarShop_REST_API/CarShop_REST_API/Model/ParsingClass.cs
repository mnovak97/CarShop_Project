using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop_REST_API.Model
{
    public class ParsingClass
    {
        public WorkOrder WorkOrder { get; set; }
        public List<ItemQuantity> Items { get; set; }
        public Receipt Receipt { get; set; }
        public List<WorkOrder> WorkOrders { get; set; }
    }
}
