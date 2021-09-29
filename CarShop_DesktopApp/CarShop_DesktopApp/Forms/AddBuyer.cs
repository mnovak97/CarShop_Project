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
            if (validateForm())
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

        }

        private bool validateForm()
        {
            bool validationSuccesfull = false;
            if (string.IsNullOrEmpty(txtName.Texts))
                lblErrorName.Text = "Name can't be empty!";
            else if (!string.IsNullOrEmpty(txtName.Texts))
                lblErrorName.Text = "";

            if (string.IsNullOrEmpty(txtEmail.Texts))
                lblErrorEmail.Text = "E-mail can't be empty!";
            else if (!isValidEmail(txtEmail.Texts))
                lblErrorEmail.Text = "Must enter vaild e-mail address!";
            else if (!string.IsNullOrEmpty(txtEmail.Texts))
                lblErrorEmail.Text = "";

            if (string.IsNullOrEmpty(txtMobilePhone.Texts))
                lblErrorMobilePhone.Text = "Mobile phone can't be empty!";
            else if (!string.IsNullOrEmpty(txtMobilePhone.Texts))
                lblErrorMobilePhone.Text = "";

            if (string.IsNullOrEmpty(txtAddress.Texts))
                lblErrorAddress.Text = "Address can't be empty!";
            else if (!string.IsNullOrEmpty(txtAddress.Texts))
                lblErrorAddress.Text = "";

            if (string.IsNullOrEmpty(txtOIB.Texts))
                lblErrorOIB.Text = "OIB can't be empty!";
            else if (txtOIB.Texts.Length < 11)
                lblErrorOIB.Text = "OIB must containt 11 numbers!";
            else if (!string.IsNullOrEmpty(txtOIB.Texts))
                lblErrorOIB.Text = "";

            if(lblErrorName.Text == "" && lblErrorEmail.Text == "" && lblErrorMobilePhone.Text == "" && lblErrorAddress.Text == "" && lblErrorOIB.Text == "")
                validationSuccesfull = true;

            return validationSuccesfull;
        }

        private bool isValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void updateBuyer()
        {
            selectedBuyer.Name = txtName.Texts;
            selectedBuyer.Email = txtEmail.Texts;
            selectedBuyer.MobilePhone = txtMobilePhone.Texts;
            selectedBuyer.Address = txtAddress.Texts;
            selectedBuyer.OIB = txtOIB.Texts;
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
            Buyer newBuyer = new Buyer(txtName.Texts, txtEmail.Texts, txtMobilePhone.Texts, txtAddress.Texts, txtOIB.Texts);
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
            txtName.Texts = selectedBuyer.Name;
            txtEmail.Texts = selectedBuyer.Email;
            txtAddress.Texts = selectedBuyer.Address;
            txtMobilePhone.Texts = selectedBuyer.MobilePhone;
            txtOIB.Texts = selectedBuyer.OIB;
            btnAddBuyer.Text = "Update buyer";
        }

        private void clearForm()
        {
            txtName.Texts = "";
            txtEmail.Texts = "";
            txtMobilePhone.Texts = "";
            txtAddress.Texts = "";
            txtOIB.Texts = "";
        }

        private void txtMobilePhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtOIB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
