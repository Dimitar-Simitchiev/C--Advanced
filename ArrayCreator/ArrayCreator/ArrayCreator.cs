using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ArrayCreator
{
    internal class ArrayCreator
    {


       
        
        public static T[] Create<T>(int lenght,T item)
        {
            T[] arr = new T[lenght];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = item; 

            } 
            return arr; 
           

        }
    }
}
