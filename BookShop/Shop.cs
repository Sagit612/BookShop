using System;
using System.Collections.Generic;
using System.Linq;

namespace BookShop
{
    public class Shop : IShop, IInformation
    {
        private List<Book> books = new List<Book>();

        public Shop()
        {
        }

        public void AddBook(Book book)
        {
            try
            {
                if (CheckId(book.Id))
                {
                    throw new ArgumentException("ID is duplicated!! please enter another ID");
                }
                else
                {
                    books.Add(book);
                }
                
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }   
        }

        public bool CheckId(int id)
        {
            Book bookInList = books.FirstOrDefault(i => i.Id.Equals(id));
            if (bookInList != null) return true;
            return false;
        }

        public bool RemoveBookById(int id)
        {
            Book bookInList = books.FirstOrDefault(i => i.Id.Equals(id));
            if (bookInList != null)
            {
                books.Remove(bookInList);
                return true;
            };
            return false;
        }

        public string PrintInformation()
        {
            string result = "";
            foreach (var b in books)
            {
                result = result + b.PrintInformation();
            }
            return result;
        }

        public string ShowBookById(int id)
        {
            Book bookInList = books.FirstOrDefault(i => i.Id.Equals(id));
            if (bookInList != null) return bookInList.ToString();
            return "There is no book with that id";
        }
        public string ShowBooksByName(string title)
        {
            string result = "";
            foreach (var b in books.Where(n => n.Title.Equals(title)))
            {
                result = result + b.ToString();
            }
            return result;
        }

        public bool UpdateBookById(int id, string title, string author, decimal price, int quantity)
        {
            try
            {
                Book bookInList = books.FirstOrDefault(i => i.Id.Equals(id));
                if (bookInList != null)
                {
                    bookInList.Title = title;
                    bookInList.Author = author;
                    bookInList.Price = price;
                    return true;
                }
            }
            catch(ArgumentException ae)
            {
                IO.ToScreen(ae.Message);
            }
            return false;
        }
    }
}

