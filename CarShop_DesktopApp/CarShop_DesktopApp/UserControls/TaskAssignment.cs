using CarShop_DesktopApp.DAL;
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
    public partial class TaskAssignment : UserControl
    {
        private string token;
        public TaskAssignment(string JWTToken)
        {
            token = JWTToken;
            InitializeComponent();
        }

        private void TaskAssignment_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            cbWorker.DataSource = RestApiCallsHandler.GetWorkers(token);
            cbWorkOrders.DataSource = RestApiCallsHandler.GetNotAssignedWorkOrders(token);
        }

        private void btnAssignTask_Click(object sender, EventArgs e)
        {
            User selectedWorker = (User)cbWorker.SelectedItem;
            WorkOrder selectedWorkOrder = (WorkOrder)cbWorkOrders.SelectedItem;
            selectedWorkOrder.Assigned = true;
            Model.Task newTask = new Model.Task(selectedWorker, selectedWorkOrder);
            if (RestApiCallsHandler.AssignTask(newTask, token))
                MessageBox.Show("Task assignet to " + selectedWorker.Username);
            else
                MessageBox.Show("Error");
        }
    }
}
