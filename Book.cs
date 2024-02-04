using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    internal class Book
    {
        public string title;
        public string author;
        public string publicationYear;
        public float price;
        public int quantityInStock;
        public Book(string title, string author, string publicationYear, float price, int quantityInStock)
        {
            this.title = title;
            this.author = author;
            this.publicationYear = publicationYear;
            this.price = price;
            this.quantityInStock = quantityInStock;
        }
        public string getTitle()
        {
            return title;
        }
        public string getAuthor()
        {
            return author;
        }
        public string getPublicationYear()
        {
            return publicationYear;
        }
        public float Price()
        {
            return price;
        }
        public void sellCopies(int numberOfCopies)
        {
            if(numberOfCopies>quantityInStock)
            {
                Console.WriteLine("Not enough copies");
            }
            else
            {
                quantityInStock = quantityInStock - numberOfCopies;
            }
          
        }
        public void restock(int addoitionalCopies)
        {
            quantityInStock=quantityInStock + addoitionalCopies;
        }
        public string bookDetails()
        {
            return title+" by "+author+"published in "+publicationYear+"priced at "+price+"and available copies "+quantityInStock;
        }
    }
}
