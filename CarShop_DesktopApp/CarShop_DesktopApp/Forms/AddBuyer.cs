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
        private Buyer selectedBuyer;

        public AddBuyer(string JWTToken)
        {
            token = JWTToken;
            InitializeComponent();
            btnAddBuyer.Text = "Add buyer";
        }

        public AddBuyer(string JWTToken, Buyer selectedBuyer)
        {
            token = JWTToken;
            this.selectedBuyer = selectedBuyer;
            InitializeComponent();
            setData();
        }


        private void btnAddBuyer_Click(object sender, EventArgs e)
        {
            if (btnAddBuyer.Text == "Add buyer")
            {
                addNewBuyer();
            }
            else if (btnAddBuyer.Text == "Update buyer")
            {
                updateBuyer();
            }
        }

        private void updateBuyer()
        {
            selectedBuyer.Name = txtName.Text;
            selectedBuyer.Email = txtEmail.Text;
            selectedBuyer.MobilePhone = txtMobilePhone.Text;
            selectedBuyer.Address = txtAddress.Text;
            selectedBuyer.OIB = txtOIB.Text;
            if (RestApiCallsHandler.UpdateBuyer(selectedBuyer, token))
            {
                MessageBox.Show("Buyer updated!");
                clearForm();
            }
            else
            {
                MessageBox.Show("Error!");
                clearForm();
            }
        }

        private void addNewBuyer()
        {
            Buyer newBuyer = new Buyer(txtName.Text, txtEmail.Text, txtMobilePhone.Text, txtAddress.Text, txtOIB.Text);
            if (RestApiCallsHandler.AddBuyer(newBuyer, token))
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

        private void setData()
        {
            txtName.Text = selectedBuyer.Name;
            txtEmail.Text = selectedBuyer.Email;
            txtAddress.Text = selectedBuyer.Address;
            txtMobilePhone.Text = selectedBuyer.MobilePhone;
            txtOIB.Text = selectedBuyer.OIB;
            btnAddBuyer.Text = "Update buyer";
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
