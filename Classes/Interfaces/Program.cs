using System;

namespace Interfaces
{
    class Program
    {
        //Interfaces and Testability
        //Used to build loosely coupled applications and improve testability


        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process(order);
        }
    }
}
