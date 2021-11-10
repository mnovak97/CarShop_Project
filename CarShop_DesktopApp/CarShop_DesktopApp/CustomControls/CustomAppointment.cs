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

namespace CarShop_DesktopApp.CustomControls
{
    public partial class CustomAppointment : UserControl
    {
        public CustomAppointment(Appointment appointment)
        {
            InitializeComponent();
            txtDateAppointement.Text = appointment.Date;
            txtNameAppointment.Text = appointment.CustomerName;
            txtPhoneAppoinement.Text = appointment.CustomerPhone;
            txtTimeAppointment.Text = appointment.Time;
        }

        private void CustomAppointment_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Top;
        }
       
    }
}
