using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02.Models
{
    public class Cars
    {
        public string Brand { get; }
        public string Model { get; }
        
        public Person _Person { get; }
        public Motor _Motor { get; }
        public SoundSystem _SoundSystem { get; }
        public LudicrousSpeed _LudicrusSpeed { get; }

        public Cars(string brand, string model, Person _Person, Motor _Motor, Soundsystem _SoundSystem)
        {
            Brand = brand;
            Model = model;
            Person = _Person;
            Motor = _Motor;
            Soundsystem = _SoundSystem;
            LudicrousSpeed = _LudicrusSpeed;

        }
    }

    class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string FullName { get { return FirstName + "" + LastName; } }

        public Person(string firstName, string lastName)
        {
            FirstName = FirstName;
            LastName = lastName;
        }

        public FullName()
        {
            return FirstName + LastName;
        }
    }

    class Motor
    {
        public string Type { get; }
        public string SerialNumber { get; }

        public Motor(string type, string serialNumber)
        {
            Type = type;
            SerialNumber = serialNumber;
        }

    }

    class SoundSystem
    {
        public string AudioSoundSystem { get; }
        public bool ON { get; }
        public bool OFF { get; }

        public SoundSystem(string audioSoundSystem)
        {
            AudioSoundSystem = audioSoundSystem;
        }

        public void MusicOn()
        {
            ON = true;
            Console.WriteLine("Turning music on!");
        }

        public void MusicOff()
        {
            Console.WriteLine("Turning music off!");
            OFF = true;
        }

    }

    class LudicrousSpeed
    {
        public bool LudicrousSpeedOn { get; }
        public bool LudicrousSpeedOff { get; }

        public LudicrousSpeed(bool LudicrousSpeedOn, string ludicrousSpeedOff)
        {
            LudicrousSpeedOn = ludicrousSpeedOn;
            LudicrousSpeedOff = ludicrousSpeedOff;
        }
    }
}
