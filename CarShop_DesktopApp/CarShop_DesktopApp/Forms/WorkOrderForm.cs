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
    public partial class WorkOrderForm : Form
    {
        private int number;
        private string token;
        BindingList<Item> items;
        User user;
        WorkOrder selected;
        public WorkOrderForm(string JWTToken, User currentUser)
        {
            token = JWTToken;
            user = currentUser;
            number = RestApiCallsHandler.GetWorkOrdersNumber(token);
            items = new BindingList<Item>();
            InitializeComponent();
            showBuyers();
            btnAddWorkOrder.Text = "Add work order";
        }
        public WorkOrderForm(string JWTToken,User currentUser,WorkOrder selectedWorkOrder,BindingList<Item> workOrderItems)
        {
            token = JWTToken;
            user = currentUser;
            items = workOrderItems;
            selected = selectedWorkOrder;
            InitializeComponent();
            showBuyers();
            setData();
        }

        private void setData()
        {
            txtCarType.Text = selected.CarType;
            txtComment.Text = selected.Comment;
            txtDescription.Text = selected.Description;
            txtKm.Text = selected.Km.ToString();
            txtManufacturingYear.Text = selected.ManufacturingYear.ToString();
            txtRegistrationPlate.Text = selected.RegistrationPlate;
            cbBuyers.SelectedItem = cbBuyers.Items[selected.Buyer.IDBuyer - 1];
            if (selected.Warranty)
            {
                chBWarranty.Checked = true;
            }
            else
            {
                chBWarranty.Checked = false;
            }
            if (selected.Done)
            {
                chBDone.Checked = true;
            }
            else
            {
                chBDone.Checked = false;
            }
            btnAddWorkOrder.Text = "Update work order";
        }

        private void AddWorkOrder_Load(object sender, EventArgs e)
        {
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
            if (btnAddWorkOrder.Text == "Add work order")
            {
                addWorkOrder();
            }
            else if(btnAddWorkOrder.Text =="Update work order")
            {
                updateWorkOrder();
            }
        }

        private void updateWorkOrder()
        {
            double totalPrice = countTotalPrice();
            Buyer buyer = getBuyer();
            populateWorkOrder(totalPrice,buyer);
            WorkOrdersItems workOrdersItems = new WorkOrdersItems(selected, getItems(items));
            if (RestApiCallsHandler.UpdateWorkOrder(workOrdersItems, token))
            {
                MessageBox.Show("Work order updated!");
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }


        private void addWorkOrder()
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
        private void populateWorkOrder(double price,Buyer buyer)
        {
            selected.CarType = txtCarType.Text;
            selected.RegistrationPlate = txtRegistrationPlate.Text;
            selected.Description = txtDescription.Text;
            selected.ManufacturingYear = Convert.ToInt32(txtManufacturingYear.Text);
            selected.Km = Convert.ToInt64(txtKm.Text);
            selected.Warranty = chBWarranty.Checked;
            selected.Done = chBDone.Checked;
            selected.Comment = txtComment.Text;
            selected.TotalPrice = price;
            selected.Buyer = buyer;
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
