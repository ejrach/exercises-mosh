using System;

namespace UpcastingAndDowncasting
{
    class Program
    {
        //Upcasting - conversion from a derived class to a base class
        //Downcasting - conversion from a base class to a derived class
        static void Main(string[] args)
        {
            //Using upcasting (derived to base), we define a Text object. Then define a shape object.
            //Now both text and shape are pointing to the same object in memory.
            //What's the point? we get into polymorphism.
            Text text = new Text();
            Shape shape = text;

            text.Width = 200;
            shape.Width = 100;

            Console.WriteLine(text.Width); //we will get 100, because the shape width property is overwritten


            //Using downcasting (base to derived)
            Shape shape1 = new Text();
            Text text1 = (Text)shape1;
            
        }
    }
}
