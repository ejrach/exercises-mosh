using System;
using System.Collections.Generic;
using System.Text;

namespace Fields
{
    public class Customer
    {
        // Fields
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>(); //Use readonly modifier when you only want one instance to be created

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            //Orders = new List<Order>();       //If we didn't use the readonly modifier above, then this would re-initialize the Orders list.
        }
    }
}
