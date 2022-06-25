using System;

namespace BookShop
{
    class Program
    {
        static void Main(string[] args)
        {
            IBook shop = new Shop();
            int input = 9;
            while (input != 0)
            {
                Console.WriteLine("1. Add book");
                Console.WriteLine("2. Show information of all books");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.Write("Enter ID:     ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Enter title:  ");
                        string title = Console.ReadLine();
                        Console.Write("Enter author: ");
                        string author = Console.ReadLine();
                        Console.Write("Enter price:  ");
                        decimal price = decimal.Parse(Console.ReadLine());
                        shop.AddBook(id, title, author, price);
                        break;
                    case 2:
                        Console.WriteLine(shop.ShowAllBooksInfo());
                        break;
                    case 0:
                        return;
                    default:
                        break;
                }
            }
        }
    }
}

