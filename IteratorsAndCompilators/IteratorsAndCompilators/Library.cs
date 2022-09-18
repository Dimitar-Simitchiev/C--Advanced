using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndCompilators
{
     public  class Library:IEnumerable<Book>
    {
        public List<Book> books;
        public Library(params Book[]books)
        {
            this.books =new List<Book>(books);
        }

        public void AddBook(Book book)
        {
            this.books.Add(book);

        } 
        public void RemoveBook(Book book)
        {
            this.books.Remove(book);

        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new Libreryitherator(books);
        }

       

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
