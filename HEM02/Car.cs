using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02
{
    class Car
    {
        public string Brand { get; }
        public string Model { get; }
        public Engine Engine { get; }
        public int Speed { get; set; } = 0;
        public Soundsystem Soundsystem;

        public Person Owner { get; }
        
        private bool isLudicrousSpeed = false;


        public Car(
            string brand, 
            string model, 
            Engine engine, 
            Person owner, 
            Soundsystem soundSystem)
        {            
            Brand = brand;
            Model = model;
            Engine = engine;
            Owner = owner;
            Soundsystem = soundSystem;
        }


        public void PrintCarData()
        {
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Speed: " + Speed);

            Console.WriteLine("Engine type: " + Engine.Type);
            Console.WriteLine("Engine output: " + Engine.Output);
            Console.WriteLine("Engine serialnumber: " + Engine.SerialNumber);

            Console.WriteLine("Owner: " + Owner.FirstName + " " + Owner.LastName);

            Console.WriteLine("Sound system: " + Soundsystem.SoundSystemStatus() );
            Console.WriteLine();
        }


        public int ChangeSpeed(int speedChange, bool ludicrousSpeed)
        {
            if (isLudicrousSpeed == true && !ludicrousSpeed)
            {
                isLudicrousSpeed = ludicrousSpeed;
                return Speed;
            } else if (Speed > 0 && Speed + speedChange < 0 && !ludicrousSpeed) 
            {
                return Speed = 0;
            } else if(ludicrousSpeed)
            {
                isLudicrousSpeed = ludicrousSpeed;
                Speed = int.MaxValue;
                Console.WriteLine("Speed: " + Speed + " * speed of light");
                return Speed;
            } else
            {
                return Speed += speedChange;
            }
        }


    }
}
