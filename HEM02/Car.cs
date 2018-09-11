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
        public Car (string brand, string model)
        {
            Brand = brand;
            Model = model;
        }
        
        public Engine Engine { get; }
        public Owner Owner { get; }

        public Car (string Brand, string Model, Engine engine, Owner owner)
        {
            Brand = brand;
            Model = model;
            Engine = engine;
            Owner = owner;


        }

            //methods for car
        public void Accelerate()
        {}
        public void LudicrousSpeed()
        { }

    }
}
