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
}
