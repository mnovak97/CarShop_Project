using CarShop_DesktopApp.DAL;
using CarShop_DesktopApp.Extensions;
using CarShop_DesktopApp.Forms;
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

namespace CarShop_DesktopApp
{
    public partial class Items : UserControl
    {

        private string token;
        AddWorkOrder workOrder;
        public Items(string JWTToken)
        {
            token = JWTToken;
            InitializeComponent();
            btnNewItem.Text = "Add new item";
        }

        public Items(AddWorkOrder WorkOrder,string JWTToken)
        {
            token = JWTToken;
            workOrder = WorkOrder;
            InitializeComponent();
            btnNewItem.Text = "Select item";
        }

        private void Items_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            dataGridItems.DataSource = RestApiCallsHandler.GetItems(token);
            GridViewStyleExtension.SetStyle(dataGridItems);
        }

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            if (btnNewItem.Text == "Add new item")
            {
                AddItem addItemForm = new AddItem(token);
                addItemForm.FormBorderStyle = FormBorderStyle.FixedSingle;
                addItemForm.FormClosed += (s, args) => dataGridItems.DataSource = RestApiCallsHandler.GetItems(token);
                addItemForm.Show();
            }
           else if (btnNewItem.Text == "Select item")
            {
                int selectedrowIndex = dataGridItems.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dataGridItems.Rows[selectedrowIndex];
                Item selectedItem = (Item)selectedRow.DataBoundItem;
                workOrder.newItem(selectedItem);
                ((Form)this.TopLevelControl).Close();
            }
        }
    }
}
