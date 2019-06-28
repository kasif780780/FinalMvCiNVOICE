using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderDemo.Models
{
    public class ProductCategory
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}