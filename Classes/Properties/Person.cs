using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    public class Person
    {
        //The Person class in the "AccessModifiers" project can be rewritten like this using properties get/set
        //This is an auto implemented property where there is no need to declare a private field to store data.
        //C# compiler handles it for us. Here we are hiding the set property using private. The field is instead set
        //through the constructor above.
        public DateTime Birthdate { get; private set; }
        public string Name { get; set; }

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }

            //We are not using a set method, because we want the age to be calculated, not set.
        }
    }
}
