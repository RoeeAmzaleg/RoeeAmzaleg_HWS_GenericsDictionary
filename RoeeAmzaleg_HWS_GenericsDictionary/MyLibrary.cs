using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoeeAmzaleg_HWS_GenericsDictionary
{
    public class MyLibrary
    {
        private Dictionary<string, Book> books;
        public int Count { get { return books.Count; } }

        public MyLibrary()
        {
            books = new Dictionary<string, Book>();
        }
        public bool HaveThisBook(string title)
        {
            if (!books.ContainsKey(title))
            {
                return false;
            }
            return true;
        }
        public bool AddBook(Book book)
        {
            if (book == null || !HaveThisBook(book.Title))
            {
                return false;
            }
            else
            {
                Console.WriteLine($"added book - {book.Title}, written by - {book.Author}");
                books.Add(book.Title, book);
            }
            return true;
        }

        public bool RemoveBook(string book)
        {
            if (book != null || !HaveThisBook(null))
            {
                books.Remove(book);
            }
            return true;
        }
        public Book GetBook(string title)
        {
            if (!HaveThisBook(title))
            {
                return null;
            }
            return books[title];
        }
        public List<string> GetBookByAuthor()
        {
            List<string> authors = new List<string>();
            foreach (Book book in books.Values)
            {
                authors.Add(book.Author);
            }
            return authors;

        }
        public void Clear()
        {
            books.Clear();
        }
        public List<string> GetAuthors()
        {
            List<string> authors = new List<string>();
            foreach (Book book in books.Values)
            {
                authors.Add(book.Author);
            }
            return authors;
        }
        public int BooksCount()
        {
            return books.Count;
        }
        public override string ToString()
        {
            string res = "";
            foreach (KeyValuePair<string, Book> keyValuePair in books)
            {
                res += keyValuePair.Key + " : " + keyValuePair.Value + "\n";
            }
            return res;
        }

    }
}
