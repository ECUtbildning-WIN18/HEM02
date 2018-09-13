using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02.Models
{
    class Car
    {
        public string Brand { get; }
        public string Model { get; }

        public Engine Engine { get; }

        public Person Owner { get; }        
            
        public Engine LudicrousSpeed { get; }

        public Car(string brand, string model, Engine engine, Person owner)
        {
            Brand = brand;
            Model = model;
            Engine = engine;
            Owner = owner;
        }

        public string Soundsystem(bool onOff)
        {
            if (onOff == true)
            {
                return "Audio is on";
            }
            else
            {
                return "Audio is off";
            }
        }
    }
}
