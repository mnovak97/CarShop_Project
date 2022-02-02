using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop_REST_API.Model
{
    public enum PaymentMethod
    {
        Cash,
        CreditCard
    }
    public class Receipt
    {
        [Key]
        public int IDReceipt { get; set; }
        public DateTime DateOfReceipt { get; set; }
        public double TotalPrice { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public virtual User User { get; set; }
        public virtual Buyer Buyer { get; set; }
        public virtual ICollection<ReceiptWorkOrders> ReceiptWorkOrders { get; set; }
    }
}
