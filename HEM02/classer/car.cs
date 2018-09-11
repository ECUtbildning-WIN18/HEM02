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
        public SoundSystem Radio { get; }


        public Car(string brand, string model, Engine engine, Person owner, SoundSystem radio)
        {
            Brand = brand;
            Model = model;
            Engine = engine;
            Owner = owner;
            Radio = radio;

            if (radio.on && engine.battery)
            {
                radio.rixFm();
            }
            else
            {
                radio.on = false;
            }
        }
    }
}
