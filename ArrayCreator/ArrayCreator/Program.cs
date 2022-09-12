using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayCreator
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var names= ArrayCreator.Create(10, "Mitko");
            var numbers= ArrayCreator.Create(10, 1);

            foreach (var item in names)
            {
                Console.Write(item);
            }
            foreach (var item in numbers)
            {
                Console.Write(item);
            }
        }
    }
}
