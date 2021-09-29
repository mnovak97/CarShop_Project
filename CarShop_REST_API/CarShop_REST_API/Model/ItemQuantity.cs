using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop_REST_API.Model
{
    public class ItemQuantity
    {
        public Item Item { get; set; }
        public int Quantity { get; set; }

        public ItemQuantity(Item item, int quantity)
        {
            Item = item;
            Quantity = quantity;
        }
    }
}
