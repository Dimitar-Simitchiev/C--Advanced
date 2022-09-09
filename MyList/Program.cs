using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using System.IO;
namespace SoftUniExercises
{
    
  

    class Program
    {

        static void Main(string[] args)
        {
            MyList_Methods list = new MyList_Methods();
            list.Addfirst(1);
            list.Addfirst(100);
            list.Addfirst(50);

            Console.WriteLine(list.Count);
            
            Console.WriteLine(string.Join(", ",list.ToMyArry()));

        }
    }

}