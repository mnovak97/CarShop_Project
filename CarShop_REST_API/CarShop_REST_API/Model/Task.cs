using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop_REST_API.Model
{
    public class Task
    {
        [Key]
        public int IDTask { get; set; }
        public User User { get; set; }
        public WorkOrder WorkOrder { get; set; }
        public bool Completed { get; set; }

    }
}
