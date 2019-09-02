using System;

namespace ObjectInitializers
{
    class Program
    {
        public class Person
        {
            public int Id;
            public string FirstName;
            public string LastName;
            public DateTime Birthdate;
        }

        static void Main(string[] args)
        {
            //Instead of creating contructors for all of the properties above
            //we can use an object initializer like this, and reserve creating constructors for when we really
            //want or need to use them.

            var person = new Person { FirstName = "Eric", LastName = "R" };

        }
    }
}
