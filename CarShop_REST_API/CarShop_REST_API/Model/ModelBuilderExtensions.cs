using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop_REST_API.Model
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    IDUser = 1,
                    Role = Role.Admin,
                    Email = "ipad3monkey@gmail.com",
                    Username = "MartyParty97",
                    Password = "martin123"
                },
                new User
                {
                    IDUser = 2,
                    Role = Role.User,
                    Email = "marko@gmail.com",
                    Username = "Marko",
                    Password = "marko123"
                });
        }
    }
}
