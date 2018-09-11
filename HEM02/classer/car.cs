using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02.classer
{
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Person Owner { get; set; }
        public SoundSystem Radio { get; set; }


        public Car(string brand, string model, Engine engine, Person owner, SoundSystem radio)
        {
            Brand = brand;
            Model = model;
            Engine = engine;
            Owner = owner;
            Radio = radio;

            if (radio.on && engine.Battery)
            {
                radio.RixFm();
            }
            else
            {
                radio.on = false;
            }
        }

        public Car()
        {
        }
    }
}
