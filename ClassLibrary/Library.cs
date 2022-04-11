using System;
using System.Collections.Generic;
using System.Text;
using static ClassLibrary.Book;

namespace ClassLibrary
{
    public class Library
    {
        public List<Book> books = new List<Book>();
        public List<Book> FilterByPrice(int minPrice,int maxPrice)
        {
            List<Book> newbooks = new List<Book>();
            foreach (var item in books)
            {
                if(item.Price>minPrice && item.Price<maxPrice)
                    newbooks.Add(item);
            }
            return newbooks;
        }
        public List<Book> FilterByGenre(string genre)
        {
            List<Book> newbooks = new List<Book>();
            foreach (var item in books)
            {
                if (Enum.IsDefined(typeof(Genre), genre))
                    newbooks.Add(item);
            }
            return newbooks;
        }
        public Book Find(Predicate<Book> predicate)
        {
            foreach (var item in books)
            {
                if(predicate(item))
                    return item;
            }
            return null;
        }
        public bool Exists(Predicate<Book> predicate)
        {
            foreach (var item in books)
            {
                if(predicate(item))
                    return true;
            }
            return false;
        }
        public void RemoveAll(Predicate<Book> predicate)
        {
            List<Book> newbooks = new List<Book>();
            foreach (var item in books)
            {
                if(!predicate(item))
                    newbooks.Add(item);
            }
            books = newbooks;
        }
    }
}
