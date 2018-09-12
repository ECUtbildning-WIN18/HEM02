﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02.Classes
{
    class Car
    {
        public string Brand { get; }
        public string Model { get; }

        public Engine Engine { get; }
        public Person Owner { get; }
        public SoundSystem SoundSystem { get; }

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
        private string Type { get; }
        private int Output { get; }
        private string SerialNumber { get; }

        public Engine(string type, int output, string serialNumber)
        {
            Type = type;
            Output = output;
            SerialNumber = serialNumber;
        }
    }

    class Person
    {
        private string FirstName { get; }
        private string LastName { get; }
        private long PersonalID { get; }

        public Person(string firstName, string lastName, long personalID)
        {
            firstName = FirstName;
            lastName = LastName;
            personalID = PersonalID;
        }
    }

    class SoundSystem
    {
        private bool TurnOn { get; }//Ej klar med denna klassen
        private bool TurnOff { get; }
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
