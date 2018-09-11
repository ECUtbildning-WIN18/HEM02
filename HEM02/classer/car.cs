using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02.classer
{
    class Car
    {
        public string Brand { get; }
        public string Model { get; }

        public Engine Engine { get; }

        public Person Owner { get; }

        public Sound Radio { get; }

        public Car(string brand, string model, Engine engine, Person owner, Sound radio)
        {
            Brand = brand;
            Model = model;
            Engine = engine;
            Owner = owner;
            Radio = radio;

            if (Engine.Battery)
            {
                radio.OnOff = true;
            }
        }
    }
}
