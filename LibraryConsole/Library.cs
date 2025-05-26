using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryConsole
{
    internal class Library
    {
        public ConcurrentDictionary<string, int> books;
        public Library()
        {
            books = new ConcurrentDictionary<string, int>();
        }

        public (bool, CancellationTokenSource) AddBook(string bookName)
        {
            if (books.ContainsKey(bookName) || String.IsNullOrEmpty(bookName))
            {
                return (false, null);
            }
            bool complite = books.TryAdd(bookName, 0);

            var cts = new CancellationTokenSource();
            var task = Task.Run(() => ReadingBook(bookName, cts), cts.Token);

            return (complite, cts);
        }
        private void ReadingBook(string bookName, CancellationTokenSource cts)
        {
            (string, int) increasingBook;
            for (int i = 0; i < 100; i++)
            {
                if (cts.IsCancellationRequested) return;
                bool complite = books.TryUpdate(bookName, i + 1, i);
                if (!complite)
                {
                    return;
                }
                Thread.Sleep(1000);//20 better for testing
            }

            //I don't know how to correctly remove item
            books.TryRemove(bookName, out int a);
        }
        public (string, int)[] GetAllBooks()
        {
            if (books.Count == 0)
            {
                return null;
            }
            (string name, int percent)[] returnBooks = new (string, int)[books.Count];

            int tempIterator = 0;
            foreach (var book in books)
            {
                returnBooks[tempIterator].name = book.Key;
                returnBooks[tempIterator].percent = book.Value;
                tempIterator++;
            }

            return returnBooks;
        }
    }
}
