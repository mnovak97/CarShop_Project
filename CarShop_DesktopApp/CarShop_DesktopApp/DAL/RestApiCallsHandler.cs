﻿using CarShop_DesktopApp.Model;
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

        public static List<WorkOrder> GetBuyersWorkOrders(int IDBuyer,string token)
        {
            List<WorkOrder> buyerWorkOrders = new List<WorkOrder>();
            HttpWebRequest request = httpPostCall("WorkOrder/getBuyersWorkOrders", token);
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(IDBuyer);
                streamWriter.Write(json);
            }
            var response = (HttpWebResponse)request.GetResponse();
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                var result = sr.ReadToEnd();
                buyerWorkOrders = JsonConvert.DeserializeObject<List<WorkOrder>>(result);
            }
            return buyerWorkOrders;
        }

        public static List<Receipt> GetReceipts(string token)
        {
            List<Receipt> receipts = new List<Receipt>();
            HttpWebRequest request = httpGetCall("Receipt/all", token);
            var response = (HttpWebResponse)request.GetResponse();
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                var result = sr.ReadToEnd();
                receipts = JsonConvert.DeserializeObject<List<Receipt>>(result);
            }
            return receipts;
        }

        public static bool UpdateBuyer(Buyer selectedBuyer, string token)
        {
            HttpWebRequest request = httpPostCall("Buyer/updateBuyer", token);
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(selectedBuyer);
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

        public static bool UpdateItem(Item itemForUpdate, string token)
        {
            HttpWebRequest request = httpPostCall("Item/updateItem", token);
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(itemForUpdate);
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

        public static bool AddWorkOrder(WorkOrdersItems workOrderItems,string token)
        {
            HttpWebRequest request = httpPostCall("WorkOrder/addWorkOrder", token);
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(workOrderItems);
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

        public static bool UpdateWorkOrder(WorkOrdersItems workOrderForUpdate, string token)
        {
            HttpWebRequest request = httpPostCall("WorkOrder/updateWorkOrder", token);
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(workOrderForUpdate);
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

        public static bool DeleteItem(int IDItem,string token)
        {
            HttpWebRequest request = httpPostCall("Item/deleteItem", token);
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(IDItem);
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

        public static int GetWorkOrdersNumber(string token)
        {
            int number;
            HttpWebRequest request = httpGetCall("WorkOrder/number", token);
            var response = (HttpWebResponse)request.GetResponse();
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                var result = sr.ReadToEnd();
                number = JsonConvert.DeserializeObject<int>(result);
            }
            return number;
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

        public static List<ItemQuantity> GetWorkOrderItems(int WorkOrderID,string token)
        {
            List<ItemQuantity> workOrderItems = new List<ItemQuantity>();
            HttpWebRequest request = httpPostCall("Item/getWorkOrderItems", token);
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(WorkOrderID);
                streamWriter.Write(json);
            }
            var response = (HttpWebResponse)request.GetResponse();
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                var result = sr.ReadToEnd();
                workOrderItems = JsonConvert.DeserializeObject<List<ItemQuantity>>(result);
            }
            return workOrderItems;
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
