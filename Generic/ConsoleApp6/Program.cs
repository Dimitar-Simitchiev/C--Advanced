using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();
           
            box.Add(1);
            box.Add(2);
            box.Add(9);
            box.Add(7);

            Console.WriteLine(box.Peek());

           


        }
    }
}
