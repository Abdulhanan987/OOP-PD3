using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedCalculator.BL;
namespace AdvancedCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            Calculator calculator1 = new Calculator();
            while (true)
            {
                Console.Clear();
                option = menu();
                if (option == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Enter the first value of object: ");
                    calculator1.value1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the second value of object: ");
                    calculator1.value2 = float.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Press any key to continue: ");
                    Console.ReadKey();
                }
                else if (option == 2)
                {
                    Console.Clear();

                    Console.WriteLine("Enter value1: ");
                    calculator1.value1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter value2: ");
                    calculator1.value2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Press any key to continue: ");
                    Console.ReadKey();
                }
                else if (option == 3)

                {
                    Console.Clear();

                    Console.WriteLine("The sum is " + calculator1.add());

                    Console.WriteLine("Press any key to continue: ");
                    Console.ReadKey();
                }
                else if (option == 4)
                {
                    Console.Clear();
                    Console.WriteLine("The subtract is " + calculator1.subtract());

                    Console.WriteLine("Press any key to continue: ");
                    Console.ReadKey();
                }
                else if (option == 5)
                {
                    Console.Clear();
                    Console.WriteLine("The multiply is " + calculator1.multiply());

                    Console.WriteLine("Press any key to continue: ");
                    Console.ReadKey();
                }
                else if (option == 6)
                {
                    Console.Clear();
                    if(calculator1.value2==0)
                    {
                        Console.WriteLine("Invalid value: ");
                    }
                    else
                    {
                        Console.WriteLine("The divide is " + calculator1.divide());
                    }
                   

                    Console.WriteLine("Press any key to continue: ");
                    Console.ReadKey();
                }
                else if (option == 7)
                {
                    Console.Clear();
                    Console.WriteLine("The mod is " + calculator1.mod());
                    Console.WriteLine("Press any key to continue: ");
                    Console.ReadKey();
                }
                else if (option == 8)
                    break;
            }
        }
        static int menu()
        {
            Console.WriteLine("Calculator");
            Console.WriteLine("1.Create a single object of Calculator: ");
            Console.WriteLine("2.Change the values of attribute: ");
            Console.WriteLine("3.Add: ");
            Console.WriteLine("4.Subtract: ");
            Console.WriteLine("5.Multiply: ");
            Console.WriteLine("6.Divide: ");
            Console.WriteLine("7.Modulo: ");
            Console.WriteLine("8.Exit");
            int option=int.Parse(Console.ReadLine());
            return option;
        }
    }
}
