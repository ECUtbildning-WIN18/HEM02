using System;

namespace HEM02
{
    class car
    {
        public string Owner { get; set; }
        public string Registration { get; set; }
        public string Color { get; set; }

    }

    class Engine
    {
        double SerialNumber { get; set; }
        double HorsePower { get; set; }
        public double Speed { get; set; } 

        public void Accelerate ()
        {
            Speed = Speed + 10;
        }
        public void Breaking ()
        {
            Speed = Speed - 10;

        }
        public void RaceButton ()
        {
            Speed = Speed + 20;

        }
    }
    class Audio
    {
        public bool Switch { get; set; }
        public double Volume { get; set; }

        public void OnOff ()
        {
            Switch = !Switch;

        }
        public void IncreaseVolume ()
        {
            Volume = Volume + 5;


        }
        public void Decrease ()
        {
            Volume = Volume - 5;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
