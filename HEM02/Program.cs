using HEM02.Classes;
using System;

namespace HEM02
{

    class Program
    {
        static void Main(string[] args)
        {

            car car;
            car = new car();
            Console.WriteLine("Please enter the owner's name :");
            car.Owner = Console.ReadLine();
            Console.WriteLine("Please enter the car's color :");
            car.Color = Console.ReadLine();
            Console.WriteLine("Please enter the car's registration");
            car.Registration = Console.ReadLine();

            Console.WriteLine(car.Owner);
            Console.WriteLine(car.Color);
            Console.WriteLine(car.Registration);

            Audio audio = new Audio();
            Console.WriteLine("\n\n************************************");
            Console.WriteLine("Audio options :\n1.Turn it off/on.\n2.Increase volume.\n3.Decrease volume.");
            int audioAnswer = 0;
                audioAnswer = int.Parse(Console.ReadLine());

            switch(audioAnswer)
            {
                case 1:
                    audio.OnOff();
                    break;
                case 2:
                    audio.IncreaseVolume();
                    break;
                case 3:
                    audio.DecreaseVolume();
                    break;

            }

            Engine engine = new Engine();
            Console.WriteLine("Enter the car's Serialnumber");

            engine.SerialNumber =double.Parse( Console.ReadLine());

            Console.WriteLine("1.To accelerate.\n2.To break.\n3.Race mode");
            int engineAnswer = 0;
            switch(engineAnswer)
                {
                case 1:
                    engine.Accelerate();
                    break;
                case 2:
                    engine.Breaking();
                    break;
                case 3:
                    engine.RaceButton();
                    break;
               
            }




            Console.ReadKey();





        }
    }
}
