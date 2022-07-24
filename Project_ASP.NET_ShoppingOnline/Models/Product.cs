using System;
using System.Collections.Generic;

#nullable disable

namespace Project_ASP.NET_ShoppingOnline.Models
{
    public partial class Product
    {
        public Product()
        {
            OrdersDetails = new HashSet<OrdersDetail>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }
        public int? UnitsInStock { get; set; }
        public int? UnitsOnOrder { get; set; }
        public int CategoryId { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public bool? Status { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<OrdersDetail> OrdersDetails { get; set; }
    }
}
