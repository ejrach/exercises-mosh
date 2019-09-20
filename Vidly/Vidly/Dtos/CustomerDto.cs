using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.Dtos
{
    //DTO is Data Transfer Object.
    //Why are we using Dto's?
    //The Customer API returns customer objects. The customer object in the API is part of the domain model of the application.
    //It's considered implementation detail. If the Customer object changes it break the interface. 
    //So Dto's are one way to get around that, in addition to using Automapper to map the Dto customer object (seen here), to the 
    //Customer domain model.
    public class CustomerDto
    {
        //There is no need to include all of the other properties in the domain model
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        //[Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public byte MembershipTypeId { get; set; }

        public MembershipTypeDto MembershipType { get; set; }
    }
}