using CarShop_REST_API.Context;
using CarShop_REST_API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop_REST_API.DAL
{
    public class CarShopRepository 
    {
        
        public static List<User> GetUsers()
        {
            using (var db = new DatabaseContext())
            {
                var users = db.Users.ToList();
                return users;
            }
        }

        public static List<WorkOrder> GetWorkOrders()
        {
            using (var db = new DatabaseContext())
            {
                var workOrders = db.WorkOrders.Include(wo => wo.User)
                                              .Include(wo => wo.Buyer)
                                              .ToList();
                return workOrders;
            }
        }

        public static User AuthorizeUser(UserModel login)
        {
            return GetUsers().FirstOrDefault(x => x.Username == login.Username && x.Password == login.Password);
        }

        public static void AddWorkOrder(WorkOrder workOrder)
        {
            using (var db = new DatabaseContext())
            {
                db.WorkOrders.Attach(workOrder);
                db.SaveChanges();
            }
        }

        public static void UpdateBuyer(Buyer buyerForUpdate)
        {
            using (var db = new DatabaseContext())
            {
                var buyer = db.Buyers.FirstOrDefault(b => b.IDBuyer == buyerForUpdate.IDBuyer);
                db.Entry(buyer).CurrentValues.SetValues(buyerForUpdate);
                db.SaveChanges();
            }
        }

        public static void UpdateWorkOrder(WorkOrder workOrderForUpdate)
        {
            using (var db = new DatabaseContext())
            {
                var workOrder = db.WorkOrders.FirstOrDefault(wo => wo.IDWorkOrder == workOrderForUpdate.IDWorkOrder);
                db.Entry(workOrder).CurrentValues.SetValues(workOrderForUpdate);
                db.SaveChanges();
            }

        }

        public static List<Item> GetWorkOrderItems(int workOrderID)
        {
            List<Item> workOrderItems = new List<Item>();
            using (var db = new DatabaseContext())
            {
                var items = db.WorkOrdersItems.Where(wo => wo.WorkOrderID == workOrderID);
                foreach (WorkOrdersItems item in items)
                {
                    workOrderItems.Add(ItemByID(item.ItemID));
                }
            }
            return workOrderItems;
        }

        public static void UpdateItem(Item itemForUpdate)
        {
            using (var db = new DatabaseContext())
            {
                var item = db.Items.FirstOrDefault(i => i.IDItem == itemForUpdate.IDItem);
                db.Entry(item).CurrentValues.SetValues(itemForUpdate);
                db.SaveChanges();
            }
        }

        private static Item ItemByID(int itemID)
        {
            using (var db = new DatabaseContext())
            {
                var item = db.Items.FirstOrDefault(i => i.IDItem == itemID);
                return item;
            }
        }
        public static void UpdateWorkOrderItems(List<Item> items, WorkOrder selectedWorkOrder)
        {
            using (var db = new DatabaseContext())
            {
                var workOrder = db.WorkOrders.FirstOrDefault(wo => wo.IDWorkOrder == selectedWorkOrder.IDWorkOrder);
                db.WorkOrdersItems.RemoveRange(db.WorkOrdersItems.Where(woi => woi.WorkOrderID == selectedWorkOrder.IDWorkOrder));
                addItemsToWorkOrder(workOrder, items, db);
            }
        }

        public static void AddWorkOrderItems(List<Item> items, int IDUser)
        {
            using (var db = new DatabaseContext())
            {
                var workOrder = db.WorkOrders.OrderByDescending(p=> p.IDWorkOrder).FirstOrDefault(wo => wo.User.IDUser == IDUser);
                addItemsToWorkOrder(workOrder, items, db);
            }
        }

        private static void addItemsToWorkOrder(WorkOrder workOrder, List<Item> items, DatabaseContext db)
        {
            foreach (Item item in items)
            {
                WorkOrdersItems newworkOrderItem = new WorkOrdersItems(workOrder.IDWorkOrder, item.IDItem);
                db.WorkOrdersItems.Add(newworkOrderItem);
                db.SaveChanges();
            }
        }

        public static List<Item> GetItems()
        {
            using(var db = new DatabaseContext())
            {
                var items = db.Items.ToList();
                return items;
            }
        }

        public static void AddBuyer(Buyer buyer)
        {
            using(var db = new DatabaseContext())
            {
                db.Buyers.Add(buyer);
                db.SaveChanges();
            }
        }

        public static List<Buyer> GetBuyers()
        {
            using (var db = new DatabaseContext())
            {
                var buyers = db.Buyers.ToList();
                return buyers;
            }
        }

        public static void AddItem(Item item)
        {
            using (var db = new DatabaseContext())
            {
                db.Items.Add(item);
                db.SaveChanges();
            }
        }

    }
}
