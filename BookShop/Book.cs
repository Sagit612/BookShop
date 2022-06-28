using System;
using System.Collections.Generic;
using System.Linq;

namespace BookShop
{
    public class Book : IInformation
    {
        private int id;
        private string title;
        private string author;
        private decimal price;
        private int quantity;

        public Book(int id, string title, string author, decimal price, int quantity)
        {
            this.Id = id;
            this.Title = title;
            this.Author = author;
            this.Price = price;
            this.Quantity = quantity;
        }
        public int Id { get => id; set => id = value; }

        public string Title
        {
            get => title;
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title must have more than 3 character!!! " +
                        "Please enter title again");
                }
                title = value;
            }
        }
        public string Author
        {
            get => author;
            set
            {
                bool containsInt = value.Any(char.IsDigit);
                if (containsInt)
                {
                    throw new ArgumentException("Author not valid!");
                }
                author = value;
            }
        }
        public virtual decimal Price
        {
            get => price;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                price = value;
            }
        }

        public int Quantity { get => quantity; set => quantity = value; }

        public string PrintInformation()
        {
            return $"{GetType()} \t| ID: {Id} | Title: {Title} | Author: {Author} | Price: {Price}\n";
        }
    }
}

