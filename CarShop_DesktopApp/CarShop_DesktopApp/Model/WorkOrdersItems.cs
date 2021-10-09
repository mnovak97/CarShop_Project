using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop_DesktopApp.Model
{
    class WorkOrdersItems
    {
        public WorkOrder WorkOrder { get; set; }
        public List<ItemQuantity> Items { get; set; }
        public WorkOrdersItems(WorkOrder workOrder,List<ItemQuantity> items)
        {
            WorkOrder = workOrder;
            Items = items;
        }
    }
}
