using System;
namespace BookShop
{
    public interface IBook
    {
        void AddBook(int id, string title, string author, decimal price);
        string ShowAllBooksInfo();
        Book ShowBookById(int id);
        bool RemoveBookById(int id);
        bool UpdateBookById(int id, string title, string author, decimal price);
    }
}

