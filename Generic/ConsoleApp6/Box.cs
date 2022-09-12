using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public class Box<T>
    {
        private List<T> BoxList = new List<T>();

        public void Add(T element)
        {

            BoxList.Add(element);
        }
        public T Peek()
        {
            var item = BoxList[BoxList.Count - 1];
            return item;
        }


       public T Remove()
        {
            var item = BoxList[BoxList.Count - 1];
            BoxList.Remove(BoxList[BoxList.Count - 1]);
            return item;
        }

        public int Count
        {
            get
            {

                return BoxList.Count;

            }
        }
    }
}
