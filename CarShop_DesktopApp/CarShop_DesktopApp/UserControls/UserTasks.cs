using CarShop_DesktopApp.CustomControls;
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
    public partial class UserTasks : UserControl
    {
        private string token;
        User user;
        public UserTasks(string JWTToken,User currentUser)
        {
            token = JWTToken;
            user = currentUser;
            InitializeComponent();
        }

        private void UserTasks_Load(object sender, EventArgs e)
        {
            displayUserTasks(user);
            this.Dock = DockStyle.Fill;
        }

        private void displayUserTasks(User user)
        {
            List<Model.Task> assignedTasks = RestApiCallsHandler.GetUserTasks(user.IDUser,token);
            foreach (Model.Task task in assignedTasks)
            {
                CustomTask myTaskControl = new CustomTask(token, task, user);
                panelTasks.Controls.Add(myTaskControl);
            }
        }
    }
}
