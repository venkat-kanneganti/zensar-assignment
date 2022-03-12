using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCAssignment.Models;

namespace MVCAssignment.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        NorthwindEntities ne = new NorthwindEntities();
        public ActionResult Index()
        {
            return View();
        }

        //Getting Customers who are residing in Germany
        public ActionResult CustomersResidinginGermany()
        {
            List<string> Cust = (from g in ne.Customers
                                 where g.Country == "Germany"
                                 select g.ContactName).ToList();
            return View(Cust);
        }
        //Getting Customer details whose customer id is 10248
        public ActionResult CustomerWithOrderID()
        {
            List<Customer> CUST = (from r in ne.Customers
                                   join o in ne.Orders
           on r.CustomerID equals o.CustomerID
                                   where o.OrderID == 10248
                                   select r).ToList();
            return View(CUST);
        }
    }
}
