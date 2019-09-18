using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    //This is a custom validation. This class should be added first before adding the Data Annotation to the birthdate property.
    //We need to derive this class from ValidationAttribute, which is defined in DataAnnotations
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            //Business rule: if the membership type is not selected OR "Pay as you go" then we don't care of the 
            //age of the customer.
            //If they go on a paid membership, then we want their age to be at least 18 years old.
            if (customer.MembershipTypeId == 0 || customer.MembershipTypeId == 1)
                return ValidationResult.Success;

            if (customer.Birthdate == null)
                return new ValidationResult("Birthdate is required.");

            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            return (age >= 18) ?
                ValidationResult.Success :
                new ValidationResult("Customer should be at least 18 years old to go on a membership.");

        }
    }
}