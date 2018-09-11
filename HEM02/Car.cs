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
        //härifrån är är jag lite osäker på vad jag egentligen gör...behöver få mer förklarat om Aggregat/Association
        public Engine Engine { get; } 
        public Owner Owner { get; } 

        public Car (string Brand, string Model, Engine engine, Owner owner)
        {
            Brand = brand;
            Model = model;
            Engine = engine;
            Owner = owner;


        }

        

    }
}
