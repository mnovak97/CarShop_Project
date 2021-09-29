using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop_REST_API.Model
{
    public class WorkOrdersItems
    {
        public int WorkOrderID { get; set; }
        public WorkOrder WorkOrder { get; set; }
        public int ItemID { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }


        public WorkOrdersItems(int workOrderID,int itemID,int quantity)
        {
            WorkOrderID = workOrderID;
            ItemID = itemID;
            Quantity = quantity;
        }
    }
}
