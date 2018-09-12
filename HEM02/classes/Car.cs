using HEM02.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02.classes
{
    class Car
    {
        public string Brand { get; }
        public string Model { get; }

        public Engine Engine { get; }

        public Owner Owner { get; }

        public SoundSystem SoundSystem { get; }

        public Car(string brand, string model, Engine engine, Owner owner, SoundSystem soundSystem)
        {
            Brand = brand;
            Model = model;
            Engine = engine;
            Owner = owner;
            SoundSystem = soundSystem;
        }
        

    }
}
