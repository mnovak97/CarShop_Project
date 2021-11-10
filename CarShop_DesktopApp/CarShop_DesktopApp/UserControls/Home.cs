using CarShop_DesktopApp.CustomControls;
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

namespace CarShop_DesktopApp.UserControls
{
    public partial class Home : UserControl
    {
        private string dateString;
        private string token;
        List<Appointment> appointments;
        public Home(string JWTToken)
        {
            token = JWTToken;
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            string dateToday = DateTime.Now.ToString("d/MM/yyyy");
            dateString = dateToday.Replace(".", "%2F");
            this.Dock = DockStyle.Fill;
            centerDatePicker();
            appointments = RestApiCallsHandler.GetAppointmentsForDate(dateString,token);
            displayAppointments();
        }

        private void centerDatePicker()
        {
            datePicekrAppointments.Left = (panelDatePicker.Width - datePicekrAppointments.Width) / 2;
            datePicekrAppointments.Top = (panelDatePicker.Height - datePicekrAppointments.Height) / 2;
        }

        private void datePicekrAppointments_ValueChanged(object sender, EventArgs e)
        {
            panelAppointments.Controls.Clear();
            dateString = datePicekrAppointments.Value.Day.ToString() + "%2F" + datePicekrAppointments.Value.Month.ToString() + "%2F" + datePicekrAppointments.Value.Year.ToString();
            appointments = RestApiCallsHandler.GetAppointmentsForDate(dateString, token);
            displayAppointments();
            
        }
        private void displayAppointments()
        {
            foreach (Appointment item in appointments)
            {
                CustomAppointment myAppointment = new CustomAppointment(item);
                panelAppointments.Controls.Add(myAppointment);
            }
        }
    }
}
