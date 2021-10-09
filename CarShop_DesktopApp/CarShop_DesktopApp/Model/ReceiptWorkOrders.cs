using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop_DesktopApp.Model
{
    class ReceiptWorkOrders
    {
        public Receipt Receipt { get; set; }
        public List<WorkOrder> WorkOrders { get; set; }

        public ReceiptWorkOrders(Receipt receipt,List<WorkOrder> workOrders)
        {
            Receipt = receipt;
            WorkOrders = workOrders;
        }
    }
}
