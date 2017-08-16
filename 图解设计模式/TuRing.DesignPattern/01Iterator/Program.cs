#region

using System;
using _01Iterator.Concrect;

#endregion

namespace _01Iterator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var bookShelf = new BookShelf();
            bookShelf.AppendBook(new Book {Name = "A"});
            bookShelf.AppendBook(new Book {Name = "B"});
            bookShelf.AppendBook(new Book {Name = "C"});
            bookShelf.AppendBook(new Book {Name = "D"});

            var iterator = bookShelf.GetIterator();

            while (iterator.HasNext())
            {
                var book = (Book) iterator.Next();
                Console.WriteLine(book.Name);
            }

            Console.Read();
        }
    }
}