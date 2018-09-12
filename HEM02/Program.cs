using HEM02.classes;
using System;

namespace HEM02
{
    class Program
    {
        static void Main(string[] args)
        {

            Owner owner = new Owner("Philip", "Vernersson");
            Engine engine = new Engine();
            SoundSystem soundSystem = new SoundSystem();
            Car newCar = new Car("Tesla", "Model 3", engine, owner, soundSystem);

            Console.WriteLine("bilens ägare = {0} {1}", newCar.Owner.FirstName, newCar.Owner.LastName);
            newCar.Engine.TurnON();
            newCar.Engine.LudicrousSpeed();
            newCar.Engine.TurnOff();
            newCar.Engine.LudicrousSpeed();
            newCar.SoundSystem.IncreaseVolume(10);
            newCar.SoundSystem.DecreaseVolume(4);
            
            Console.ReadLine();
        }
    }
}
