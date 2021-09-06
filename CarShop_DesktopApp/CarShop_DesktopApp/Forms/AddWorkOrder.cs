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
        private string token;
        BindingList<Item> items;
        public AddWorkOrder(string JWTToken)
        {
            token = JWTToken;
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
            selectItem.Show();
        }

        private void btnAddWorkOrder_Click(object sender, EventArgs e)
        {

        }
        private void showBuyers()
        {
            List<Buyer> buyers = new List<Buyer>();
            buyers = RestApiCallsHandler.GetBuyers(token);
            foreach (Buyer buyer in buyers)
            {
                cbBuyers.Items.Add(buyer.Name + "," + buyer.OIB);
            }
        }

        public void newItem(Item newItem)
        {
            items.Add(newItem);
            dataGridItemsWorkOrder.Refresh();
        }
    }
}
