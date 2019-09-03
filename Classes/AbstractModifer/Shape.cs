using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractModifer
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Draw();    //Here, we define this as abstract because on purpose, there is no implementation.
                                        //We are leaving it to the derived classes to implement/override the Draw method

        public void Copy()              //Here we are not declaring override because we want the derived classes to inherit this method, with no changed behavior.
        {
            Console.WriteLine("Copy shape into clipboard");
        }

        public void Select()
        {
            Console.WriteLine("Select the shape.");
        }
        
    }
}
