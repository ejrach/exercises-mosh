using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class OrderProcessor
    {
        private readonly IShippingCalculator _shippingCalculator;

        //Using interfaces creates loose coupling and we are no longer dependent on concrete classes.
        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator;
        }

        //Order processing method
        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("This order is already processed.");

            //Shipment object has two properties: Cost, ShippingDate
            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
}
