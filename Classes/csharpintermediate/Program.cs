using System;

namespace Classes
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I amd {1}", to, Name);
        }

        //By declaring this instance method "Parse" as static (using static modifier) 
        //we can define a person object below and pass it the name
        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //By defining the "Parse" method as static, we can create a person object with a string
            var person = Person.Parse("John");
            person.Introduce("Eric");
        }
    }
}
