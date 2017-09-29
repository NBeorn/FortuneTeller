using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Queen Baba's Fortunes. Please enter your first name.");
            string firstName = Console.ReadLine().Trim();

            if(firstName.ToLower() == "goku")
            {
                Console.WriteLine("Glad someone got the reference.");
            }

            Console.WriteLine("Please enter your last name.");
            string lastName = Console.ReadLine().Trim();

            if (firstName.ToLower() + lastName.ToLower() == "danielvivacqua")
            {
                Console.WriteLine("Grade like Jarryd please. :)");
            }
            else if (firstName.ToLower() + lastName.ToLower() == "jarrydhuntley")
            {
                Console.WriteLine("Grade kindly :)");
            }

            Console.WriteLine("Please enter your age. And don't ask for mine!");
            int age = int.Parse(Console.ReadLine().Trim());

            Console.WriteLine("Please enter your birth month as a number. (January = 1, February = 2, etc.)");
            int birthMonth = int.Parse(Console.ReadLine().Trim());

            Console.WriteLine("Please enter your favorite ROYGBIV color. Enter 'Help' for a list of options");
            Console.ReadLine();
        }
    }
}
