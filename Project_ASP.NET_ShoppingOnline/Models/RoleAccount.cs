using System;
using System.Collections.Generic;

#nullable disable

namespace Project_ASP.NET_ShoppingOnline.Models
{
    public partial class RoleAccount
    {
        public RoleAccount()
        {
            Customers = new HashSet<Customer>();
        }

        public int Role { get; set; }
        public string Rolename { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
