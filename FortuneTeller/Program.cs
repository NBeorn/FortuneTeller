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
            Console.WriteLine("Welcome to Fortuneteller Baba's. Please enter your first name.");
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

            if (age % 2 == 0)
            {
                age = 20;
            }
            else
            {
                age = 15;
            }

            Console.WriteLine("Please enter your birth month as a number. (January = 1, February = 2, etc.)");
            int birthMonth = int.Parse(Console.ReadLine().Trim());

            Console.WriteLine("Please enter your favorite ROYGBIV color. Enter 'Help' for a list of options");
            string help = ("Red\tOrange\tYellow\tGreen\tBlue\tIndigo\tViolet");
            string favoriteColor = Console.ReadLine();

            if (favoriteColor.ToLower() == "help")
            {
                Console.WriteLine(help);
                Console.WriteLine("Now please enter your choice.");
                favoriteColor = Console.ReadLine();
            }

            Console.WriteLine("How many siblings do you have?");
            int numberSiblings = int.Parse(Console.ReadLine());
            numberSiblings.ToString();

            if (numberSiblings == 0)
            {
                numberSiblings = "Miami";
            }

            Console.WriteLine("This is your fortune: \n\n");
            Console.WriteLine(firstName + " " + lastName + " will retire in only " + age + " years with " + );
        }
    }
}
