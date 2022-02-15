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
    public partial class PickUpRequests : UserControl
    {
        private string token;
        User currentUser;
        public PickUpRequests(string JWTToken,User user)
        {
            token = JWTToken;
            currentUser = user;
            InitializeComponent();
        }

        private void PickUpRequests_Load(object sender, EventArgs e)
        {
            displayPickUpRequests();
            this.Dock = DockStyle.Fill;
        }

        private void displayPickUpRequests()
        {
            List<PickUp> pickUpRequest = RestApiCallsHandler.GetPickUpRequest(token);
            foreach (PickUp requests in pickUpRequest)
            {
                CustomPickUp myTaskControl = new CustomPickUp(token,requests);
                panelPickupRequests.Controls.Add(myTaskControl);
            }
        }
    }
}
