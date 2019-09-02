using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{

    //This parent class defines some common functionality
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object was copied to clipboard");
        }

        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated");
        }
    }
}
