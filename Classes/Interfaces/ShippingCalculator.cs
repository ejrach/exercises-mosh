using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    //This interface provides the capability that a class should provide.
    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }

    //Read as: ShippingCalculator implements IShippingCalculator
    public class ShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f;

            return 0;
        }
    }
}
