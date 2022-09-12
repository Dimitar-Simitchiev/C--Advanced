using System;
using System.Collections.Generic;
using System.Text;

namespace GenericScale2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "1";
            string b = "1";
            EqualityScale<string> str = new EqualityScale<string>(a,b);
           
            Console.WriteLine( str.AreEqual());
        }
    }
}
