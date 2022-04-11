using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Book
    { 
        private static int _noCount=0;
        public Book()
        {
            _noCount++;
            No = _noCount;
              
        }
        public int No { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public Genre Genre1 { get; set; }
        public double Price { get; set; }

    }
}
