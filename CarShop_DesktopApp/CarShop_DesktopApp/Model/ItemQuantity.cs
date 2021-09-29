﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop_DesktopApp.Model
{
    public class ItemQuantity
    {
        public Item Item { get; set; }
        public int Quantity { get; set; }

        public ItemQuantity(Item item,int quantity)
        {
            Item = item;
            Quantity = quantity;
        }
    }
}
