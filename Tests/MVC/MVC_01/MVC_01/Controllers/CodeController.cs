using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_01.Models;

namespace MVC_01.Controllers
{
    
    public class CodeController : Controller
    {
        private NorthwindContext db = new NorthwindContext();
        // GET: Code
        public ActionResult Index()
        {
            var germany_Customers = db.Customers.Where(c => c.Country == "Germany").ToList();
            return View(germany_Customers);            
        }

        public ActionResult GetCustomerDetails()
        {
            var customerDetails = db.Orders
                .Where(o => o.OrderID == 10248)
                .Select(o => new CustomerDetails
                {
                    CustomerID = o.Customer.CustomerID,
                    CompanyName = o.Customer.CompanyName,
                    ContactName = o.Customer.ContactName,
                })
                .FirstOrDefault();

            return View(customerDetails);
        }
    }
}