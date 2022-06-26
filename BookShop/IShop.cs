using System;
namespace BookShop
{
    public interface IShop
    {
        void AddBook(Book book);
        string ShowAllBooksInfo();
        string ShowBookById(int id);
        string ShowBooksByName(string title);
        bool RemoveBookById(int id);
        bool UpdateBookById(int id, string title, string author, decimal price, int quantity);
        bool CheckId(int id);
    }
}

