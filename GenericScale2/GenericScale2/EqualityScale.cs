using System;
using System.Collections.Generic;
using System.Text;

namespace GenericScale2
{
    internal class EqualityScale<T>
        where T : class
    {
        public T left;
        public T right; 
        public EqualityScale(T left, T right)
        {
            this.right = right;
            this.left = left;    
        }
        public bool AreEqual()
        {
            return left.Equals(right);  
        }
    }
}
