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
                Uri uri = new Uri("http://localhost:5000/api/Login");
                WebRequest webRequest = WebRequest.Create(uri);
                webRequest.ContentType = "application/json";
                webRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(webRequest.GetRequestStream()))
                {
                    string json = "{\"username\":\"" + txtUsername.Text + "\"," +
                      "\"password\":\"" + txtPassword.Text + "\"}";
                    streamWriter.Write(json);
                }
                var response = (HttpWebResponse)webRequest.GetResponse();
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    dynamic data = JObject.Parse(result);
                    token = data.token;
                    json = data._data.ToString();
                    user = JsonConvert.DeserializeObject<User>(json);
                }
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    this.Hide();
                    MainForm mainForm = new MainForm(token, user);
                    mainForm.refToLoginForm = this;
                    mainForm.FormClosed += (s, args) =>
                    {
                        txtPassword.Text = "";
                        txtUsername.Text = "";
                    };
                    mainForm.Show();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
