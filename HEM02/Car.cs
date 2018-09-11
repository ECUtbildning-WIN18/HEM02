using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02
{
    class Car
    {
        public string RegNumber { get; }
        public string Model { get; }
        public string Brand { get; }
        
        public Car (string regnumber, string brand, string model)

        {
            Brand = brand;
            Model = model;
            RegNumber = regnumber;
        }
        
        public Engine Engine { get; } //här är jag lite osäker på vad jag egentligen gör...
        public Owner Owner { get; } //se ovan kommentar

        public Car (string Brand, string Model, Engine engine, Owner owner)
        {
            Brand = brand;
            Model = model;
            Engine = engine;
            Owner = owner;


        }

        

    }
}
