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
    public partial class AddItem : Form
    {
        private string token;
        public AddItem(string JWTToken)
        {
            token = JWTToken;
            InitializeComponent();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && txtPrice.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch !=8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Item newItem = new Item(txtTitle.Text,Convert.ToDouble(txtPrice.Text),txtCode.Text);
            if (RestApiCallsHandler.AddItem(newItem, token))
            {
                MessageBox.Show("Item added!");
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
            txtTitle.Text = "";
            txtPrice.Text = "";
            txtCode.Text = "";
        }
    }
}
