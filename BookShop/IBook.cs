using System;
namespace BookShop
{
    public interface IBook
    {
        void AddBook();
        string ShowAllBooksInfo();
        Book ShowBookById(int id);
        bool RemoveBookById(int id);
        bool UpdateBookById(int id, string title, string author, decimal price);
    }
}

