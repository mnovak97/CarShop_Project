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
        WorkOrderForm workOrder;
        User user;
        public Items(string JWTToken, User currentUser)
        {
            token = JWTToken;
            user = currentUser;
            InitializeComponent();
            btnNewItem.Text = "Add new item";
        }


        public Items(WorkOrderForm WorkOrder,string JWTToken)
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
                addItemForm.ShowDialog();
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

        private void dataGridItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowIndex = dataGridItems.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridItems.Rows[selectedrowIndex];
            Item selectedItem = (Item)selectedRow.DataBoundItem;
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
            if (dgv.CurrentRow.Selected)
            {
                AddItem myForm = new AddItem(token, selectedItem);
                myForm.FormBorderStyle = FormBorderStyle.FixedSingle;
                myForm.FormClosed += (s, args) => dataGridItems.Refresh();
                myForm.ShowDialog();
            }
        }

       
    }
}
