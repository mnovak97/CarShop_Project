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
    public partial class CustomPickUp : UserControl
    {
        private string token;
        PickUp pickupRequest;
        public CustomPickUp(string JWTToken,PickUp request)
        {
            token = JWTToken;
            pickupRequest = request;
            InitializeComponent();
        }

        private void CustomPickUp_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Top;
            lblAddressText.Text = pickupRequest.Address;
            lblMobileTelephoneText.Text = pickupRequest.User.MobileTelephone;
            lblNameText.Text = pickupRequest.User.Username;
        }
    }
}
