using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignUpSignIn.NewFolder1
{
    internal class Admin
    {   
        public string employess;
        public int emplID;
        public string emplUsername;
        public string Airline ;
        public int AirlineID;
        public int Price;
        public int Business;
        public int legspace;
        public int food;
        public string discount;
        public float disountPercentage;

        public Admin AddEmployee(Admin s)

        {

            Console.WriteLine("Enter the name of employee: ");
            s.employess = Console.ReadLine();
            Console.WriteLine("Enter the ID of employees: ");
            s.emplID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the username of employee: ");
           s. emplUsername = Console.ReadLine();
            return s;
        }
        public Admin AddAirline(Admin s)
        {
            Console.Write("Enter the Airline: ");
            s.Airline = Console.ReadLine();
            Console.Write("Enter the ID: ");
            s.AirlineID = int.Parse(Console.ReadLine());
          return s;
        }
        public Admin addPrice(Admin s)
        {
            Console.Write("Enter the price of ticket: ");
            s.Price = int.Parse(Console.ReadLine());
            return s;
        }
        public Admin addExtraCharges(Admin s)
        {
            Console.Write("Enter the charges of leg space: ");
            s.legspace = int.Parse(Console.ReadLine());
            Console.Write("Enter the charges of food: ");
            s.food = int.Parse(Console.ReadLine());
            Console.Write("Enter the charges for business class: ");
            s.Business = int.Parse(Console.ReadLine());
            return s;
        }
        public Admin discountData(Admin s)
        {
            Console.Write("Enter on how many days you want to give discount:  ");
            int days = int.Parse(Console.ReadLine());
            for (int i = 0; i < days; i++)
            {
                Console.Write("Enter the day on which you want to give discount: ");
                s.discount = Console.ReadLine();
            }
            return s;
        }
        public Admin addPercentage(Admin s)
        {
            Console.Write("Enter the percentage of discount: ");
            s.disountPercentage = int.Parse(Console.ReadLine());
            return s;
        }
    }

}
