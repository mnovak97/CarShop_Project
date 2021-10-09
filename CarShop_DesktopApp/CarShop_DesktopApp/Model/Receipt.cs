using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [Browsable(false)]
        public int IDReceipt { get; set; }
        [DisplayName("Date")]
        public DateTime DateOfReceipt { get; set; }
        [DisplayName("Total price")]
        public double TotalPrice { get; set; }
        [DisplayName("Payment method")]
        public PaymentMethod PaymentMethod { get; set; }
        [Browsable(false)]
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
