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

namespace CarShop_DesktopApp
{
    public partial class AddBuyer : Form
    {
        private string token;
        public AddBuyer(string JWTToken)
        {
            token = JWTToken;
            InitializeComponent();
        }

        private void btnAddBuyer_Click(object sender, EventArgs e)
        {
            Buyer newBuyer = new Buyer(txtName.Text,txtEmail.Text,txtMobilePhone.Text,txtAddress.Text,txtOIB.Text);
            if (RestApiCallsHandler.AddBuyer(newBuyer,token))
            {
                MessageBox.Show("Buyer added!");
                clearForm();
            }
            else
            {
                MessageBox.Show("Error!");
                clearForm();
            }
        }

        private void clearForm()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtMobilePhone.Text = "";
            txtAddress.Text = "";
            txtOIB.Text = "";
        }
    }
}
