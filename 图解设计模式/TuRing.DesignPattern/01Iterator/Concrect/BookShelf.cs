#region

using System.Collections.Generic;
using _01Iterator.Abstract;

#endregion

namespace _01Iterator.Concrect
{
    internal class BookShelf
    {
        private readonly IList<Book> _books = new List<Book>();

        public int Count => _books.Count;

        public Book GetBookAt(int index)
        {
            if (index < _books.Count)
                return _books[index];

            return null;
        }

        public void AppendBook(Book book)
        {
            _books.Add(book);
        }

        public IIterator GetIterator()
        {
            return new BookShelfIterator(this);
        }
    }
}