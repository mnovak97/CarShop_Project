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
    public partial class MainForm : Form
    {
        private string token;
        private User user;
        public Form refToLoginForm { get; set; }

        public MainForm(string JWTToken,User currentUser)
        {
            InitializeComponent();
            token = JWTToken;
            user = currentUser;
            setUpScreen();
        }

        private void setUpScreen()
        {
            tsmUsername.Text = user.Username;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.refToLoginForm.Show();
        }

        private void tsmItems_Click(object sender, EventArgs e)
        {
            Items myUserControl = new Items(token);
            placeHolder.Controls.Clear();
            placeHolder.Controls.Add(myUserControl);
        }

        private void tsmBuyers_Click(object sender, EventArgs e)
        {
            Buyers myBuyersControl = new Buyers(token);
            placeHolder.Controls.Clear();
            placeHolder.Controls.Add(myBuyersControl);
        }

        private void tsmWorkOrders_Click(object sender, EventArgs e)
        {
            WorkOrders myWorkOrdersControl = new WorkOrders(token);
            placeHolder.Controls.Clear();
            placeHolder.Controls.Add(myWorkOrdersControl);
        }
    }
}
