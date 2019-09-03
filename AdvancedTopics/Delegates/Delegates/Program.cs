
using System;

namespace Delegates
{
    class Program
    {
        //A delegate is an object that knows how to call a method (or a group of methods)
        //It is also a reference to a function.
        //We need this to create applications that are extensible and flexible.

        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;

            processor.Process("photo.jpg", filterHandler);
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply RemoveRedEye");
            
        }
    }
}
