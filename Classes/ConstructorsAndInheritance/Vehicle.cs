using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorsAndInheritance
{
    //This is the base class
    public class Vehicle
    {
        private readonly string _registrationNumber;    //readonly means we only want one instance of a reg. number created per car

        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle is being initialized.");
        //}

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;

            Console.WriteLine("Vehicle is being initialized. {0}", registrationNumber);
        }
    }
}
