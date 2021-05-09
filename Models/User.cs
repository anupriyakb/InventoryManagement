using System;
using System.Collections.Generic;

#nullable disable

namespace InventoryManagement.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int Admin { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
