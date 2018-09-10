using System;

namespace HEM02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Tesla");
        }


        class Car
        {
            public string Brand { get; }
            public string Model { get; }

            public Engine Engine { get; }
            public Person Owner { get; }

            public Car(string brand, string model, Engine engine, Person owner)
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
            public Person(string firstName, string lastName)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
            }
        }

        class Engine
        {
            public string Type { get; }
            public int Output { get; }
            public string SerialNumber { get; }

            public Engine()
            {

            }
        }
    }
}
