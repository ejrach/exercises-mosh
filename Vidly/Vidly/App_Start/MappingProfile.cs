using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        //Automapper maps properties based on their name. This is convention based mapping tool.
        public MappingProfile()
        {
            //Map a Customer to a CustomerDto
            Mapper.CreateMap<Customer, CustomerDto>();

            //Map a CustomerDto to a Customer
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}