using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop_REST_API.Model
{
    public class ReceiptWorkOrders
    {
        public int ReceiptID { get; set; }
        public Receipt Receipt { get; set; }
        public int WorkOrderID { get; set; }
        public WorkOrder WorkOrder { get; set; }

        public ReceiptWorkOrders(int receiptID,int workOrderID)
        {
            ReceiptID = receiptID;
            WorkOrderID = workOrderID;
        }
    }
}
