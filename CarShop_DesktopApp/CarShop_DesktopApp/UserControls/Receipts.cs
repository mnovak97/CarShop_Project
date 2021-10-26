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
        List<Receipt> allReceipts;
        public Receipts(string JWTToken,User user)
        {
            token = JWTToken;
            currentUser = user;
            InitializeComponent();
            showBuyers();
            btnNewReceipt.Text = "Add new receipt";
        }


        private void Receipts_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            GridViewStyleExtension.SetStyle(dataGridReceipts);
            allReceipts = RestApiCallsHandler.GetReceipts(token);
            cbYear.DataSource = getYears(allReceipts);
            setCurrency(dataGridReceipts);
            
        }
        private void showBuyers()
        {
            List<Buyer> buyers = new List<Buyer>();
            buyers = RestApiCallsHandler.GetBuyers(token);
            foreach (Buyer buyer in buyers)
            {
                cbBuyers.Items.Add(buyer);
            }
        }

        private void setCurrency(DataGridView dataGridReceipts)
        {
            DataGridViewTextBoxColumn columnCurrency = new DataGridViewTextBoxColumn();
            columnCurrency.DataPropertyName = "Currency";
            columnCurrency.Name = "Currency";
            columnCurrency.ValueType = typeof(string);
            columnCurrency.DefaultCellStyle.NullValue = "HRK";
            dataGridReceipts.Columns.Insert(2, columnCurrency);
        }

        private List<string> getYears(List<Receipt> receipts)
        {
            List<string> years = new List<string>();
            foreach (Receipt receipt in receipts)
            {
                string year = receipt.DateOfReceipt.Year.ToString();
                checkIfYearAlreadyAdded(year, years);
            }
            return years;
        }

        private void checkIfYearAlreadyAdded(string year, List<string> years)
        {
            var duplicate = years.FirstOrDefault(y => y == year);
            if (duplicate == null)
            {
                years.Add(year);
            }
        }

        private void btnNewReceipt_Click(object sender, EventArgs e)
        {
            if (btnNewReceipt.Text == "Add new receipt")
            {
                ReceiptForm myForm = new ReceiptForm(token,currentUser);
                myForm.FormBorderStyle = FormBorderStyle.FixedSingle;
                myForm.FormClosed += (s, args) => dataGridReceipts.DataSource = RestApiCallsHandler.GetReceipts(token);
                myForm.ShowDialog();
            }
        }

        private void cbYear_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            List<Receipt> displayedList = new List<Receipt>();
            Buyer buyer = (Buyer)cbBuyers.SelectedItem;
            string year = cbYear.SelectedItem.ToString();
            if (buyer == null)
            {
                displayedList = getReceitsByYear(year);
                dataGridReceipts.DataSource = displayedList;
            }
            else if(buyer != null)
            {
                displayedList = getBuyersReceiptsByYear(year, buyer);
                dataGridReceipts.DataSource = displayedList;
            }
        }


        private void cbBuyers_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            List<Receipt> displayedList = new List<Receipt>();
            Buyer buyer = (Buyer)cbBuyers.SelectedItem;
            string year = cbYear.SelectedItem.ToString();
            displayedList = getBuyersReceiptsByYear(year, buyer);
            dataGridReceipts.DataSource = displayedList;
        }
        private List<Receipt> getReceitsByYear(string year)
        {
            List<Receipt> receipts = new List<Receipt>();
            receipts = allReceipts.Where(r => r.DateOfReceipt.Year.ToString() == year).ToList();
            return receipts;
        }

        private List<Receipt> getBuyersReceiptsByYear(string year, Buyer buyer)
        {
            List<Receipt> receipts = new List<Receipt>();
            receipts = allReceipts.Where(r => r.DateOfReceipt.Year.ToString() == year && r.Buyer.IDBuyer == buyer.IDBuyer).ToList();
            return receipts;
        }
    }
}
