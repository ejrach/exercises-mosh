using System;

namespace Indexer
{
    class Program
    {
        //An indexer is a way to access elements in a class that represents a list of values.

        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Eric";
            Console.WriteLine(cookie["name"]);
        }
    }
}
