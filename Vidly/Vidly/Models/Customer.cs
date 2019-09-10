using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        //Tip: after adding a property it's a good idea to create migrations in small increments:
        //After adding a property like "IsSubscribedToNewsletter, go to PM
        //  PM > add-migration AddIsSubscribedToCustomer
        //  PM > Update-Database
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
        //? means to make Birthdate nullable
        //Apply data annotation for the HTML markup for the "Birthdate" property.
        [Display(Name = "Date of Birth")]

        public DateTime? Birthdate { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }
    }
}