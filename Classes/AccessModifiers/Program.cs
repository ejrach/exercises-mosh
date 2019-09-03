using Amazon;
using System;

namespace AccessModifiers
{
    class Program
    {
        //An access modifier is a way to control access to a class and/or its members.
        //This creates safety and robustness in our programs.

        //Different types of access modifiers:
        //1. public - accessible form anywhere
        //2. private - accessible only from class. Use this most of the time.
        //3. protected - accessible only from the class and its derived class - try to avoid, 
        //      actually violates encapsulation. Use private instead
        //4. internal - accessible only from the same assembly
        //5. protected internal - accessible only from the same assembly or any derived classes. Try to avoid as well.

        static void Main(string[] args)
        {
            //When you create an object here, information hiding (or encapsulation) is when
            //you can't access private data.
            var person = new Person();

            person.SetBirthdate(new DateTime(1982, 1, 1));
            Console.WriteLine(person.GetBirthdate());


            var customer = new Customer();
            //Amazon.RateCalculator calculator = new Amazon.RateCalculator(); //RateCalculator is not visible since we made the class "internal" instead of public

            
        }
    }
}
