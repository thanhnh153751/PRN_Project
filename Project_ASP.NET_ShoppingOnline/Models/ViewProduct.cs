using System;
using System.Collections.Generic;

#nullable disable

namespace Project_ASP.NET_ShoppingOnline.Models
{
    public partial class ViewProduct
    {
        public int? ProductId { get; set; }
        public int? View { get; set; }
        public DateTime? Viewdate { get; set; }

        public virtual Product Product { get; set; }
    }
}
