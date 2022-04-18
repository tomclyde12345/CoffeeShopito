using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CoffeeShop.Models;

namespace CoffeeShop.ViewModel
{
    public class CustomerViewModel
    {
        public IEnumerable<CustomerModel> CustomerList { get; set; }
        public CustomerModel CustomerModel { get; set; }
    }
}