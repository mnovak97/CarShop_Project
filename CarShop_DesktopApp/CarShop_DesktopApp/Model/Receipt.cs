using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop_DesktopApp.Model
{
    public enum PaymentMethod
    {
        Cash,
        CreditCard
    }
    public class Receipt
    {
        public int IDReceipt { get; set; }
        public DateTime DateOfReceipt { get; set; }
        public double TotalPrice { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public virtual User User { get; set; }
        public virtual Buyer Buyer { get; set; }


        public Receipt(DateTime date,double totalPrice,PaymentMethod paymentMethod,User user,Buyer buyer)
        {
            DateOfReceipt = date;
            TotalPrice = totalPrice;
            PaymentMethod = paymentMethod;
            User = user;
            Buyer = buyer;
        }
    }
}
