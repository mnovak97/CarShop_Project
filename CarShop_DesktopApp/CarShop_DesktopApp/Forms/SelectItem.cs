using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShop_DesktopApp.Forms
{
    public partial class SelectItem : Form
    {
        private string token;
        WorkOrderForm workOrder;
        public SelectItem(WorkOrderForm WorkOrder,string JWTToken)
        {
            token = JWTToken;
            workOrder = WorkOrder;
            InitializeComponent();
        }

        private void SelectItem_Load(object sender, EventArgs e)
        {
            Items myUserControl = new Items(workOrder, token);
            placeHolderItems.Controls.Add(myUserControl);
        }
    }
}
