using CarShop_DesktopApp.DAL;
using CarShop_DesktopApp.Extensions;
using CarShop_DesktopApp.Forms;
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
    public partial class Receipts : UserControl
    {

        private string token;
        User currentUser;
        public Receipts(string JWTToken,User user)
        {
            token = JWTToken;
            currentUser = user;
            InitializeComponent();
            btnNewReceipt.Text = "Add new receipt";
        }

        private void Receipts_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            GridViewStyleExtension.SetStyle(dataGridReceipts);
        }

        private void btnNewReceipt_Click(object sender, EventArgs e)
        {
            if (btnNewReceipt.Text == "Add new receipt")
            {
                ReceiptForm myForm = new ReceiptForm(token);
                myForm.FormBorderStyle = FormBorderStyle.FixedSingle;
                //myForm.FormClosed += (s, args) => dataGridReceipts.DataSource = RestApiCallsHandler.GetReceipts(token);
                myForm.ShowDialog();
            }
        }
    }
}
