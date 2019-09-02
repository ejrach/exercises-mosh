using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
    public class Person
    {
        //Make this private to hide the data - Encapsulation principal of OOP
        //Why would you make this private, and then just define methods to change it? Because their fields should be hidden,
        //and behavior should be hidden from the outside world.
        private DateTime _birthdate;

        //But can define public getter and setter methods to retrieve the data
        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }
}
