using System;
namespace HEM02
{
    class Program
    {
        static void Main(string[] args)
        {
            SoundSystem sound = new SoundSystem();
            Engine engine = new Engine();
            Person owner = new Person("Åke","Larsson");
            Car car = new Car(engine, owner);

            Console.WriteLine(owner.FirstName);

            sound.StartMusic();
            sound.StopMusic();

            Console.WriteLine(car.SerialNumber);
            Console.WriteLine(car.GetBrand());
            car.UpgradeCar(); 
            car.GetBrand(); 
            Console.WriteLine(car.GetBrand());

            Console.WriteLine(engine.Name);
            Console.WriteLine(engine.HorsePower);
            engine.SuperSpeed(); 
            Console.WriteLine(engine.HorsePower);
        }
   }
}
