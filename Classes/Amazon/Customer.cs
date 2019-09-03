using System;

namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            //NOTE: there is a better way to instantiate an object so that it's not here in another class. See the "Interfaces" lecture
            var calculator = new RateCalculator();
            var rating = calculator.Calculate(this);    //'this' means we're passing the "Customer" object to the Calculate method

            Console.WriteLine("Promote logic changed.");
        }
    }
}
