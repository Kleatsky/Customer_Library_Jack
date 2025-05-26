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

        public bool AddBook(string bookName)
        {
            if (books.ContainsKey(bookName) || String.IsNullOrEmpty(bookName))
            {
                return false;
            }
            
            return books.TryAdd(bookName, 0);
        }
        public (string, int)[] GetAllBooks()
        {
            if(books.Count == 0)
            {
                return null;
            }
            (string name , int percent)[] returnBooks = new (string, int)[books.Count];

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
