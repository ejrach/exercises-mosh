﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Models;
using Vidly.Dtos;
using AutoMapper;

namespace Vidly.Controllers.Api
{
    //This is how you define web api with ASP.NET Web Api
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }


        //We want to return a list of customers.
        //This is the convention built into ASP.NET Web API:
        // GET /api/customers
        public IHttpActionResult GetCustomers()
        {
            var customerDtos = _context.Customers.ToList().Select(Mapper.Map<Customer, CustomerDto>);

            return Ok(customerDtos);
        }

        //We want to return a single customer.
        //This will respond to a request like this:
        // GET /api/customers/1
        public IHttpActionResult GetCustomer(int id)
        {
            //get the customer
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            //if the customer is not found
            if (customer == null)
                return NotFound();

            //otherwise return the customer
            return Ok(Mapper.Map<Customer,CustomerDto>(customer));
        }

        //To create a customer, post a customer to customers collection:
        // POST /api/customers
        [HttpPost]  //we do this because we are 'creating' a resource, not getting one.
        public IHttpActionResult CreateCustomer(CustomerDto customerDto)
        {
            //First we validate the object, and throw exception if model is not valid
            if (!ModelState.IsValid)
                return BadRequest();

            //We need to map the customerDto back to our domain model.
            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);

            //otherwise we add it to our context and save the changes
            _context.Customers.Add(customer);
            _context.SaveChanges();

            customerDto.Id = customer.Id;

            //At this point the Id of the customer will be generated by the server and be returned by the object.
            //As part of RESTful convention, we need to return the URI of the newly created resource to the client.
            //i.e. /api/customers/10
            return Created(new Uri(Request.RequestUri + "/" + customer.Id), customerDto);

        }

        //To update a customer:
        // PUT /api/customers/1
        [HttpPut]
        public IHttpActionResult UpdateCustomer(int id, CustomerDto customerDto)
        {
            //First we validate the object, and throw exception if model is not valid
            if (!ModelState.IsValid)
                return BadRequest();

            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            //It's possible that the client sends an invalid Id so we need to check for the existence of the object.
            if (customerInDb == null)
                return NotFound();

            Mapper.Map(customerDto, customerInDb);

            _context.SaveChanges();

            return Ok();
        }

        //To delete a customer:
        // DELETE /api/customers/1
        [HttpDelete]
        public IHttpActionResult DeleteCustomer(int id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            //It's possible that the client sends an invalid Id so we need to check for the existence of the object.
            if (customerInDb == null)
                return NotFound();

            _context.Customers.Remove(customerInDb);

            _context.SaveChanges();

            return Ok();
        }
    }
}
