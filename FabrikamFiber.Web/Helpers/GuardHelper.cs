using FabrikamFiber.DAL.Models;
using FabrikamFiber.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FabrikamFiber.Web.Helpers
{
    public class GuardHelper
    {

        public static CustomersController GuardCustomer()
        {
            CustomersController controller = new CustomersController(null);
            controller.Create(new Customer());

            return controller;
        }
    }
}