using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop_DesktopApp.Model
{
    class Item
    {
        [Browsable(false)]
        public int IDItem { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Code { get; set; }

        public Item(string title,double price,string code)
        {
            Title = title;
            Price = price;
            Code = code;
        }
    }
}
