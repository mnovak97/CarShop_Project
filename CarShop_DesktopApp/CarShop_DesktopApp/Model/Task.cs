using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop_DesktopApp.Model
{
    public class Task
    {
        public int IDTask { get; set; }
        public User User { get; set; }
        public WorkOrder WorkOrder { get; set; }
        public bool Completed { get; set; }


        public Task(User user,WorkOrder workOrder)
        {
            User = user;
            WorkOrder = workOrder;
            Completed = false;
        }
    }
}
