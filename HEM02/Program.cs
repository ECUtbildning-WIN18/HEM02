using System;

namespace HEM02
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner owner = new Owner("Robert", "Tublén");
            Car tesla = new Car("Tesla", "3", new Engine(), new SoundSystem(true, 0),owner);

            Console.WriteLine("Welcome to your " + tesla.Brand + " " + tesla.Model + ", " + tesla.Owner.FirstName + "\n" + "Would you like to turn on some music? (y/n)");
            string userInput = Console.ReadLine();

            if(userInput == "y")
            {
                tesla.Music.TurnedOn = true;
                Console.WriteLine("Oh, how nice. Your favourite song 'Rosa helikopter' is now playing.");

            }

            Console.WriteLine("You are currently traveling in " + tesla.Speed + "km/h, would you like to enter loudicrous speed? (y/n)");
            userInput = Console.ReadLine();

            if (userInput == "y")
            {
                tesla.loudicrousSpeed = true;
                tesla.Accelerate();
                Console.WriteLine("You are currently traveling in " + tesla.Speed + "km/h.");
            }
            
                Console.ReadKey();
        }
    }
}
