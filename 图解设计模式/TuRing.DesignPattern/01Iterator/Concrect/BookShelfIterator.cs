#region

using System;
using _01Iterator.Abstract;

#endregion

namespace _01Iterator.Concrect
{
    internal class BookShelfIterator : IIterator
    {
        private readonly BookShelf _bookShelf;
        private int _index;

        public BookShelfIterator(BookShelf bookShelf)
        {
            _bookShelf = bookShelf;
            _index = 0;
        }

        public bool HasNext()
        {
            return _index  < _bookShelf.Count;
        }

        public object Next()
        {
            var obj = _bookShelf.GetBookAt(_index);

            if (!HasNext()) throw new IndexOutOfRangeException();

            _index++;
            return obj;
        }
    }
}