using CarShop_DesktopApp.DAL;
using CarShop_DesktopApp.Extensions;
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
        public Buyers(string JWTToken)
        {
            InitializeComponent();
            token = JWTToken;
        }

        private void Buyers_Load(object sender,EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            dataGridBuyers.DataSource = RestApiCallsHandler.GetBuyers(token);
            GridViewStyleExtension.SetStyle(dataGridBuyers);
        }
    }
}
