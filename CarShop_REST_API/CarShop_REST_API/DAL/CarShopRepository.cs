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
        #region PickUps
        public static void AddPickUpRequest(PickUp pickupRequest)
        {
            using (var db = new DatabaseContext())
            {
                db.PickUps.Attach(pickupRequest);
                db.SaveChanges();
            }
        }
        public static PickUp GetUserPickUpRequest(int iDUserMobile)
        {
            using (var db = new DatabaseContext())
            {
                var pickUp = db.PickUps.OrderBy(p => p.IDPickup).Include(p => p.User).LastOrDefault(p => p.User.IDUserMobile == iDUserMobile);
                return pickUp;
            }
        }


        public static List<PickUp> GetPickups()
        {
            using (var db = new DatabaseContext())
            {
                var pickUps = db.PickUps.Where(p => p.Done == false).Include(p => p.User).ToList();
                return pickUps;
            }
        }

        public static void CompletePickup(PickUp pickUp)
        {
            using (var db = new DatabaseContext())
            {
                var pUp = db.PickUps.FirstOrDefault(p => p.IDPickup == pickUp.IDPickup);
                db.Entry(pUp).CurrentValues.SetValues(pickUp);
                db.SaveChanges();
            }
        }

        public static void CompleteTask(Model.Task completedTask)
        {
            using (var db = new DatabaseContext())
            {
                var task = db.Tasks.FirstOrDefault(t => t.IDTask == completedTask.IDTask);
                db.Entry(task).CurrentValues.SetValues(completedTask);
                db.SaveChanges();
            }
        }

        #endregion

        #region Appointments
        public static List<Appointment> GetAppointments()
        {
            using (var db = new DatabaseContext())
            {
                var appointemnts = db.Appointments.ToList();
                return appointemnts;
            }
        }

        public static void UpdateAppointentState(Appointment appointmentForUpdate)
        {
            using (var db = new DatabaseContext())
            {
                var appointment = db.Appointments.FirstOrDefault(a => a.IDAppointment == appointmentForUpdate.IDAppointment);
                db.Entry(appointment).CurrentValues.SetValues(appointmentForUpdate);
                db.SaveChanges();
            }
        }

        public static void AppointmentStateWorking(int iDAppointment)
        {
            Appointment app = new Appointment();
            using (var db = new DatabaseContext())
            {
                var appointment = db.Appointments.FirstOrDefault(a => a.IDAppointment == iDAppointment);
                appointment.State = State.Working;
                app = appointment;
                db.Entry(appointment).CurrentValues.SetValues(app);
                db.SaveChanges();
            }
            
        }

        public static List<Appointment> GetUserAppointments(int idUser)
        {
            using (var db = new DatabaseContext())
            {
                var appointemts = db.Appointments.Where(a => a.User.IDUserMobile == idUser).Include(a => a.User).ToList();
                return appointemts;
            }
        }

        public static List<Model.Task> GetWorkersTasks(int iDUser)
        {
            using (var db = new DatabaseContext())
            {
                var tasks = db.Tasks.Where(t => t.User.IDUser == iDUser).Where(t => t.Completed == false).Include(t => t.User)
                                                                                                         .Include(t => t.WorkOrder).ThenInclude(w => w.Buyer)
                                                                                                         .Include(t => t.WorkOrder).ThenInclude(w => w.User)
                                                                                                         .Include(t => t.WorkOrder).ThenInclude(w => w.Appointment)
                                                                                                         .ToList();
                return tasks;
            }
        }

        public static List<Appointment> GetBuyerAppointments(string email)
        {
            using (var db = new DatabaseContext())
            {
                var appointmetns = db.Appointments.Where(a => a.User.Email == email).Include(a => a.User).ToList();
                return appointmetns;
            }
        }

        public static List<Appointment> GetDateAppointments(string date)
        {
            using (var db = new DatabaseContext())
            {
                var appointments = db.Appointments.OrderBy(a=> a.Time).Where(a => a.Date == date).Include(a => a.User).ToList();
                return appointments;
            }
        }

        public static Appointment GetAppointment(int iDUserMobile)
        {
            using (var db = new DatabaseContext())
            {
                var appointment = db.Appointments.OrderBy(a => a.IDAppointment).Include(a => a.User).LastOrDefault(a => a.User.IDUserMobile == iDUserMobile);
                return appointment;
            }
        }

        public static void AddAppointment(Appointment appointment)
        {
            using (var db = new DatabaseContext())
            {
                db.Appointments.Attach(appointment);
                db.SaveChanges();
            }
        }

        #endregion

        #region UserMobile
        public static void AddUserMobile(UserMobile userMobile)
        {
            using (var db = new DatabaseContext())
            {
                db.UsersMobile.Add(userMobile);
                db.SaveChanges();
            }
        }

        public static UserMobile GetUserMobile(string email)
        {
            using (var db = new DatabaseContext())
            {
                var user = db.UsersMobile.FirstOrDefault(um => um.Email == email);
                return user;
            }
        }
        public static UserMobile AuthorizeUserMobile(UserModel login)
        {
            using (var db = new DatabaseContext())
            {
                var usersMobile = db.UsersMobile.FirstOrDefault(um => um.Username == login.Username && um.Password == login.Password);
                return usersMobile;
            }
        }

        #endregion

        #region User
        public static List<User> GetUsers()
        {
            using (var db = new DatabaseContext())
            {
                var users = db.Users.ToList();
                return users;
            }
        }

        public static User AuthorizeUser(UserModel login)
        {
            return GetUsers().FirstOrDefault(x => x.Username == login.Username && x.Password == login.Password);
        }


        public static List<User> GetWorkers()
        {
            using (var db = new DatabaseContext())
            {
                var workers = db.Users.Where(u => u.Role == Role.User).ToList();
                return workers;
            }
        }

        #endregion

        #region Buyer
        public static List<Buyer> GetBuyers()
        {
            using (var db = new DatabaseContext())
            {
                var buyers = db.Buyers.ToList();
                return buyers;
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

        public static void UpdateBuyer(Buyer buyerForUpdate)
        {
            using (var db = new DatabaseContext())
            {
                var buyer = db.Buyers.FirstOrDefault(b => b.IDBuyer == buyerForUpdate.IDBuyer);
                db.Entry(buyer).CurrentValues.SetValues(buyerForUpdate);
                db.SaveChanges();
            }
        }



        #endregion

        #region Item
        public static List<Item> GetItems()
        {
            using(var db = new DatabaseContext())
            {
                var items = db.Items.ToList();
                return items;
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

        public static void DeleteItem(int itemID)
        {
            using (var db = new DatabaseContext())
            {
                var item = db.Items.FirstOrDefault(i => i.IDItem == itemID);
                db.WorkOrdersItems.RemoveRange(db.WorkOrdersItems.Where(woi => woi.ItemID == itemID));
                db.Remove(item);
                db.SaveChanges();
            }
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
        private static Item getItemByID(int itemID)
        {
            using (var db = new DatabaseContext())
            {
                var item = db.Items.FirstOrDefault(i => i.IDItem == itemID);
                return item;
            }
        }

        #endregion

        #region Work Order
        public static List<WorkOrder> GetWorkOrders()
        {
            using (var db = new DatabaseContext())
            {
                var workOrders = db.WorkOrders.Include(wo => wo.User)
                                              .Include(wo => wo.Buyer)
                                              .Include(wo => wo.Appointment)
                                              .ToList();
                return workOrders;
            }
        }
        public static List<WorkOrder> GetNotAssignedWorkOrders()
        {
            using (var db = new DatabaseContext())
            {
                var notAssigned = db.WorkOrders.Where(wo => wo.Assigned == false).Include(wo => wo.User)
                                                                                 .Include(wo => wo.Buyer)
                                                                                 .Include(wo => wo.Appointment)
                                                                                 .ToList();
                return notAssigned;
            }
        }
        public static void AddWorkOrder(WorkOrder workOrder)
        {
            using (var db = new DatabaseContext())
            {
                db.WorkOrders.Attach(workOrder);
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
        public static List<WorkOrder> GetBuyerWorkOrders(int idBuyer)
        {
            using (var db = new DatabaseContext())
            {
                var workOrders = db.WorkOrders.Where(wo => wo.Buyer.IDBuyer == idBuyer).Include(wo => wo.User)
                                                                                       .Include(wo => wo.Buyer)
                                                                                       .Include(wo => wo.Appointment)
                                                                                       .ToList();
                return workOrders;
            }
        }
        public static void AddWorkOrderItems(List<ItemQuantity> items, int IDUser)
        {
            using (var db = new DatabaseContext())
            {
                var workOrder = db.WorkOrders.OrderByDescending(p=> p.IDWorkOrder).FirstOrDefault(wo => wo.User.IDUser == IDUser);
                addItemsToWorkOrder(workOrder, items, db);
            }
        }

        private static void addItemsToWorkOrder(WorkOrder workOrder, List<ItemQuantity> items, DatabaseContext db)
        {
            foreach (ItemQuantity item in items)
            {
                WorkOrdersItems newworkOrderItem = new WorkOrdersItems(workOrder.IDWorkOrder, item.Item.IDItem,item.Quantity);
                db.WorkOrdersItems.Add(newworkOrderItem);
                db.SaveChanges();
            }
        }

        public static void UpdateWorkOrderItems(List<ItemQuantity> items, WorkOrder selectedWorkOrder)
        {
            using (var db = new DatabaseContext())
            {
                var workOrder = db.WorkOrders.FirstOrDefault(wo => wo.IDWorkOrder == selectedWorkOrder.IDWorkOrder);
                db.WorkOrdersItems.RemoveRange(db.WorkOrdersItems.Where(woi => woi.WorkOrderID == selectedWorkOrder.IDWorkOrder));
                addItemsToWorkOrder(workOrder, items, db);
            }
        }


        public static List<ItemQuantity> GetWorkOrderItems(int workOrderID)
        {
            List<ItemQuantity> workOrderItems = new List<ItemQuantity>();
            using (var db = new DatabaseContext())
            {
                var items = db.WorkOrdersItems.Where(wo => wo.WorkOrderID == workOrderID);
                foreach (WorkOrdersItems item in items)
                {
                    ItemQuantity newItemQuantity = new ItemQuantity(getItemByID(item.ItemID), item.Quantity);
                    workOrderItems.Add(newItemQuantity);
                }
            }
            return workOrderItems;
        }
        #endregion

        #region Receipt
        public static List<Receipt> GetReceiptsByYear(string year)
        {
            using (var db = new DatabaseContext())
            {
                var receipts = db.Receipts.Where(r => r.DateOfReceipt.Year.ToString() == year).Include(r => r.Buyer)
                                                                                              .Include(r => r.User)
                                                                                              .ToList();
                return receipts;
            }
        }

        public static List<Receipt> GetReceipts()
        {
            using(var db = new DatabaseContext())
            {
                var receipts = db.Receipts.Include(r => r.Buyer)
                                          .Include(r => r.User)
                                          .ToList();
                return receipts;
            }
        }


        public static void AddReceipt(Receipt receipt)
        {
            using (var db = new DatabaseContext())
            {
                db.Receipts.Attach(receipt);
                db.SaveChanges();
            }
        }
        public static void AddReceiptItems(List<WorkOrder> workOrders,int IDUser)
        {
            using (var db = new DatabaseContext())
            {
                var receipt = db.Receipts.OrderByDescending(r => r.IDReceipt).FirstOrDefault(r => r.User.IDUser == IDUser);
                addWorkOrdersToReceipt(receipt, workOrders, db);
            }
        }

        private static void addWorkOrdersToReceipt(Receipt receipt, List<WorkOrder> workOrders, DatabaseContext db)
        {
            foreach (WorkOrder workOrder in workOrders)
            {
                ReceiptWorkOrders newReceiptWorkOrder = new ReceiptWorkOrders(receipt.IDReceipt, workOrder.IDWorkOrder);
                db.ReceiptWorkOrders.Add(newReceiptWorkOrder);
                db.SaveChanges(); 
            }
        }
        #endregion

        #region Task
        public static void AssignTask(Model.Task newTask)
        {
            using (var db = new DatabaseContext())
            {
                db.Tasks.Attach(newTask);
                db.SaveChanges();
            }
        }
        #endregion
    }
}
