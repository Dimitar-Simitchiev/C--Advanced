using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniExercises
{
    public class MyList_Methods
    {
        private MyList first=null;
        private MyList last=null;
        public int Count
        {
            get
            {
                var count = 0;
                var current = first;
                while (current!=null)
                {
                    count++;
                    current = current.Next;

                }
                return count;
            }
        }
        
                
        public void Addfirst(int element)
        {
            var newitem = new MyList(element);

            if (first==null)
            {
                first = newitem;
                last = newitem;
            }
            else
            {
                newitem.Next= first;
                first.Previous = newitem;
                first=newitem;  
               
            }
            
        }
        public void Addlast(int element)
        {
            var lastitem = new MyList(element);

            if (last == null)
            {
                first = lastitem;
                last = lastitem;
            }
            else
            {
                last.Next = lastitem;
                lastitem.Previous = last;
                last = lastitem;

            }
          
        }
        public int Removefirst()
        {
            if (first == null)
            {
                throw new InvalidOperationException("MyList is empty");
            }   
            var currentvalue = first.Value;
            if (first==last)
            {
                first = null;
                last = null;
            }

            
            else
            {
                var nefirst = first.Next;
                nefirst.Previous = null;
                first = nefirst;
            }
         
            return currentvalue;
        }
        public int Removelast()
        {
            if (last == null)
            {
                throw new InvalidOperationException("MyList is empty");
            }
            var currentvalue = first.Value;
            if (first == last)
            { 
                first = null;
                last = null;

            }
            else
            {
                var newlast = last.Previous;
                newlast.Next = null;
                last = newlast;
            } 
           
            return currentvalue;
           
        }
        public int[] ToMyArry()
        {
            var myarry = new int[Count];
            var currnet = first;
            var index = 0;
            while (currnet!=null)
            {
                myarry[index]=currnet.Value;
                index++;
                currnet = currnet.Next;
            }
            return myarry; 
        }


    }
}
