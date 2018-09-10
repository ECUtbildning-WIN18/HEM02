using System;

namespace HEM02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        class Car
        {
            public string Brand { get; }
            public string Model { get; }

            public Engine engine { get; }

            public Person owner { get; }

            public Car(string Brand, string model, Engine engine, Person owner)
            {
                Brand = brand;
                Model = model;
                Engine = engine;
                Owner = owner;
            }
        }

        class Person
        {
            public string FirstName;
            public string LastName;
            public Person()
            {

            }

        }
    }
}
