using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02
{
    class Car
    {
        public string Brand { get; }
        public string Model { get; }
        public int Speed { get; set; }
        public bool SoundSystemOn { get; set; }

        public Engine Engine { get; }
        public Person Owner { get; }
        public AudioSystem AudioSystem { get; }

        public Car(Engine engine, Person owner, AudioSystem audioSystem)
        {
            Brand = "Tesla";
            Model = "Model 3";
            Engine = engine;
            Owner = owner;
            AudioSystem = audioSystem;
            Speed = 0;


        }
        public void IncreaseSpeed()
        {
            Speed = Speed + 10;
        }

        public void Brake()
        {
            Speed = Speed - 10;
        }

        public void LudicrousSpeed()
        {
            if (Engine.Type == "ScrapCar")
            {
                Speed = 0;
                Console.WriteLine("Dont belive your car has that function!");
            }
            else
            {
                Speed = 1079252849;
            }
            
        }

        
    }
}
