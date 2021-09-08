using CarShop_DesktopApp.Model;
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
        User user;
        public WorkOrders(string JWTToken,User currentUser)
        {
            token = JWTToken;
            user = currentUser;
            InitializeComponent();
        }

        public void WorkOrders_Load(object sender,EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            btnDone.PerformClick();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            WorkOrdersList myUserControl = new WorkOrdersList(token,user,true);
            placeHolderWorkOrders.Controls.Clear();
            placeHolderWorkOrders.Controls.Add(myUserControl);
        }

        private void btnOngoing_Click(object sender, EventArgs e)
        {
            WorkOrdersList myUserControl = new WorkOrdersList(token, user, false);
            placeHolderWorkOrders.Controls.Clear();
            placeHolderWorkOrders.Controls.Add(myUserControl);
        }
    }
}
