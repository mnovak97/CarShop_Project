using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop_REST_API.Model
{
    public enum Role
    {
        Admin,
        User
    }

    public class User
    {
        [Key]
        public int IDUser { get; set; }
        public Role Role { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


    }
}
