using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            List<Book> bookList = new List<Book>();

            while(true) 
            {
                Console.Clear();
                menu();
                option=int.Parse(Console.ReadLine());
                if(option == 1)
                {
                    Console.Clear();
                    bookList.Add(addBook());
                    Console.WriteLine("Press any key to continue: ");
                    Console.ReadKey();
                }
                else if(option == 2) 
                {
                    Console.Clear();
                    for(int i=0; i<bookList.Count; i++)
                    {
                        Console.WriteLine(bookList[i].bookDetails());
                    }
                    Console.WriteLine("Press any key to continue: ");
                    Console.ReadKey();
                }
                else if (option == 3) 
                {
                    Console.Clear();
                    Console.Write("Enter the title of book whose author details you want to see: ");
                    string var = Console.ReadLine();
                    for(int i=0;i<bookList.Count;i++)
                    {
                        if (var == bookList[i].title)
                        Console.WriteLine(bookList[i].getAuthor());
                    }
                    Console.WriteLine("Press any key to continue: ");
                    Console.ReadKey();

                }
                else if (option==4)
                {
                    Console.Clear();
                    Console.Write("Enter the title of book whose author details you want to see: ");
                    string var = Console.ReadLine();
                    for (int i = 0; i < bookList.Count; i++)
                    {
                        if (var == bookList[i].title)
                        {
                            Console.WriteLine("Enter the sell copies of book:");
                            int var1 = int.Parse(Console.ReadLine());
                            bookList[i].sellCopies(var1);
                        }
                            
                    }
                    Console.WriteLine("Press any key to continue: ");
                    Console.ReadKey();

                }
                else if (option==5)
                {
                    Console.Clear();
                    Console.Write("Enter the title of book whose author details you want to see: ");
                    string var = Console.ReadLine();
                    for (int i = 0; i < bookList.Count; i++)
                    {
                        if (var == bookList[i].title)
                        {
                            Console.WriteLine("Enter the restock copies of book:");
                            int var1 = int.Parse(Console.ReadLine());
                            bookList[i].restock(var1);
                        }

                    }
                    Console.WriteLine("Press any key to continue: ");
                    Console.ReadKey();
                }
                else if (option==6) 
                {
                    Console.Clear();
                    Console.WriteLine(bookList.Count);
                    Console.WriteLine("Press any key to continue: ");
                    Console.ReadKey();
                }
                else if (option==7) 
                {
                    break;
                }
            }
        }
        static void menu()
        {
            Console.WriteLine("Book Shop: ");
            Console.WriteLine("1.Add Book");
            Console.WriteLine("2.View Book Information: ");
            Console.WriteLine("3.Get Author details: ");
            Console.WriteLine("4.Get sell copies");
            Console.WriteLine("5.Restock of a book");
            Console.WriteLine("6.Count of all books");
            Console.WriteLine("7.Exit");
              Console.WriteLine(  " Enter your desired option: ");
        }
        static Book addBook()
        {
            Console.Write("Enter the title of book: ");
            string v1 = Console.ReadLine();
            Console.Write("Enter the author of book: ");
            string v2 = Console.ReadLine();
            Console.Write("Enter the publiction year of book: ");
            string v3 = Console.ReadLine();
            Console.Write("Enter the price of book: ");
            float v4 = float.Parse(Console.ReadLine());
            Console.Write("Enter the quantity of book: ");
            int v5 = int.Parse(Console.ReadLine());
            Book book = new Book(v1, v2, v3, v4, v5);
            return book;

        }
    }
}
