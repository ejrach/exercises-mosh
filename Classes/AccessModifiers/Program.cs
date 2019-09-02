using System;

namespace AccessModifiers
{
    class Program
    {
        //An access modifier is a way to control access to a class and/or its members.
        //This creates safety and robustness in our programs.
        static void Main(string[] args)
        {
            //When you create an object here, information hiding (or encapsulation) is when
            //you can't access private data.
            var person = new Person();

            person.SetBirthdate(new DateTime(1982, 1, 1));
            Console.WriteLine(person.GetBirthdate());
            
        }
    }
}
