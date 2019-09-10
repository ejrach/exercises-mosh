using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    //In this view model, encapsulating all of the data required for 
    //displaying data within the New Customer View.
    //This ViewModel needs to exist in order to pass a view object within CustomersController
    public class CustomerFormViewModel
    {
        //List of membership types for the dropdown
        public IEnumerable<MembershipType> MembershipTypes { get; set; }

        //Let's reuse the Customer model
        public Customer Customer { get; set; }

        public string Title
        {
            get
            {
                if (Customer != null && Customer.Id != 0)
                    return "Edit Customer";
                return "New Customer";
            }
        }
    }
}