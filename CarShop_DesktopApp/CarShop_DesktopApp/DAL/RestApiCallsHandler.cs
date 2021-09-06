using CarShop_DesktopApp.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CarShop_DesktopApp.DAL
{
    class RestApiCallsHandler
    {
        private static string uriString = "http://localhost:5000/api/";

        public static HttpWebResponse Login(string username, string password)
        {
            Uri uri = new Uri(uriString + "Login");
            WebRequest webRequest = WebRequest.Create(uri);
            webRequest.ContentType = "application/json";
            webRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(webRequest.GetRequestStream()))
            {
                string json = "{\"username\":\"" + username + "\"," +
                  "\"password\":\"" + password + "\"}";
                streamWriter.Write(json);
            }

            var response = (HttpWebResponse)webRequest.GetResponse();
            return response;
        }

        public static bool AddBuyer(Buyer newBuyer,string token)
        {
            HttpWebRequest request = httpPostCall("Buyer/addBuyer", token);
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(newBuyer);
                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)request.GetResponse();
            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool AddItem(Item newItem, string token)
        {
            
            HttpWebRequest request = httpPostCall("Item/addItem", token);
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(newItem);
                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)request.GetResponse();
            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static List<WorkOrder> GetWorkOrders(string token)
        {
            List<WorkOrder> workOrder = new List<WorkOrder>();
            HttpWebRequest request = httpGetCall("WorkOrder/all", token);
            var response = (HttpWebResponse)request.GetResponse();
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                var result = sr.ReadToEnd();
                workOrder = JsonConvert.DeserializeObject<List<WorkOrder>>(result);
            }
            return workOrder;
        }

        public static List<Buyer> GetBuyers(string token)
        {
            List<Buyer> buyers = new List<Buyer>();
            HttpWebRequest request = httpGetCall("Buyer",token);
            var response = (HttpWebResponse)request.GetResponse();
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                var result = sr.ReadToEnd();
                buyers = JsonConvert.DeserializeObject<List<Buyer>>(result);
            }
            return buyers;
        }


        public static List<Item> GetItems(string token)
        {
            List<Item> items = new List<Item>();
            HttpWebRequest request = httpGetCall("Item/all", token);
            var response = (HttpWebResponse)request.GetResponse();
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                var result = sr.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<Item>>(result);
            }
            return items;
        }

        private static HttpWebRequest httpPostCall(string controller, string token)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uriString + controller);
            request.Method = "POST";
            request.Accept = "application/json";
            request.ContentType = "application/json; charset=utf-8";
            request.PreAuthenticate = true;
            request.Headers.Add("Authorization", "Bearer " + token);

            return request;
        }

        private static HttpWebRequest httpGetCall(string controller,string token)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uriString + controller);
            request.Method = "GET";
            request.Accept = "application/json";
            request.ContentType = "application/json; charset=utf-8";
            request.PreAuthenticate = true;
            request.Headers.Add("Authorization", "Bearer " + token);

            return request;
        }
    }
}
