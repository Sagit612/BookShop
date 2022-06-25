using System;
using System.Linq;

namespace BookShop
{
    public class Book
    {
        private int id;
        private string title;
        private string author;
        private decimal price;

        public Book(int id, string title, string author, decimal price)
        {
            this.Id = id;
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public int Id { get => id; set => id = value; }
        public string Title
        {
            get => title;
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
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

        public override string ToString()
        {
            return $"{Id}, {Title}, {Author}, {Price}";
        }
    }
}

