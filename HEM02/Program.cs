using System;

namespace HEM02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            AudioSystem hifi = new AudioSystem("Hifi System");
            AudioSystem badSound = new AudioSystem("Bad SoundSystem");
            

            
            Engine turbo = new Engine("Turbo", 350);
            Engine slow = new Engine("ScrapCar", 89);

            Person theOwner = new Person("Darth", "Vader");
            Person theThief = new Person("Luke", "Skywalker");

            Car elonMusksPrecious = new Car(turbo, theOwner, hifi);
            Car slowTest = new Car(slow, theThief, badSound);
            test123.DoSomething();
            
            //Audio test
            hifi.TurnOnMusic();
            hifi.TurnOffMusic();
            elonMusksPrecious.AudioSystem.TurnOnMusic();
            //Engine test
            elonMusksPrecious.IncreaseSpeed();
            elonMusksPrecious.IncreaseSpeed();
            elonMusksPrecious.IncreaseSpeed();
            slowTest.IncreaseSpeed();
            elonMusksPrecious.LudicrousSpeed();
            slowTest.LudicrousSpeed();
            
            //Console test

            Console.WriteLine("-----------------------------");
            Console.WriteLine(slowTest.Speed);
            Console.WriteLine(elonMusksPrecious.Speed);
            Console.WriteLine(elonMusksPrecious.Model);
            Console.WriteLine(slowTest.Brand);
            
            
            Console.WriteLine(elonMusksPrecious.Owner.Fullname);
            Console.ReadKey();

            
        }
    }
}
