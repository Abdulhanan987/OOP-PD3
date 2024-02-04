using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignUpSignIn.NewFolder1;
using System.IO;
namespace SignUpSignIn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            int x = 0;
            MUser[] User = new MUser[100]; 
            List <Admin> functionalities = new List <Admin>();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Business Application: ");
                Console.WriteLine("1. Sign Up: ....");
                Console.WriteLine("2. Sign In: ....");
                Console.WriteLine("3. Exit: ......");
                option=int.Parse(Console.ReadLine());
                if(option == 1)
                {
                    Console.Clear();
                   User[x]= user();
                    x++;
                    Console.WriteLine("Press any key to continue: .....");
                    Console.ReadKey();
                }
                else if(option == 2)
                {
                    Console.Clear();
                    int needed=-1;
                   if (SignIn(User, ref x, ref needed)==true)
                    {
                        Console.WriteLine("You have succesfully signed in as " + User[needed].Role);
                    }
                    if (User[needed].Role=="admin" )
                    {
                        Admin admin = new Admin();
                        while (true)
                        {    Console.Clear();
                            printAdminMenu();

                            int option1 = int.Parse(Console.ReadLine());
                            int count = 0;
                            if (option1 == 1)
                            {
                                Console.Clear();
                                Admin admin1 = new Admin();
                                functionalities.Add(admin.AddEmployee(admin1));
                                Console.WriteLine("Press any key to continue: .....");
                                Console.ReadKey();
                            }
                            else if (option1 == 2)
                            {
                                Console.Clear();
                                Console.Write("Enter the username of employee whom you want to remove: ");
                                string name = Console.ReadLine();
                                for (int i = 0; i < functionalities.Count; i++)
                                {
                                    if (functionalities[i].emplUsername == name)
                                    {
                                        functionalities.RemoveAt(i);
                                        break;
                                    }
                                   
                                }
                                Console.WriteLine("Press any key to continue: .....");
                                Console.ReadKey();

                            }
                            else if (option1 == 3)
                            {
                                Console.Clear();
                                functionalities.Add(admin.AddAirline(admin));
                                Console.WriteLine("Press any key to continue: .....");
                                Console.ReadKey();
                            }
                            else if (option1 == 4)
                            {
                                Console.Clear();
                                for (int i = 0; i < functionalities.Count; i++)
                                {
                                    Console.WriteLine(functionalities[i].emplUsername + "\t" + functionalities[i].emplID + "\t" + functionalities[i].employess);
                                }
                                Console.WriteLine("Press any key to continue: .....");
                                Console.ReadKey();
                            }
                            else if (option1 == 5)
                            {
                                Console.Clear();
                                functionalities.Add(admin.addPrice(admin));
                                Console.WriteLine("Press any key to continue: .....");
                                Console.ReadKey();
                            }
                            else if (option1 == 6)
                            {
                                Console.Clear();
                                functionalities.Add(admin.addExtraCharges(admin));
                                Console.WriteLine("Press any key to continue: .....");
                                Console.ReadKey();

                            }
                            else if (option1 == 7)
                            {
                                Console.Clear();
                                functionalities.Add(admin.discountData(admin));
                                Console.WriteLine("Press any key to continue: .....");
                                Console.ReadKey();
                            }
                            else if (option1 == 8)
                            {
                                Console.Clear();
                                functionalities.Add(admin.addPercentage(admin));
                                Console.WriteLine("Press any key to continue: .....");
                                Console.ReadKey();
                            }
                            else if (option1 == 9)
                            {
                                break;
                            }
                        }
                       

                    }
                   
                   
                }
                else if (option == 3)
                {
                    break;
                }
            }
        }
        static MUser user()
        {
            Console.Write("Enter the username: ");
            string username = Console.ReadLine();
            Console.Write("Enter the password: ");
            string password = Console.ReadLine();
            Console.Write("Enter the role: ");
            string role = Console.ReadLine();
            MUser mUser=new MUser(username, password, role);
            AddData(mUser);
            return mUser;
        }
        static void AddData(MUser mUser)
        {
            string path = "E:\\Semester 2\\Lab 2\\SignUpSignIn\\User.txt";
            if(File.Exists(path))
            {
                StreamWriter file = new StreamWriter(path,true);
                file.WriteLine(mUser.Username + ","+mUser.Password+","+mUser.Role+",");
                file.Flush();
                file.Close();

            }
        }
        static bool SignIn(MUser []mUser,ref int count,ref int needed)    
        {
            string path = "E:\\Semester 2\\Lab 2\\SignUpSignIn\\User.txt";
            int x = 0;
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string var;
               
                while((var = file.ReadLine())!=null)
                    {
                    MUser user= new MUser();
                    mUser[x]= user;
                    mUser[x].Username = getField(var, 1);
                    mUser[x].Password= getField(var, 2);
                    mUser[x].Role= getField(var, 3);
                    x++;
                    }
                file.Close();
            }
            
            count = x;
            
            Console.Write("Enter the username: ");
            string username = Console.ReadLine();
            Console.Write("Enter the password: ");
            string password = Console.ReadLine();
            for(int i = 0; i < x; i++)
            {
                if (username == mUser[i].Username && password == mUser[i].Password)     
                {
                    
                    needed= i;
                    return true;
                   
                }
            }
            return false;
        }
        static string getField(string record, int field)
        {
            int commaCount = 1;
            string result="";
            for (int x = 0; x < record.Count(); x++)
            {
                if (record[x] == ',')
                {
                    commaCount = commaCount + 1;
                }
                else if (commaCount == field)
                {
                    result = result + record[x];
                }
            }
            return result;
        }
        static void printAdminMenu()
        {
            Console.WriteLine("\t\tAdmin menu");
            Console.WriteLine("1.Add Employees");
            Console.WriteLine("2.Remove Employees");
            Console.WriteLine("3.Add Airlines: ");
            Console.WriteLine("4.Employees List: ");
            Console.WriteLine("5.Add the price of ticket: ");
            Console.WriteLine("6.Add the price of extra charges: ");
            Console.WriteLine("7.Enter on how many days you want to give Discount: ");
            Console.WriteLine("8.Enter the percentage of discount: ");
            Console.WriteLine("9.Log out:  ");
        }
    
    }
}
