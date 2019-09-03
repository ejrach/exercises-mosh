using System;

namespace AbstractModifer
{
    class Program
    {
        //Abstract modifier indicates that a class or a member is missing implementation.
        //Rule 1: Abstract methods cannot contain implementation.
        //Rule 2: if a member is declared as abstract, the containing class needs to be declared as abstract too.
        //Rule 3: Must implement all abstract members in the base abstract class
        //Rule 4: Cannot be instantiated
        //What's the benefit? When you want to provide some common behavior, while forcing other developers to FOLLOW YOUR DESIGN
        static void Main(string[] args)
        {
            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();

            //Here's the benefit of abstract classes. It prevents the developer from creating a 'shape' object...because
            //really, what does a shape represent? We're just defining properties and methods within the shape so they 
            //can be derived. Uncomment to see the effect.
            //var shape = new Shape();

        }
    }
}
