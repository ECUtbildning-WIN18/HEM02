using HEM02.Modules;
using System;

namespace HEM02
{
    class Program
    {
        static void Main(string[] args)
        {
            Car bil = new Car("Tesla", "Model 3", new Engine(), new Person("Kalle", "Jonsson"));

            Console.WriteLine(bil.engine.CarOn(true));
            Console.WriteLine(bil.engine.Ludo(false));
            Console.WriteLine(bil.SoundSystem(false));

            Console.ReadKey();
        }
    }
}