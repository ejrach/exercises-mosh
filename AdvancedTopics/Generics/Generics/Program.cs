using System;

namespace Generics
{
    class Program
    {
        //Generic lists are very rarely used in applications. Probably won't need to create your own, but instead
        //just use ones that exist.

        static void Main(string[] args)
        {
            var book = new Book { Isbn = "1111", Title = "C# advanced" };

            var numbers = new GenericList<int>();
            numbers.Add(10);

            var books = new GenericList<Book>();
            books.Add(new Book());

            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1234", new Book());


            var number = new Nullable<int>();
            Console.WriteLine("Has Value ?" + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());
        }
    }
}
