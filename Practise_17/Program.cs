using System;
using System.Collections.Generic;
using  ClassLibrary;


namespace Practise_17
{
    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Nece kitab isteyirsiniz?");
            int count = int.Parse(Console.ReadLine());

            Library library = new Library();
            for (int i = 0; i < count; i++)
            {
                
                Console.WriteLine("Kitabin adi:");
                string name = Console.ReadLine();
                Console.WriteLine("Kitabin Author adi:");
                string authorname = Console.ReadLine();
                Console.WriteLine("Kitabin Genre-sin seciniz:");
                //Genre genre = new Genre();
                int j = 0;
                foreach (var item in Enum.GetValues(typeof(Genre)))
                {
                    Console.WriteLine(item+"-"+(++j));
                }
                byte genreValue = byte.Parse(Console.ReadLine());
                Genre selectedGenre = (Genre)genreValue;
                Console.WriteLine("Kitabin Price-i:");
                double price = double.Parse(Console.ReadLine());
                Book book = new Book();
                book.Name = name;
                book.AuthorName = authorname;
                book.Genre1 = selectedGenre;
                book.Price = price;
                library.books.Add(book);
            }

            Predicate<Book> predicate = x => x.Genre1 == Genre.fantastika;

            library.RemoveAll(predicate);
            foreach (var item in library.books)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("Exists elemek istediyiniz kitabin nomresi:");
            int no = int.Parse(Console.ReadLine());
            Predicate<Book> predicate1 = x => x.No == no;
            Console.WriteLine(library.Exists(predicate1));

            Console.WriteLine("Find elemek istediyiniz kitabin nomresi:");
            int findNo = int .Parse(Console.ReadLine());
            Predicate<Book> predicate2 = x => x.No == findNo;
            Book book1 = library.Find(predicate1);
            Console.WriteLine($"No:{book1.No}-Name:{book1.Name}-AuthorName:{book1.AuthorName}" +
                $"-Genre{book1.Genre1}-Price:{book1.Price}");






        }
    }
}
