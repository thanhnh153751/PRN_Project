using System;
using System.Collections.Generic;

#nullable disable

namespace Project_ASP.NET_ShoppingOnline.Models
{
    public partial class OrdersDetail
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
