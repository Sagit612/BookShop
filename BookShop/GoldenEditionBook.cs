using System;
namespace BookShop
{
    public class GoldenEditionBook : Book
    {
        public GoldenEditionBook(int id, string title, string author, decimal price, int quantity)
            : base(id, title, author, price, quantity)
        {
        }

        public override decimal Price { get => base.Price * 1.3M; set => base.Price = value; }
    }
}

