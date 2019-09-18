using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        //In order to query the database, we need to create a database context. 
        private ApplicationDbContext _context;

        //Create a constructor for the CustomersController that creates the DbContext for this
        //controller.
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        //The DbContext is a disposable object, se we need to properly dispose of the object.
        //So the proper way to do it is to override the dispose method of the base controller class.
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //Display the 'New' customer membership form with a list of the membership types
        public ActionResult New()
        {
            //First get the list of membership types
            var membershipTypes = _context.MembershipTypes.ToList();

            //Use a View Model that encapsulates all of the data required for this view
            var viewModel = new CustomerFormViewModel
            {
                //Set the list of membershipTypes to the view models' MembershipTypes property
                MembershipTypes = membershipTypes
            };

            return View("CustomerForm", viewModel);
        }

        //Define the 'Save' action for Customer. This is model binding. MVC framework binds
        //this model to the request data
        [HttpPost]
        public ActionResult Save(Customer customer)
        {
            //Use modelstate property to get access to validatation data.
            //Since we are requiring the Name property of Customer model,
            //we want to return the CustomerForm if the field is empty. So need 
            //to define the viewModel and return the form.
            if(!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel
                {
                    Customer = customer,
                    MembershipTypes = _context.MembershipTypes.ToList()

                };

                return View("CustomerForm", viewModel);
            }


            //if the customer Id is 0, then we have a new customer
            if (customer.Id == 0)
                //To save the data to the database, we need to create a context to it.
                _context.Customers.Add(customer);
            else
            {
                //Using the Single method here because if the given customer is not found, 
                //we want to throw an exception. This action should only be called anyways because of posting
                //the customer form.
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);

                customerInDb.Name = customer.Name;
                customerInDb.Birthdate = customer.Birthdate;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
            }


            //Persist the changes. This creates SQL statements at runtime, within a transaction.
            _context.SaveChanges();

            //Now redirect the customer to the Customers page "Index"
            return RedirectToAction("Index", "Customers");
        }

        // GET: Customers
        public ViewResult Index()
        {
            //the customers property is a dbset we defined in our DbContext.
            //A query to the database will immediately occur with the "ToList()" method.
            //We are using "Include" method here to load the Customers along with their Membership types
            //together (because it comes from another table). This is called "Eager Loading". 
            //"c" is customer, and it goes to c.MembershipType.
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            //A query to the database will immediately occur with the "SingleOrDefault()" method.
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        public ActionResult Edit (int id)
        {
            //First we need to get this customer with the customer id from the database.
            //If the customer with the given id exists it will be returned, otherwise null.
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            //New we need to render the new customer form, which is based on the View Model, and specify the 
            //view name.
            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList()
            };

            return View("CustomerForm", viewModel);
        }
    }
}