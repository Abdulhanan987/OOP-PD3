using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShritoriG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
                  Shritori shritori = new Shritori();
            while(true)
            {
                Console.Clear();
                menu();
                option=int.Parse(Console.ReadLine());
                if(option == 1) 
                {Console.Clear();
                    while(true) 
                    {
                        
                        string var = Console.ReadLine();
                        shritori.Play(var);
                       
                        if(shritori.game_over==true)
                        {
                            break;
                        }
                        else
                        {
                            for (int i = 0; i < shritori.count; i++)
                            {
                                Console.WriteLine(shritori.words[i]);
                            }
                        }
                        
                    }
                    
                }
                else if (option == 2)
                {
                    shritori.restrat();
                }
                else if (option==3) { break; }
            }
        }
        static void menu()
        {
            Console.WriteLine("Shritori Game: ");
            Console.WriteLine("1.Play game:");
            Console.WriteLine("2.Restart Game: ");
            Console.WriteLine("3.Exit:");
            Console.WriteLine("Enter your desired option");
        }
    }
}
