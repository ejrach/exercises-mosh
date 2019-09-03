using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon
{
    //Defining the RateCalculator as 'internal' here means that it's only visible to the Amazon domain/namespace.
    //It won't be visible to any other assembly.
    internal class RateCalculator
    {
        public int Calculate(Customer customer)
        {
            return 0;
        }
    }
}
