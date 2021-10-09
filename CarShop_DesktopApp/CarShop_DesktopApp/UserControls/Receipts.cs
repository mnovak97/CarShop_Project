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
            List<Receipt> receipts = RestApiCallsHandler.GetReceipts(token);
            cbYear.DataSource = getYears(receipts);
            //cbYear.SelectedItem = cbYear.Items.IndexOf(DateTime.Now.Year.ToString());
            //dataGridReceipts.DataSource = RestApiCallsHandler.GetReceiptsByYear(DateTime.Now.Year.ToString(),token);
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
            string year = cbYear.SelectedItem.ToString();
            List<Receipt> receipts = RestApiCallsHandler.GetReceiptsByYear(year,token);
            dataGridReceipts.DataSource = receipts;
        }
    }
}
