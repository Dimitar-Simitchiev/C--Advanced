using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndCompilators
{
    internal class Program
    {
        static void Main(string[] args)
        {   var book = new Library(); 
           book.AddBook(new Book("Sun2", 1024, new List<string> { "michel1", "Sella1" }));
            book.AddBook(new Book("Sun3", 1025, new List<string> { "michel2", "Sella2" }));
            book.AddBook(new Book("Sun4", 1026, new List<string> { "michel3", "Sella3" }));





            foreach (var item in book)
            {
                for (int i = 0; i < item.Authors.Count; i++)
                {
                    Console.Write(item.Authors[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
