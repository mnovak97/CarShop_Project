using CarShop_DesktopApp.CustomControls;
using CarShop_DesktopApp.DAL;
using CarShop_DesktopApp.Model;
using FontAwesome.Sharp;
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
        private User currentUser;
        private double totalPrice;
        public event EventHandler totalPriceChanged;
        protected virtual void OnTotalPriceChange()
        {
            if (totalPriceChanged != null)
                totalPriceChanged(this, EventArgs.Empty);
            if (totalPrice == 0)
            {
                lblTotalPrice.Visible = false;
            }
        }
        public double TotalPrice
        {
            get { return totalPrice; }
            set
            {
                totalPrice = value;
                OnTotalPriceChange();
            }
        }

        public ReceiptForm(string JWTToken,User user)
        {
            token = JWTToken;
            currentUser = user;
            InitializeComponent();
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            lblTotalPrice.Visible = false;
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
            placeHolder.Controls.Clear();
            TotalPrice = 0;
        }

        private void addWorkOrder(List<WorkOrder> buyerWorkOrders)
        {
            foreach (WorkOrder item in buyerWorkOrders)
            {
                if(item.Done == true)
                    cblWorkOrders.Items.Add(item);
            }
        }

        private void btnAddWorkOrders_Click(object sender, EventArgs e)
        {
            addSelectedWorkOrders();
            removeItems();
        }

        private void removeItems()
        {
            for (int i = cblWorkOrders.Items.Count - 1; i >= 0; i--)
            {
                if (cblWorkOrders.GetItemChecked(i))
                    cblWorkOrders.Items.RemoveAt(i);
            }
        }

        private void addSelectedWorkOrders()
        {
            for (int i = 0; i < cblWorkOrders.Items.Count; i++)
            {
                if (cblWorkOrders.GetItemChecked(i))
                {
                    WorkOrder order = (WorkOrder)cblWorkOrders.Items[i];
                    CustomLabel myLabel = new CustomLabel(order);
                    setClicks(myLabel);
                    placeHolder.Controls.Add(myLabel);
                    TotalPrice += order.TotalPrice;
                    lblTotalPrice.Text = TotalPrice.ToString() + "HRK";
                    lblTotalPrice.Visible = true;
                }
            }
        }

        private void setClicks(CustomLabel myLabel)
        {
            foreach (Control item in myLabel.Controls)
            {
                if (item is IconButton)
                {
                    if(((IconButton)item).IconChar == IconChar.Minus)
                        ((IconButton)item).Click += btnRemoveClick;
                    else if (((IconButton)item).IconChar == IconChar.EllipsisH)
                        ((IconButton)item).Click += btnInfoClick;

                }
            }
        }

        private void btnInfoClick(object sender, EventArgs e)
        {
            IconButton clicked = (IconButton)sender;
            WorkOrder workOrder = ((CustomLabel)clicked.Parent).workOrder;
            List<ItemQuantity> items = RestApiCallsHandler.GetWorkOrderItems(workOrder.IDWorkOrder, token);
            WorkOrderForm infoForm = new WorkOrderForm(token, workOrder, items);
            infoForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            infoForm.ShowDialog();
        }

        private void btnRemoveClick(object sender, EventArgs e)
        {
            IconButton clicked = (IconButton)sender;
            WorkOrder workOrder = ((CustomLabel)clicked.Parent).workOrder;
            placeHolder.Controls.Remove(clicked.Parent);
            cblWorkOrders.Items.Add(workOrder);
            TotalPrice -= workOrder.TotalPrice;
            lblTotalPrice.Text = TotalPrice.ToString() + "HRK";
        }

        private void btnNewReceipt_Click(object sender, EventArgs e)
        {
            Receipt newReceipt = new Receipt(DateTime.Now, TotalPrice, getMethod(), currentUser, getBuyer());
            ReceiptWorkOrders newReceiptWorkOrder = new ReceiptWorkOrders(newReceipt, getSelectedWorkOrders());
            if (RestApiCallsHandler.AddReceipt(newReceiptWorkOrder, token))
                MessageBox.Show("Receipt added!");
            else
                MessageBox.Show("Error");
        }
        private List<WorkOrder> getSelectedWorkOrders()
        {
            List<WorkOrder> workOrders = new List<WorkOrder>();
            foreach (Control item in placeHolder.Controls)
            {
                if (item is CustomLabel)
                {
                    WorkOrder order = ((CustomLabel)item).workOrder;
                    workOrders.Add(order);
                }
            }
            return workOrders;
        }

        private Buyer getBuyer()
        {
            Buyer buyer = (Buyer)cbBuyer.SelectedItem;
            return buyer;
        }

        private PaymentMethod getMethod()
        {
            PaymentMethod method = (PaymentMethod)cbPaymentMethod.SelectedItem;
            return method;
        }
    }
}
