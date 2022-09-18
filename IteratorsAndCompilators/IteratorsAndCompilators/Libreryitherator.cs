using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndCompilators
{
    public class Libreryitherator : IEnumerator<Book>
    {
        private List<Book> books;
        private int index;
        public Libreryitherator(List<Book>books)
        {
            this.books = books; 
            index = -1;
        }
        private bool disposedValue;




        object IEnumerator.Current => Current;
        public Book Current => books[index];

        public bool MoveNext()
        {
            index++;
            if (index<books.Count)
            {
                return true;
            }
            else
            {
                return false;   

            }
        }
            

        void IEnumerator.Reset()
        {
            index = -1; 
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                }
                disposedValue = true;
            }
        }

        

        void IDisposable.Dispose()
        {
            
        }
    }
}
