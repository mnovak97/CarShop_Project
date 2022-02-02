using CarShop_DesktopApp.DAL;
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

namespace CarShop_DesktopApp.CustomControls
{
    public partial class CustomTask : UserControl
    {
        private string token;
        Model.Task task;
        User user;
        public CustomTask(string JWTToken,Model.Task assignedTask,User currentUser)
        {
            token = JWTToken;
            task = assignedTask;
            user = currentUser;
            InitializeComponent();
        }

        private void btnCompleteTask_Click(object sender, EventArgs e)
        {

        }

        private void txtWorkOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<ItemQuantity> items = RestApiCallsHandler.GetWorkOrderItems(task.WorkOrder.IDWorkOrder, token);
            WorkOrderForm myForm = new WorkOrderForm(token, user, task.WorkOrder, items);
            myForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            myForm.ShowDialog();
        }

        private void CustomTask_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Top;
            txtTaskID.Text = task.IDTask.ToString();
            txtWorkOrder.Text = task.WorkOrder.ToString();
        }
    }
}
