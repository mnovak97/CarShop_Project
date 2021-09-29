using CarShop_DesktopApp.DAL;
using CarShop_DesktopApp.Model;
using CarShop_DesktopApp.Properties;
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
        Image delete;
        public AddItem(string JWTToken)
        {
            token = JWTToken;
            InitializeComponent();
            btnAddItem.Text = "Add item";
            imageButtonDelete.Visible = false;
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
            if (ch == 46 && txtPrice.Texts.IndexOf('.') != -1)
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
            if (ValidateForm())
            {
                if (btnAddItem.Text == "Add item")
                {
                    addNewItem();
                }
                else if (btnAddItem.Text == "Update item")
                {
                    updateItem();
                }
            }
        }

        private bool ValidateForm()
        {
            bool validationSuccesfull = false;
           
            if (string.IsNullOrEmpty(txtTitle.Texts))
                lblErrorTitle.Text = "Title can't be empty!";
            else if (!string.IsNullOrEmpty(txtTitle.Texts))
                lblErrorTitle.Text = "";

            if (string.IsNullOrWhiteSpace(txtPrice.Texts))
                lblErrorPrice.Text = "Price can't be empty!";
            else if(Convert.ToDouble(txtPrice.Texts) == 0)
                lblErrorPrice.Text = "Price can't be zero!";
            else if (!string.IsNullOrEmpty(txtPrice.Texts))
                lblErrorPrice.Text = "";

            if(string.IsNullOrWhiteSpace(txtCode.Texts))
                lblErrorCode.Text = "Code can't be empty!";
            else if (!string.IsNullOrWhiteSpace(txtCode.Texts))
                lblErrorCode.Text = "";

            if(lblErrorTitle.Text == "" && lblErrorPrice.Text == "" && lblErrorCode.Text == "")
                validationSuccesfull = true;

            return validationSuccesfull;
        }

        private void updateItem()
        {
            selectedItem.Title = txtTitle.Texts;
            selectedItem.Price = Convert.ToDouble(txtPrice.Texts);
            selectedItem.Code = txtCode.Texts;
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
            Item newItem = new Item(txtTitle.Texts, Convert.ToDouble(txtPrice.Texts), txtCode.Texts);
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
            txtTitle.Texts = selectedItem.Title;
            txtPrice.Texts = selectedItem.Price.ToString();
            txtCode.Texts = selectedItem.Code;
            btnAddItem.Text = "Update item";
        }

        private void clearForm()
        {
            txtTitle.Texts = "";
            txtPrice.Texts = "";
            txtCode.Texts = "";
        }

        private void imageButtonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + selectedItem.Title,"Delete",MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (RestApiCallsHandler.DeleteItem(selectedItem.IDItem, token))
                    this.Close();
                else
                    MessageBox.Show("Error");
            }
            else if(DialogResult == DialogResult.No)
            {
                return;
            }
        }
    }
}
