using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderDemo.Models
{
    public class OrderDetails
    {
        public int ID { get; set; }

        public int OrderID { get; set; }

        public int ProductID { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public decimal TotalPrice { get; set; }

        [ForeignKey("OrderID")]
        public virtual Order Order { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }
    }
}