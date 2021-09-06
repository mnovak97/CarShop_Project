﻿using CarShop_REST_API.Context;
using CarShop_REST_API.Model;
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
                var workOrders = db.WorkOrders.ToList();
                return workOrders;
            }
        }

        public static User AuthorizeUser(UserModel login)
        {
            return GetUsers().FirstOrDefault(x => x.Username == login.Username && x.Password == login.Password);
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
