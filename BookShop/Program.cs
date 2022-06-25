using System;

namespace BookShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter ID:     ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter title:  ");
            string title = Console.ReadLine();
            Console.Write("Enter author: ");
            string author = Console.ReadLine();
            Console.Write("Enter price:  ");
            decimal price = decimal.Parse(Console.ReadLine());
            IBook shop = new Shop();
            shop.AddBook(id, title, author, price);
            Console.WriteLine(shop.ShowAllBooksInfo());
        }
    }
}

