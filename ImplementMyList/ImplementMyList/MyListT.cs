using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;


namespace ImplementMyList
{
    internal class MyList
    {

        private const int count = 2;

        private int[] Listarry;
        public MyList()
        {
            Listarry = new int[count];  

        }
        public int Index { get;set;}    
        

        public void Add(int elemet)
        {
            if (Index==Listarry.Length)
            {
                int []temArr=new int[Listarry.Length*2];
               for (int i = 0; i < Listarry.Length; i++)
               {
                    temArr[i] = Listarry[i];    
               }
                Listarry = temArr;
            }
            
            Listarry[Index++] = elemet;
        }
        public int RemoveAT(int index)
        {

            if (index>Index)
            {
                throw new IndexOutOfRangeException();
            }
            int element = Listarry[index];
            Listarry[index] = 0;
            for (int i = index; i < Index; i++)
            {
                Listarry[i] = Listarry[i + 1];
            }
            Index--;
            if (Index<=Listarry.Length/4)
            {
                int[] temarr = new int[Listarry.Length / 2];
                for (int i = 0; i < Index; i++)
                {
                    temarr[i] = Listarry[i];
                }
                Listarry = temarr;
            }

            return element;
        }
        public bool Contains(int element)
        {
           
            for (int i = 0; i < Listarry.Length; i++)
            {
                if (Listarry[i]==element)
                {
                    return true;  
                }
            }
            return false;
        }
        
        public void Print()
        {

            foreach (var item in Listarry)
            {
                if (item!=0)
                {
                    Console.Write(item+" ");

                }
                
            }
            Console.WriteLine();


        }
        public void Swap(int first,int second)
        {
            if (first<0 ||first>=Index ||second<0 ||second>=Index)
            {
                throw new IndexOutOfRangeException();
            }
            int temp = Listarry[first];
            Listarry[first] = Listarry[second];
            Listarry[second] = temp;    
           

           
        }

    }
}
    