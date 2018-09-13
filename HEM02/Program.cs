using HEM02.Models;
using System;

namespace HEM02
{
    class Program
    {
        static void Main(string[] args)
        {
            Person alexander = new Person("alexander", "Olofsson");

            Engine motor = new Engine("Wow", 240, "12345");

            Soundsystem soundsystem = new Soundsystem(false);

            Car car = new Car("Opel","77", motor, alexander);

            Console.WriteLine(car.Soundsystem(true));

            car.Engine.LudicrousSpeed(true);

            Console.Write(car.Engine.Output);           
        }
    }
}
