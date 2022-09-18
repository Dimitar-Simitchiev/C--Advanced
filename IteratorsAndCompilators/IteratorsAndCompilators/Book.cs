using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndCompilators
{
    public class Book 
    {
        public Book(string title, int year, List<string>authors)
        {

            Year = year;
            Title = title;
            Authors = authors;
        }
        public Book()
        {

        }
        public string Title { get; set; }
        public int Year { get; set; }
        public List<string>Authors { get; set; }

      
    }
}
