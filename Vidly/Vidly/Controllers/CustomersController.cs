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
            var viewModel = new NewCustomerViewModel
            {
                //Set the list of membershipTypes to the view models' MembershipTypes property
                MembershipTypes = membershipTypes
            };

            return View(viewModel);
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
    }
}