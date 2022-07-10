using System;
using System.Collections.Generic;

#nullable disable

namespace Project_ASP.NET_ShoppingOnline.Models
{
    public partial class Order
    {
        public Order()
        {
            OrdersDetails = new HashSet<OrdersDetail>();
        }

        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int? ShipperId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int? Totalmoney { get; set; }
        public bool? Expired { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Shipper Shipper { get; set; }
        public virtual ICollection<OrdersDetail> OrdersDetails { get; set; }
    }
}
