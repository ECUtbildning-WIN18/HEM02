using System;

namespace HEM02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tWelcome to your new Tesla!" +
                              "\n\tShould license validation be enabled? 1-yes 2-no");
            int.TryParse(Console.ReadLine(), out int selection);
            switch (selection) 
            {
                case 1:
                    Person ryan = new Person("Ryan", "Cockram", DateTime.Parse("03/02/1994"), true);
                    Engine engine = new Engine("Three", 873642983, DateTime.Parse("01/09/2018"), true);

                    break;
                case 2:

                    break;
                default:
                    Console.WriteLine("\tYou didnt enter a valid option, program will exit" +
                                      "\n\tPlease try again.");
                    break;
            }
        }
    }
}