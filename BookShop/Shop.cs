using System;
using System.Collections.Generic;

namespace BookShop
{
    public class Shop : IBook
    {
        private List<Book> _books;

        public Shop()
        {
            _books = new List<Book>();
        }

        public void AddBook(int id, string title, string author, decimal price)
        {
            Book book = new Book(id, title, author, price);
            _books.Add(book);
        }

        public bool RemoveBookById(int id)
        {
            throw new NotImplementedException();
        }

        public string ShowAllBooksInfo()
        {
            string result = "";
            foreach (var b in _books)
            {
                result = result + b.ToString();
            }
            return result;
        }

        public Book ShowBookById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateBookById(int id, string title, string author, decimal price)
        {
            throw new NotImplementedException();
        }
    }
}

