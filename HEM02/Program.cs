using HEM02.classer;
using System;

namespace HEM02
{
    class Program
    {
        static void Main(string[] args)
        {
            SoundSystem Radio = new SoundSystem();
            Engine Engine = new Engine();
            Car volvo = new Car();
            volvo.Brand = "Volvo";
            volvo.Model = "240";
            Person owner = new Person();
            owner.FirstName = "Joakim";
            owner.LastName = "Persson";
            Console.WriteLine(volvo.Brand +" "+ volvo.Model +" "+ owner.FirstName +" "+ owner.LastName);
            
            
            Engine.Accelerate();
            Engine.Decelerate();
            Engine.LudicrousSpeed();
            Engine.Battery = true;
            
            Radio.on = true;
            Radio.RixFm();

            Console.ReadLine();

        }
    }
}
