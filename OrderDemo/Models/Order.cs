using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderDemo.Models
{
    public class Order
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }

        public virtual List<OrderDetails> OrderDetailsList { get; set; }
    }
}