using CarShop_DesktopApp.DAL;
using CarShop_DesktopApp.Extensions;
using CarShop_DesktopApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShop_DesktopApp.UserControls
{
    public partial class WorkOrdersList : UserControl
    {
        private string token;
        public WorkOrdersList(string JWTToken)
        {
            token = JWTToken;
            InitializeComponent();
        }

        private void btnNewWorkOrder_Click(object sender, EventArgs e)
        {
            AddWorkOrder workOrder = new AddWorkOrder(token);
            workOrder.FormBorderStyle = FormBorderStyle.FixedSingle;
            workOrder.Show();
        }

        private void WorkOrdersList_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            //dataGridWorkOrders.DataSource = RestApiCallsHandler.GetWorkOrders(token);
            GridViewStyleExtension.SetStyle(dataGridWorkOrders);
        }
    }
}
