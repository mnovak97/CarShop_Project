using CarShop_DesktopApp.UserControls;
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
    public partial class WorkOrders : UserControl
    {
        private string token;
        public WorkOrders(string JWTToken)
        {
            token = JWTToken;
            InitializeComponent();
        }

        public void WorkOrders_Load(object sender,EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            WorkOrdersList myUserControl = new WorkOrdersList(token);
            placeHolderWorkOrders.Controls.Clear();
            placeHolderWorkOrders.Controls.Add(myUserControl);
        }
    }
}
