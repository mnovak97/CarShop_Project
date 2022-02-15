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
        private bool carType, registrationPlate, buyer, description, comment, manufacturingYear, KM, boolItems = false;
        private int number;
        private string token;
        BindingList<Item> items;
        List<ItemQuantity> orderItems;
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
            addColumnquantity();
            btnAddWorkOrder.Text = "Add work order";
        }

        public WorkOrderForm(string JWTToken, User currentUser, WorkOrder selectedWorkOrder, List<ItemQuantity> itemsQuantity)
        {
            token = JWTToken;
            user = currentUser;
            items = new BindingList<Item>();
            orderItems = itemsQuantity;
            selected = selectedWorkOrder;
            InitializeComponent();
            showBuyers();
            setData();
            addColumnquantity();
            lblFormName.Text = "Update work order form";
            if (user.Role == Role.User)
            {
                btnAddWorkOrder.Visible = false;
            }
        }

        public WorkOrderForm(string JWTToken,WorkOrder selectedWorkOrder,List<ItemQuantity> itemsQuantity)
        {
            token = JWTToken;
            items = new BindingList<Item>();
            orderItems = itemsQuantity;
            selected = selectedWorkOrder;
            InitializeComponent();
            showBuyers();
            setData();
            addColumnquantity();
            lblFormName.Text = "Work order";
        }

        private void disableControls()
        {
            txtCarType.Enabled = false;
            txtRegistrationPlate.Enabled = false;
            cbBuyers.Enabled = false;
            txtDescription.Enabled = false;
            txtComment.Enabled = false;
            btnItemsList.Visible = false;
            txtManufacturingYear.Enabled = false;
            txtKm.Enabled = false;
            chBWarranty.Enabled = false;
            btnAddWorkOrder.Visible = false;
            Label lblTotalPrice = new Label();
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Text = "Total price: " + countTotalPrice().ToString() +" HRK";
            lblTotalPrice.Dock = DockStyle.Right;
            lblTotalPrice.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            tableLayoutItems.Controls.Add(lblTotalPrice);
        }

        private void addColumnquantity()
        {
            DataGridViewTextBoxColumn columnQnty = new DataGridViewTextBoxColumn();
            columnQnty.DataPropertyName = "QUANTITY";
            columnQnty.Name = "Quantity";
            columnQnty.ValueType = typeof(int);
            dataGridItemsWorkOrder.Columns.Add(columnQnty);
        }

        private void setData()
        {
            txtCarType.Texts = selected.CarType;
            txtComment.Texts = selected.Comment;
            txtDescription.Texts = selected.Description;
            txtKm.Texts = selected.Km.ToString();
            txtManufacturingYear.Texts = selected.ManufacturingYear.ToString();
            txtRegistrationPlate.Texts = selected.RegistrationPlate;
            setSelectedBuyer(selected.Buyer);
            lblAppointment.Visible = false;
            cbAppointment.Visible = false;
            if (selected.Warranty)
            {
                chBWarranty.Checked = true;
            }
            else
            {
                chBWarranty.Checked = false;
            }
           
        }

        private void setSelectedBuyer(Buyer buyer)
        {
            for (int i = 0; i < cbBuyers.Items.Count; i++)
            {
                if(cbBuyers.Items[i].ToString() == buyer.ToString())
                {
                    cbBuyers.SelectedItem = cbBuyers.Items[i];
                }
            }
        }

        private void AddWorkOrder_Load(object sender, EventArgs e)
        {
            dataGridItemsWorkOrder.DataSource = items;
            GridViewStyleExtension.SetStyle(dataGridItemsWorkOrder);
            if (lblFormName.Text == "Update work order form")
            {
                btnAddWorkOrder.Text = "Update work order";
                setItems(orderItems);
            }
            else if(lblFormName.Text == "Work order")
            {
                setItems(orderItems);
                disableControls();
            }


        }


        private void btnItemsList_Click(object sender, EventArgs e)
        {
            SelectItem selectItem = new SelectItem(this, token);
            selectItem.ShowDialog();
        }

        private void btnAddWorkOrder_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                if (btnAddWorkOrder.Text == "Add work order")
                {
                    addWorkOrder();
                }
                else if (btnAddWorkOrder.Text == "Update work order")
                {
                    updateWorkOrder();
                }

            }
        }

        private bool validateForm()
        {
            bool validationSuccessfull = false;

            if (string.IsNullOrEmpty(txtCarType.Texts))
                txtCarType.BorderColor = Color.Red;
            else if (!string.IsNullOrEmpty(txtCarType.Texts)) {
                txtCarType.BorderColor = SystemColors.MenuHighlight;
                carType = true; }

            if (string.IsNullOrEmpty(txtRegistrationPlate.Texts))
                txtRegistrationPlate.BorderColor = Color.Red;
            else if (!string.IsNullOrEmpty(txtRegistrationPlate.Texts))
            {
                txtRegistrationPlate.BorderColor = SystemColors.MenuHighlight;
                registrationPlate = true;
            }

            if (string.IsNullOrEmpty(cbBuyers.Texts))
                cbBuyers.BorderColor = Color.Red;
            else
            {
                cbBuyers.BorderColor = SystemColors.MenuHighlight;
                buyer = true;
            }

            if (string.IsNullOrEmpty(txtDescription.Texts))
                txtDescription.BorderColor = Color.Red;
            else if(!string.IsNullOrEmpty(txtDescription.Texts))
            {
                txtDescription.BorderColor = SystemColors.MenuHighlight;
                description = true;
            }

            if (string.IsNullOrEmpty(txtComment.Texts))
                txtComment.BorderColor = Color.Red;
            else if(!string.IsNullOrEmpty(txtComment.Texts))
            {
                txtComment.BorderColor = SystemColors.MenuHighlight;
                comment = true;
            }

            if (string.IsNullOrEmpty(txtManufacturingYear.Texts))
                txtManufacturingYear.BorderColor = Color.Red;
            else if(!string.IsNullOrEmpty(txtManufacturingYear.Texts))
            {
                txtManufacturingYear.BorderColor = SystemColors.MenuHighlight;
                manufacturingYear = true;
            }

            if (string.IsNullOrEmpty(txtKm.Texts))
                txtKm.BorderColor = Color.Red;
            else if (!string.IsNullOrEmpty(txtKm.Texts))
            {
                txtKm.BorderColor = SystemColors.MenuHighlight;
                KM = true;
            }

            if (items.Count() == 0)
                boolItems = false;
            else
                boolItems = true;

            if (carType && registrationPlate && buyer && description && comment && manufacturingYear && KM && boolItems)
                validationSuccessfull = true;

            return validationSuccessfull;
        }

        private void updateWorkOrder()
        {
            double totalPrice = countTotalPrice();
            Buyer buyer = getBuyer();
            populateWorkOrder(totalPrice, buyer);
            WorkOrdersItems workOrdersItems = new WorkOrdersItems(selected, getItems());
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
            if (lblAppointment.Visible == true)
            {
                Appointment appointment = (Appointment)cbAppointment.SelectedItem;
                WorkOrder newWorkOrder = new WorkOrder(number, DateTime.Now, txtCarType.Texts, txtRegistrationPlate.Texts, txtDescription.Texts, Convert.ToInt32(txtManufacturingYear.Texts), Convert.ToInt64(txtKm.Texts), chBWarranty.Checked, false, txtComment.Texts, totalPrice, user, buyer, appointment);
                WorkOrdersItems workOrderItems = new WorkOrdersItems(newWorkOrder, getItems());
                if (RestApiCallsHandler.AddWorkOrder(workOrderItems, token))
                {
                    MessageBox.Show("Work order added!");
                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }
            else
            {
                WorkOrder newWorkOrder = new WorkOrder(number, DateTime.Now, txtCarType.Texts, txtRegistrationPlate.Texts, txtDescription.Texts, Convert.ToInt32(txtManufacturingYear.Texts), Convert.ToInt64(txtKm.Texts), chBWarranty.Checked, false, txtComment.Texts, totalPrice, user, buyer,null);
                WorkOrdersItems workOrderItems = new WorkOrdersItems(newWorkOrder, getItems());
                if (RestApiCallsHandler.AddWorkOrder(workOrderItems, token))
                {
                    MessageBox.Show("Work order added!");
                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }
        }
        private void populateWorkOrder(double price, Buyer buyer)
        {
            selected.CarType = txtCarType.Texts;
            selected.RegistrationPlate = txtRegistrationPlate.Texts;
            selected.Description = txtDescription.Texts;
            selected.ManufacturingYear = Convert.ToInt32(txtManufacturingYear.Texts);
            selected.Km = Convert.ToInt64(txtKm.Texts);
            selected.Warranty = chBWarranty.Checked;
            selected.Comment = txtComment.Texts;
            selected.TotalPrice = price;
            selected.Buyer = buyer;
        }


        private List<ItemQuantity> getItems()
        {
            List<ItemQuantity> itemsQuantity = new List<ItemQuantity>();
            foreach (Item item in items)
            {
                int quantity = (int)dataGridItemsWorkOrder.Rows[items.IndexOf(item)].Cells[0].Value;
                ItemQuantity newItemQuantity = new ItemQuantity(item, quantity);
                itemsQuantity.Add(newItemQuantity);
            }
            return itemsQuantity;
        }

        private Buyer getBuyer()
        {
            Buyer buyer = (Buyer)cbBuyers.SelectedItem;
            return buyer;
        }

        private void cbBuyers_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Buyer buyer = (Buyer)cbBuyers.SelectedItem;
            List<Appointment> buyersAppointment = RestApiCallsHandler.GetBuyersAppointments(buyer.Email,token);
            if (buyersAppointment.Count > 0)
            {
                lblAppointment.Visible = true;
                cbAppointment.Visible = true;
                    showAppointemtns(buyersAppointment);
            }
        }

        private double countTotalPrice()
        {
            double price = 0;
            foreach (Item item in items)
            {
                price += item.Price * (int)dataGridItemsWorkOrder.Rows[items.IndexOf(item)].Cells[0].Value;
            }
            return price;
        }

        private void showAppointemtns(List<Appointment> appointments)
        {
            foreach (Appointment appointment in appointments)
            {
                cbAppointment.Items.Add(appointment);
            }
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
        private void setItems(List<ItemQuantity> workOrderItems)
        {
            foreach (ItemQuantity item in workOrderItems)
            {
                items.Add(item.Item);
                dataGridItemsWorkOrder.Rows[items.IndexOf(item.Item)].Cells[0].Value = item.Quantity;
            }
        }

        public void newItem(Item newItem)
        {
            checkIfItemIsAlreadyAdded(newItem);
        }

        private void checkIfItemIsAlreadyAdded(Item newItem)
        {
            var duplicate = items.FirstOrDefault(i => i.IDItem == newItem.IDItem);
            int quantity;
            if (duplicate == null)
            {
                items.Add(newItem);
                dataGridItemsWorkOrder.Rows[items.IndexOf(newItem)].Cells[0].Value = 1;
            }
            else
            {
                quantity = (int)dataGridItemsWorkOrder.Rows[items.IndexOf(duplicate)].Cells[0].Value;
                quantity++;
                dataGridItemsWorkOrder.Rows[items.IndexOf(duplicate)].Cells[0].Value = quantity;
            }
        }
        private void txtKm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtManufacturingYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
