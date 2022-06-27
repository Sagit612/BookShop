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
                                    shop.AddBook(new Book(
                                        IO.EnterId(),
                                        IO.EnterTitle(),
                                        IO.EnterAuthor(),
                                        IO.EnterPrice(),
                                        IO.EnterQuantity()));
                                    break;
                                case Option.ADD_GOLD_EDITION_BOOK:
                                    shop.AddBook(new GoldenEditionBook(
                                        IO.EnterId(),
                                        IO.EnterTitle(),
                                        IO.EnterAuthor(),
                                        IO.EnterPrice(),
                                        IO.EnterQuantity()));
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
                        IO.ToScreen(shop.ShowBookById(IO.EnterId()));
                        break;
                    case Option.SHOW_BY_NAME:
                        IO.ToScreen(shop.ShowBooksByName(IO.EnterTitle()));
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

