using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MbmStore.Models;
namespace MbmStore.Controllers
{
    public class CustomerController : Controller
    {

        //public ActionResult Index()
        //{

        //    Customer firstCustomer = new Customer("Maria", "Dima", 20, "Jernbanegade 24", "7100", "Vejle");
        //    Customer secondCustomer = new Customer("Alexandra", "Dima", 20, "Jernbanegade 30", "7100", "Vejle");
        //    Customer thirdCustomer = new Customer("George", "Marian", 20, "Jernbanegade 30", "7100", "Vejle");

        //    /*
        //    List<string> PhoneNumbers = new List<string>()
        //    {
        //    PhoneNumbers.Add("2222222");
        //    PhoneNumbers.Add("2222222");
        //}
        //*/


        //    // assign a viewbag property to the new Movie object
        //    ViewBag.FirstCustomer = firstCustomer;
        //    ViewBag.SecondCustomer = secondCustomer;
        //    ViewBag.ThirdCustomer = thirdCustomer;

        //    return View();
        //}


        public ActionResult Index()
        {
            var customers = GetInMemoryCustomers();

            return View(customers);
        }




        //Helpers
        private static List<Customer> GetInMemoryCustomers()
        {
            return new List<Customer>
            {
                new Customer("Maria", "Dima", "Jernbanegade 24", "7100", "Vejle"),
                new Customer("Alexandra", "Dima", "Jernbanegade 30", "7100", "Vejle"),
                new Customer("George", "Marian", "Jernbanegade 30", "7100", "Vejle"),
                new Customer("Jon", "Doe", "Abc Street 30", "7100", "Vejle", new DateTime(1982,1,1)),
                new Customer("Jane", "Doe", "Abc Street 20", "7100", "Vejle", new DateTime(1992,5,5)),
                GetSampleCustomerWithPhoneNumbers()
            };
        }


        private static Customer GetSampleCustomerWithPhoneNumbers()
        {
            var sampleCustomer = new Customer("Mr.", "Robot", "Jernbanegade 24", "7100", "Vejle", new DateTime(1994,2,5));
            sampleCustomer.AddPhone("123-456-000");
            sampleCustomer.AddPhone("423-456-000");
            return sampleCustomer;
        }



    }
}
