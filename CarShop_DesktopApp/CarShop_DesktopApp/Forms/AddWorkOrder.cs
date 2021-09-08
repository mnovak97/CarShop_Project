using CarShop_DesktopApp.DAL;
using CarShop_DesktopApp.Extensions;
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
    public partial class AddWorkOrder : Form
    {
        private int number;
        private string token;
        BindingList<Item> items;
        User user;
        
        public AddWorkOrder(string JWTToken, User currentUser)
        {
            token = JWTToken;
            user = currentUser;
            number = RestApiCallsHandler.GetWorkOrdersNumber(token);
            InitializeComponent();
        }
        private void AddWorkOrder_Load(object sender, EventArgs e)
        {
            showBuyers();
            items = new BindingList<Item>();
            dataGridItemsWorkOrder.DataSource = items;
            GridViewStyleExtension.SetStyle(dataGridItemsWorkOrder);
        }


        private void btnItemsList_Click(object sender, EventArgs e)
        {
            SelectItem selectItem = new SelectItem(this, token);
            selectItem.ShowDialog();
        }

        private void btnAddWorkOrder_Click(object sender, EventArgs e)
        {
            double totalPrice = countTotalPrice();
            Buyer buyer = getBuyer();
            WorkOrder newWorkOrder = new WorkOrder(number, DateTime.Now, txtCarType.Text, txtRegistrationPlate.Text, txtDescription.Text, Convert.ToInt32(txtManufacturingYear.Text), Convert.ToInt64(txtKm.Text), chBWarranty.Checked, chBDone.Checked, txtComment.Text, totalPrice, user, buyer);
            WorkOrdersItems workOrderItems = new WorkOrdersItems(newWorkOrder, getItems(items));
            if (RestApiCallsHandler.AddWorkOrder(workOrderItems, token))
            {
                MessageBox.Show("Work order added!");
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private List<Item> getItems(BindingList<Item> bindingItems)
        {
            List<Item> items = new List<Item>();
            foreach (Item item in bindingItems)
            {
                items.Add(item);
            }
            return items;
        }

        private Buyer getBuyer()
        {
            Buyer buyer = (Buyer)cbBuyers.SelectedItem;
            return buyer;
        }

        private double countTotalPrice()
        {
            double price = 0;
            foreach (Item item in items)
            {
                price += item.Price;
            }
            return price;
        }

        private void showBuyers()
        {
            List<Buyer> buyers = new List<Buyer>();
            buyers = RestApiCallsHandler.GetBuyers(token);
            foreach (Buyer buyer in buyers)
            {
                cbBuyers.Items.Add(buyer);
            }
        }

        public void newItem(Item newItem)
        {
            items.Add(newItem);
            dataGridItemsWorkOrder.Refresh();
        }
    }
}
