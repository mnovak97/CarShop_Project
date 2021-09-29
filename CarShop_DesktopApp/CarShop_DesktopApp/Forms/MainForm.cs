using CarShop_DesktopApp.DAL;
using CarShop_DesktopApp.Model;
using CarShop_DesktopApp.UserControls;
using FontAwesome.Sharp;
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
        private IconButton currentButton;
        private Panel leftBorder;
        private string token;
        private User user;
        private UserControl currentUserControl;
        public Form refToLoginForm { get; set; }

        public MainForm(string JWTToken,User currentUser)
        {
            InitializeComponent();
            token = JWTToken;
            user = currentUser;
            this.Text = "";
            this.DoubleBuffered = true;
            leftBorder = new Panel();
            leftBorder.Size = new Size(7,50);
            panelMenu.Controls.Add(leftBorder);
            setHome();
        }


        private void btnItems_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Items myUserControl = new Items(token, user);
            OpenUserControl(myUserControl);
        }

        private void btnBuyers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Buyers myBuyersControl = new Buyers(token, user);
            OpenUserControl(myBuyersControl);
        }

        private void btnWorkOrders_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            WorkOrders myWorkOrdersControl = new WorkOrders(token, user);
            OpenUserControl(myWorkOrdersControl);
        }
        private void btnReceipt_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Receipts myReceiptsControl = new Receipts(token, user);
            OpenUserControl(myReceiptsControl);
        }

        private void OpenUserControl(UserControl userControl)
        {
            placeHolder.Controls.Clear();
            currentUserControl = userControl;
            placeHolder.Controls.Add(userControl);
            iconCurrent.IconChar = currentButton.IconChar;
            lblUserControl.Text = currentButton.Text;
        }

        private void ActivateButton(object sender)
        {
            if (sender != null)
            {
                DisableButton();
                currentButton = (IconButton)sender;
                currentButton.BackColor = SystemColors.MenuHighlight;
                currentButton.ForeColor = Color.White;
                currentButton.IconColor = Color.White;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;

                leftBorder.BackColor = Color.White;
                leftBorder.Location = new Point(0, currentButton.Location.Y);
                leftBorder.Visible = true;
                leftBorder.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
        }
        private void setHome()
        {
            Home myHomeControl = new Home();
            placeHolder.Controls.Add(myHomeControl);
            myHomeControl.Top = placeHolder.Height / 2 - myHomeControl.Height / 2;
            myHomeControl.Left = placeHolder.Width / 2 - myHomeControl.Width / 2;
        }

        private void imgHome_Click(object sender, EventArgs e)
        {
            DisableButton();
            placeHolder.Controls.Clear();
            setHome();
            leftBorder.Visible = false;
            iconCurrent.IconChar = IconChar.Home;
            lblUserControl.Text = "Home";
        }

    }
}
