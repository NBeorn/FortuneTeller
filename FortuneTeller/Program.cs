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

            //Dragonball easter egg - Fortuneteller Baba is a Dragonball character
            if(firstName.ToLower() == "goku")
            {
                Console.WriteLine("Glad someone got the reference.");
            }

            Console.WriteLine("Please enter your last name.");
            string lastName = Console.ReadLine().Trim();

            //Instructor special
            if (firstName.ToLower() + lastName.ToLower() == "danielvivacqua")
            {
                Console.WriteLine("Grade like Jarryd please. :)");
            }
            else if (firstName.ToLower() + lastName.ToLower() == "jarrydhuntley")
            {
                Console.WriteLine("Grade kindly :)");
            }

            //Age - The Fortuneteller Baba character is old and mad about it
            Console.WriteLine("Please enter your age. And don't ask for mine!");
            int age = int.Parse(Console.ReadLine().Trim());

            //To tell if even or odd
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

            //Bank account
            if (birthMonth > 0 && birthMonth <= 4)
            {
                birthMonth = 20000;
                Console.WriteLine("You must love winter.");
            }
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                birthMonth = 25000;
                Console.WriteLine("Summer months!");
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                birthMonth = 30000;
                Console.WriteLine("Getting cold.");
            }
            else
            {
                birthMonth = 0;
            }

            Console.WriteLine("Please enter your favorite ROYGBIV color. Enter 'Help' for a list of options");
            //Thought this should be formatted a bit
            string help = ("Red\tOrange\tYellow\tGreen\tBlue\tIndigo\tViolet");
            string favoriteColor = Console.ReadLine();

            if (favoriteColor.ToLower() == "help")
            {
                Console.WriteLine(help);
                Console.WriteLine("Now please enter your choice.");
                favoriteColor = Console.ReadLine();
            }

            switch(favoriteColor)
            {
                case "red":
                    favoriteColor = "plane";
                    break;
                case "orange":
                    favoriteColor = "Flying Nimbus";
                    break;
                case "yellow":
                    favoriteColor = "Honda Element";
                    break;
                case "green":
                    favoriteColor = "Delorean";
                    break;
                case "blue":
                    favoriteColor = "Koenigsegg Agera R";
                    break;
                case "indigo":
                    favoriteColor = "Porsche 911";
                    break;
                case "violet":
                    favoriteColor = "pogo stick";
                    break;
                default:
                    favoriteColor = "motorized scooter";
                    break;
            }

            Console.WriteLine("How many siblings do you have?");
            int numberSiblings = int.Parse(Console.ReadLine());
            string vacationHome = numberSiblings.ToString();

            if (numberSiblings == 0)
            {
                vacationHome = "Miami";
            }
            else if (numberSiblings == 1)
            {
                vacationHome = "Paris";
            }
            else if (numberSiblings == 2)
            {
                vacationHome = "San Fransisco";
            }
            else if (numberSiblings == 3)
            {
                vacationHome = "Rome";
            }
            else if (numberSiblings > 3)
            {
                vacationHome = "Cancun";
                Console.WriteLine("Wow, that's a lot.");
            }
            else if (numberSiblings < 0)
            {
                vacationHome = "Detroit";
            }

            //More formatting
            Console.WriteLine("\n\nThis is your fortune: \n\n");
            Console.WriteLine(firstName + " " + lastName + " will retire in only " + age + " years with $" + birthMonth + ".00 in the bank, a vacation home in " + vacationHome + ", and a " + favoriteColor + " to get around.");
        }
    }
}
