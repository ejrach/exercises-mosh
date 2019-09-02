using System;

namespace Properties
{
    class Program
    {
        //Properties is a class member that encapusulates a getter and setter for accessing a field.
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1975, 6, 3));
            Console.WriteLine(person.Age);
        }
    }
}
