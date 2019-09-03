using System;
using System.Collections;
using System.Collections.Generic;

namespace BoxingAndUnboxing
{
    class Program
    {
        //Value types
        //- stored on the stack
        //- primitive types like: byte, float, int...

        //Reference types
        //- stored in the heap. Done if we need objects to have a longer lifetime
        //- any classes like: object, array, string

        //Boxing - the process of converting a value type instance to an object --> stored on the heap

        //Unboxing - is the opposite --> stored on the stack
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1);
            list.Add("Eric");
            list.Add(DateTime.Today);

            //var number = (int)list[1];        //will get an cast error

            //This stores list of integers - no boxing occurs
            var anotherList = new List<int>();
            anotherList.Add(1);
            
        }
    }
}
