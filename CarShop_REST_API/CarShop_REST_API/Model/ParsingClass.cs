using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop_REST_API.Model
{
    public class ParsingClass
    {
        public WorkOrder WorkOrder { get; set; }
        public List<Item> Items { get; set; }

        public ParsingClass(WorkOrder workOrder, List<Item> items)
        {
            WorkOrder = workOrder;
            Items = items;
        }
    }
}
