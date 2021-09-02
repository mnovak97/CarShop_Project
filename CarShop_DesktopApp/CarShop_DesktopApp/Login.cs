using CarShop_DesktopApp.DAL;
using CarShop_DesktopApp.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShop_DesktopApp
{
    public partial class Login : Form
    {
        private string token;
        private string json;
        User user;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var response = RestApiCallsHandler.Login(txtUsername.Text,txtPassword.Text);
                getResponseData(response);
                
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    this.Hide();
                    MainForm mainForm = new MainForm(token, user);
                    mainForm.refToLoginForm = this;
                    mainForm.FormClosed += (s, args) => this.Close();
                    mainForm.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void getResponseData(HttpWebResponse response)
        {
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                dynamic data = JObject.Parse(result);
                token = data.token;
                json = data._data.ToString();
                user = JsonConvert.DeserializeObject<User>(json);
            }
        }
    }
}
