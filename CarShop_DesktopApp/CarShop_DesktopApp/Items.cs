using CarShop_DesktopApp.DAL;
using CarShop_DesktopApp.Extensions;
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
        public Items(string JWTToken)
        {
            InitializeComponent();
            token = JWTToken;

        }

        private void Items_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            dataGridItems.DataSource = RestApiCallsHandler.GetItems(token);
            GridViewStyleExtension.SetStyle(dataGridItems);
        }

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            AddItem addItemForm = new AddItem(token);
            addItemForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            addItemForm.FormClosed += (s, args) => dataGridItems.DataSource = RestApiCallsHandler.GetItems(token);
            addItemForm.Show();
        }
    }
}
