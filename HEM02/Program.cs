using System;

namespace HEM02
{
    class Program
    {
        static void Main(string[] args)
        {
            Person anders = new Person("Anders", "Pamp");
            Engine teslaEngine = new Engine("SuperEngine", 500, "123-456-789");

            Car tesla = new Car("Tesla", "Model 3", teslaEngine, anders);
            Console.WriteLine("{ 0}{ 1}{ 3}{ 4}",
            tesla.Brand, tesla.Model, tesla.Engine, tesla.Owner);

            //Extra text för commit
        }
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
    class Engine
    {
        public string Type { get; }
        public int Output { get; }
        public string SerialNumber { get; }

        //Metod
        public Engine(string type, int output, string serialNumber)
        {
            Type = type;
            Output = output;
            SerialNumber = serialNumber;
        }

        public void Accelerate()
        {

        }
        public void LudicrousSpeed()
        {

        }
    }
    class Person
    {
        public string FirstName { get; }
        public string LastName { get; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
    class Soundsystem
    {
        public int Volume;

        public void TurnOn()
        {

        }
        public void TurnOff()
        {

        }
    }

}