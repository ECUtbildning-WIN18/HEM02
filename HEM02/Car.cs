using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02
{
    class Car
    {
        public string Brand { get; }
        public string Model { get; }
        public int Speed { get; private set; }
        public bool loudicrousSpeed;
        public Engine Engine { get; }
        public SoundSystem Music { get; }
        public Owner Owner { get; }


        public void Accelerate()
        {
            Speed += 10;

            if (loudicrousSpeed == true)
            {
                Speed = 500;
            }

            else if(Speed > 100)
            {
                Speed = 100;
            }
        }



        public Car(string brand, string model,Engine engine, SoundSystem music,Owner owner)
        {
            Brand = brand;
            Model = model;
            Engine = engine;
            Music = music;
            Owner = owner;
        }

    }
}
