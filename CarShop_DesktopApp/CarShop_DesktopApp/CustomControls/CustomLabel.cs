using CarShop_DesktopApp.Model;
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

namespace CarShop_DesktopApp.CustomControls
{
    public partial class CustomLabel : UserControl
    {

        public WorkOrder workOrder;
        [Category("Custom properties")]
        public string Texts { get => lblTitle.Text; set => lblTitle.Text = value; }

        public CustomLabel(WorkOrder order)
        {
            workOrder = order;
            InitializeComponent();
        }

        private void CustomLabel_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Top;
            lblTitle.Text = workOrder.ToString();
        }

       
    }
}
