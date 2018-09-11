using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02.Klasser
{
    class Car
    {
        public string Brand;
        public string Model;

        public Engine Engine;

        public Person Owner;

        public SoundSystem Radio;



        public Car(string brand, string model, Engine engine, Person owner, SoundSystem radio)
        {
            Brand = brand;
            Model = model;
            Engine = engine;
            Owner = owner;
            Radio = radio;            

            if (radio.On && engine.Battery)
            {
                radio.RixFm();
            }
            else
            {
                radio.On = false;
            }
        }
    }
}
