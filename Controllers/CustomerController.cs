using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoffeeShop.Models;
using CoffeeShop.ViewModel;

namespace CoffeeShop.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult Index()
        {
            var awit = _context.CustomerModels.ToList();
            return View("CustomerView");
        }

        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        public ActionResult New()
        {
            var customerList = _context.CustomerModels.ToList();
            var viewModel = new CustomerViewModel()
            {
                CustomerList = customerList
            };
            return View("CustomerView", viewModel);
        }

        public ActionResult Save(CustomerModel customerModel)
        {
            if (customerModel.Id == 0)
            {
                customerModel.DateAdded = DateTime.Now;
                _context.CustomerModels.Add(customerModel);
            }

            _context.SaveChanges();
            return RedirectToAction("New", "Customer");
        }
    }
}



