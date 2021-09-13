using CarShop_DesktopApp.DAL;
using CarShop_DesktopApp.Extensions;
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
    public partial class Buyers : UserControl
    {
        private string token;
        User user;
        public Buyers(string JWTToken,User currentUser)
        {
            token = JWTToken;
            user = currentUser;
            InitializeComponent();
        }

        private void Buyers_Load(object sender,EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            dataGridBuyers.DataSource = RestApiCallsHandler.GetBuyers(token);
            GridViewStyleExtension.SetStyle(dataGridBuyers);
        }

        private void btnNewBuyer_Click(object sender, EventArgs e)
        {
            AddBuyer addBuyerForm = new AddBuyer(token);
            addBuyerForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            addBuyerForm.FormClosed += (s, args) => dataGridBuyers.DataSource = RestApiCallsHandler.GetBuyers(token);
            addBuyerForm.ShowDialog();
        }

        private void dataGridBuyers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowIndex = dataGridBuyers.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridBuyers.Rows[selectedrowIndex];
            Buyer selectedBuyer = (Buyer)selectedRow.DataBoundItem;
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
            if (dgv.CurrentRow.Selected)
            {
                AddBuyer myForm = new AddBuyer(token, selectedBuyer);
                myForm.FormBorderStyle = FormBorderStyle.FixedSingle;
                myForm.FormClosed += (s, args) => dataGridBuyers.Refresh();
                myForm.ShowDialog();
            }
        }
    }
}
