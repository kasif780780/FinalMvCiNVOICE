using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderDemo.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CategoryID { get; set; }

        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { get; set; }
        public virtual List<OrderDetails> OrderDetailsList { get; set; }
    }
}