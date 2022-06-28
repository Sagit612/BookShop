using System;

namespace BookShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            int input = Option.INIT;
            string inputBook = Option.INPUT_BOOK;

            shop.AddBook(new Book(1, "The Astronomy Book", "Dorling Kindersley", 24, 2000));
            shop.AddBook(new Book(2, "The Astronomy Book", "Adams Media", 15, 1000));
            shop.AddBook(new Book(3, "Cloud Computing", "Guo", 56, 900));
            shop.AddBook(new Book(4, "Rich Dad Poor Dad", "Robert T. Kiyosaki", 10, 2000));
            shop.AddBook(new Book(5, "The Power of Habit", "Charles Duhigg", 13, 2005));
            shop.AddBook(new GoldenEditionBook(50, "Self Discipline", "Dorling Kindersley", 24, 99));
            shop.AddBook(new GoldenEditionBook(51, "The power of NOW", "Eckhart Tolle", 40, 100));
            shop.AddBook(new GoldenEditionBook(52, "mindset", "Carol S.Dweck", 60, 30));
            shop.AddBook(new GoldenEditionBook(53, "Atomic Habits", "James Clear", 50, 20));
            while (input != Option.EXIT)
            {
                input = IO.EnterMenuOptions();
                switch (input)
                {
                    case Option.ADD_BOOK:
                        do
                        {
                            inputBook = IO.EnterBook();
                            switch (inputBook)
                            {
                                case Option.ADD_NORMAL_BOOK:
                                    try
                                    {
                                        shop.AddBook(new Book(
                                        IO.EnterId(),
                                        IO.EnterTitle(),
                                        IO.EnterAuthor(),
                                        IO.EnterPrice(),
                                        IO.EnterQuantity()));
                                    }catch(ArgumentException ae)
                                    {
                                        IO.ToScreen(ae.Message);
                                    }
                                    break;
                                case Option.ADD_GOLD_EDITION_BOOK:
                                    try
                                    {
                                        shop.AddBook(new GoldenEditionBook(
                                        IO.EnterId(),
                                        IO.EnterTitle(),
                                        IO.EnterAuthor(),
                                        IO.EnterPrice(),
                                        IO.EnterQuantity()));
                                    }catch (ArgumentException ae)
                                    {
                                        IO.ToScreen(ae.Message);
                                    }
                            break;
                                default:
                                    break;
                            }
                        } while (inputBook != Option.EXIT_ENTER_BOOK);
                        break;
                    case Option.SHOW_ALL_BOOKS:
                        IO.ToScreen(shop.PrintInformation());
                        break;
                    case Option.SHOW_BY_ID:
                        IO.ToScreen(shop.FindBookById(IO.EnterId()));
                        break;
                    case Option.SHOW_BY_NAME:
                        IO.ToScreen(shop.FindBooksByName(IO.EnterTitle()));
                        break;
                    case Option.REMOVE_BOOK:
                        IO.ToScreen(IO.ShowMessage(shop.RemoveBookById(IO.EnterId())));
                        break;
                    case Option.UPDATE_BOOK:
                        IO.ToScreen(IO.ShowMessage(shop.UpdateBookById(
                            IO.EnterId(),
                            IO.EnterTitle(),
                            IO.EnterAuthor(),
                            IO.EnterPrice(),
                            IO.EnterQuantity()
                            )));
                        break;
                    case Option.EXIT:
                        return;
                    default:
                        break;
                }
            }
        }
    }
}

