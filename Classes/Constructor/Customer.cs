using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    //We overload constructors to make initialization easier. Sometimes we only know certain things
    //about an object.
    public class Customer
    {
        //declaring fields
        public int Id;
        public string Name;
        public List<Order> Orders;  //This represents a list of objects defined of class "Order"

        public Customer()
        {
            Orders = new List<Order>();     //Whenever we use lists, it's best practice to initialize them
        }

        //In this constructor, we are using ": this()". SO when this particlar constructor is called
        //with the 'id' initializer, it first calls the empty constructor "Customer()". We do this 
        //to avoid copying and pasting the "Orders" list initialization.
        public Customer(int id)
            : this()                            
        {
            this.Id = id;
        }

        //Using the same concept as above, by adding ": this(id)" we are first calling the constructor
        //with the 'id' initializer first, and that automaticall sets the id to what is passed into the 
        //constructor.
        public Customer(int id, string name)
            : this(id)
        {
            //this.Id = id;
            this.Name = name;
        }
    }
}
