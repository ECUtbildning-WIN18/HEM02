using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02.Classes
{
    class Car
    {
        public string Brand { get; }
        public string Model { get; }

        private Engine Engine { get; }
        private Person Owner { get; }
        private SoundSystem SoundSystem { get; }

        public Car(string brand, string model, Engine engine, Person owner, SoundSystem soundSystem)
        {
            Brand = brand;
            Model = model;
            Engine = engine;
            Owner = owner;
            SoundSystem = soundSystem;
        }

    }

    class Engine
    {
        public string Type { get; }
        public int Output { get; }
        public string SerialNumber { get; }

        public Engine(string type, int output, string serialNumber)
        {
            Type = type;
            Output = output;
            SerialNumber = serialNumber;
        }
    }

    class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public long PersonalID { get; }

        public Person(string firstName, string lastName, long personalID)
        {
            firstName = FirstName;
            lastName = LastName;
            personalID = PersonalID;
        }
    }

    class SoundSystem
    {
        public bool TurnOn { get; }//Ej klar med denna klassen
        public bool TurnOff { get; }
        private string VolumeUpp;
        private string VolumeDown;

        public SoundSystem(bool turnOn, bool turnOff) // Ej klar!
        {
            TurnOff = turnOff;
            TurnOn = turnOn;
        }

    }

    class LudicrousSpeed
    {

    }

}
