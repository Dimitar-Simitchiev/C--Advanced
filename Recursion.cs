using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Recurs
{
    public class Program
    {     


     
         public static int Recursion(int n)
        {
            if (n==0)
            {
                return 1;
            }
            return Recursion(n-1)*n;
            
        }
        
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Recursion(n));
        
        }
        ////////////////////////////////////////////////////////////////////////
        
        public static int Recursion2(int[] arr, int index)
        {
            if (index < 1)
            {
                return 0;
            }
            else
            {
                return Recursion2(arr, index - 1) + arr[index - 1];

            }


        }
        public static int Recursion3(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return Recursion3(n - 1) * n;

        }

       


    }
}
