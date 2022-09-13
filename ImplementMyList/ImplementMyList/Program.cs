using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementMyList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            list.Add(5);
            list.Add(10);
            list.Add(7);
            list.Add(10);
            list.Add(12);
         
            list.Print();
           
            



        }
    }
}
