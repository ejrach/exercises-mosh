using System;
using System.Collections.Generic;
using System.Text;

namespace MethodOverriding
{
    public class Circle : Shape
    {
        //Typing "override" gives us this Draw base method from the base class Shape.
        //Now we can write any code that is specific to the circle itself.
        //Here we are using encapsulation (hiding the implementation of the Draw method)
        //and using polymorphism to change the behavior of the Circles' Draw method.
        public override void Draw()
        {
            Console.WriteLine("Draw a circle.");
        }
    }

    public class Rectangle : Shape
    {
        //Typing "override" gives us this Draw base method from the base class Shape.
        //Now we can write any code that is specific to the rectangle itself.
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle.");
        }
    }

    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Position Position { get; set; }

        //We declare the Draw method as virtual because the behavior of drawing a Circle cs a Rectangle
        //is going to be different. Virtual gives us the opportunity to change the behavior of "Draw"
        public virtual void Draw()
        {

        }

    }
}
