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

namespace CarShop_DesktopApp.UserControls
{
    public partial class WorkOrdersList : UserControl
    {
        private string token;
        private bool done;
        User user;
        public WorkOrdersList(string JWTToken,User currentUser, bool Done)
        {
            token = JWTToken;
            user = currentUser;
            done = Done;
            InitializeComponent();
        }

        private void btnNewWorkOrder_Click(object sender, EventArgs e)
        {
            WorkOrderForm workOrder = new WorkOrderForm(token,user);
            workOrder.FormBorderStyle = FormBorderStyle.FixedSingle;
            workOrder.ShowDialog();
        }

        private void WorkOrdersList_Load(object sender, EventArgs e)
        {
            List<WorkOrder> workOrders = RestApiCallsHandler.GetWorkOrders(token);
            if (done)
            {
                loadDoneWorkOrders(workOrders);
            }
            else if (!done)
            {
                loadNotFinishedWorkOrders(workOrders);
            }
           
        }

        private void loadNotFinishedWorkOrders(List<WorkOrder> workOrders)
        {
            List<WorkOrder> notFinishedWorkOrders = new List<WorkOrder>();
            foreach (WorkOrder workOrder in workOrders)
            {
                if (!workOrder.Done)
                {
                    notFinishedWorkOrders.Add(workOrder);
                }
            }
            this.Dock = DockStyle.Fill;
            dataGridWorkOrders.DataSource = notFinishedWorkOrders;
            GridViewStyleExtension.SetStyle(dataGridWorkOrders);
        }

        private void loadDoneWorkOrders(List<WorkOrder> workOrders)
        {
            List<WorkOrder> doneWorkOrders = new List<WorkOrder>();
            foreach (WorkOrder workOrder in workOrders)
            {
                if (workOrder.Done)
                {
                    doneWorkOrders.Add(workOrder);
                }
            }
            this.Dock = DockStyle.Fill;
            dataGridWorkOrders.DataSource = doneWorkOrders;
            GridViewStyleExtension.SetStyle(dataGridWorkOrders);
        }

        private void dataGridWorkOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowIndex = dataGridWorkOrders.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridWorkOrders.Rows[selectedrowIndex];
            WorkOrder workOrder = (WorkOrder)selectedRow.DataBoundItem;
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
            if (dgv.CurrentRow.Selected)
            {
                List<Item> items = RestApiCallsHandler.GetWorkOrderItems(workOrder.IDWorkOrder, token);
                var itemsBindingList = new BindingList<Item>(items);
                WorkOrderForm myForm = new WorkOrderForm(token, user, workOrder, itemsBindingList);
                myForm.FormBorderStyle = FormBorderStyle.FixedSingle;
                myForm.ShowDialog();
            }
        }
    }
}
