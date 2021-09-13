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
        private Item selectedItem;

        public AddItem(string JWTToken)
        {
            token = JWTToken;
            InitializeComponent();
            btnAddItem.Text = "Add item";
        }

        public AddItem(string JWTToken, Item selectedItem)
        {
            token = JWTToken;
            this.selectedItem = selectedItem;
            InitializeComponent();
            setData();
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
            if (btnAddItem.Text == "Add item")
            {
                addNewItem();
            }
            else if(btnAddItem.Text == "Update item")
            {
                updateItem();
            }
            
        }

        private void updateItem()
        {
            selectedItem.Title = txtTitle.Text;
            selectedItem.Price = Convert.ToDouble(txtPrice.Text);
            selectedItem.Code = txtCode.Text;
            if (RestApiCallsHandler.UpdateItem(selectedItem, token))
            {
                MessageBox.Show("Item updated!");
                clearForm();
            }
            else
            {
                MessageBox.Show("Error!");
                clearForm();
            }
        }

        private void addNewItem()
        {
            Item newItem = new Item(txtTitle.Text, Convert.ToDouble(txtPrice.Text), txtCode.Text);
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

        private void setData()
        {
            txtTitle.Text = selectedItem.Title;
            txtPrice.Text = selectedItem.Price.ToString();
            txtCode.Text = selectedItem.Code;
            btnAddItem.Text = "Update item";
        }

        private void clearForm()
        {
            txtTitle.Text = "";
            txtPrice.Text = "";
            txtCode.Text = "";
        }
    }
}
