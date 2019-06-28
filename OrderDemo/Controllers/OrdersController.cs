using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//
using OrderDemo.ViewModels;
using OrderDemo.Models;

namespace OrderDemo.Controllers
{
    public class OrdersController : Controller
    {
        // GET: Orders
        public ActionResult AddOrder()
        {
            return View();
        }

        [HttpPost]
        public JsonResult AddOrderAndOrderDetials(OrderViewModel orderViewModel)
        {
            bool status = true;

            var isValidModel = TryUpdateModel(orderViewModel);

            if (isValidModel)
            {
                using (MyAppContext db = new MyAppContext())
                {
                    Order order = new Order() {
                        Date = orderViewModel.Date
                    };
                    db.Orders.Add(order);

                    if (db.SaveChanges() > 0)
                    {
                        int orderID = db.Orders.Max(o => o.ID);

                        foreach (var item in orderViewModel.Items)
                        {
                            OrderDetails orderDetails = new OrderDetails() {
                                OrderID = orderID,
                                ProductID = item.ProductID,
                                Price = item.Price,
                                Quantity = item.Quantity,
                                TotalPrice = item.TotalPrice
                            };
                            db.OrderDetails.Add(orderDetails);
                        }

                        if (db.SaveChanges() > 0)
                        {
                            return new JsonResult { Data = new { status = status, message = "Order Added Successfully" } };
                        }
                    }
                }
            }

            status = false;
            return new JsonResult { Data = new { status = status, message = "Error !" } };
        }
    }
}