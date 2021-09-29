using CarShop_DesktopApp.DAL;
using CarShop_DesktopApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShop_DesktopApp.Forms
{
    public partial class ReceiptForm : Form
    {
        private string token;

        public ReceiptForm(string JWTToken)
        {
            token = JWTToken;
            InitializeComponent();
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            cbPaymentMethod.DataSource = Enum.GetValues(typeof(PaymentMethod));
            showBuyers();
        }

        private void showBuyers()
        {
            List<Buyer> buyers = new List<Buyer>();
            buyers = RestApiCallsHandler.GetBuyers(token);
            foreach (Buyer buyer in buyers)
            {
                cbBuyer.Items.Add(buyer);
            }
        }

        private void cbBuyer_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            cblWorkOrders.Items.Clear();
            Buyer buyer = (Buyer)cbBuyer.SelectedItem;
            List<WorkOrder> buyerWorkOrders = RestApiCallsHandler.GetBuyersWorkOrders(buyer.IDBuyer,token);
            addWorkOrder(buyerWorkOrders);
        }

        private void addWorkOrder(List<WorkOrder> buyerWorkOrders)
        {
            foreach (WorkOrder item in buyerWorkOrders)
            {
                cblWorkOrders.Items.Add(item);
            }
        }
    }
}
