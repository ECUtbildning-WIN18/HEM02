using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02.Classes
{
    class Car
    {
        public string brand;
        public string model;

        public Engine engine;

        public Person owner;

        public SoundSystem radio;



        public Car(string Brand, string Model, Engine Engine, Person Owner, SoundSystem Radio)
        {
            brand = Brand;
            model = Model;
            engine = Engine;
            owner = Owner;
            radio = Radio;            

            if (radio.on && engine.battery)
            {
                radio.RixFm();
            }
            else
            {
                radio.on = false;
            }
        }
    }
}
