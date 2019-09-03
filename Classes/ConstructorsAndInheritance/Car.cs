using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorsAndInheritance
{
    //This is a derived class
    public class Car : Vehicle
    {
        //When you derive a class from a base class (like Car from Vehicle) you don't inherit the constructor of the 
        //Vehicle class (which by the way, sets the registration number). So a way to do this is to use the base modifier
        //and pass the registration number when the Car object is created, to the base classes' constructor
        public Car(string registrationNumber)
            :base(registrationNumber)
        {
            Console.WriteLine("Car is being initialized. {0}", registrationNumber);
        }
    }
}
