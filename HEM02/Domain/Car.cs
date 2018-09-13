using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02.Domain
{
    class Car
    {
        public string Brand { get; }
        public string Model { get; }
        public Engine MyEngine { get; }
        public Person Owner { get; }
        //public Soundsystem { get; set; }

        //Constructor
        public Car(string brand, string model, Engine myEngine, Person owner, Soundsystem soundsystem)
        {
            Brand = brand;
            Model = model;
            MyEngine = myEngine;
            Owner = owner;
            Soundsystem = soundsystem;
        }

    }
}
