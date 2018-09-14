using System;

namespace HEM02
{
    class Program
    {

        static void Main(string[] args)
        {
            Person myPerson = new Person("Lord", "Dark Helmet");
            Engine myEngine = new Engine("Electric", 350, "T3-123456789");
            Soundsystem mySoundsystem = new Soundsystem();
            Car myCar = new Car("Tesla", "Model 3", myEngine, myPerson, mySoundsystem);

            myCar.PrintCarData();
            Console.ReadKey();

            myCar.Soundsystem.TurnOnSoundSystem();
            myCar.Soundsystem.TurnOnMusic();
            myCar.Soundsystem.TurnOffMusic();
            myCar.Soundsystem.TurnOffSoundSystem();
            Console.ReadKey();

            
            Console.WriteLine(myCar.ChangeSpeed(100, false));
            myCar.PrintCarData();
            Console.ReadKey();

            Console.WriteLine(myCar.ChangeSpeed(-150, false));
            myCar.PrintCarData();
            Console.ReadKey();

            Console.WriteLine(myCar.ChangeSpeed(300, false));
            Console.ReadKey();

            Console.WriteLine(myCar.ChangeSpeed(100, true));
            Console.ReadKey();

            Console.WriteLine(myCar.ChangeSpeed(1000, false));
            Console.ReadKey();
            
            //Console.ReadLine();

            
        }
        
    }
}
