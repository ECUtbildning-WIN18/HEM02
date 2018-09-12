using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02.Model
{
    class Car
    {
        private string Brand { get; }
        private string Model { get; }

        public Engine Engine { get; }
        public Person Owner { get; }
        public SoundSystem SoundSystem { get; }

        public Car(string _Brand, string _Model, Engine _engine, Person _Owner, SoundSystem _SoundSystem)
        {
            Brand = _Brand;
            Model = _Model;
            Engine = _engine;
            Owner = _Owner;
            SoundSystem = _SoundSystem;
        }
    }

    class Engine
    {
        private string Type { get; }
        private int Output { get; }
        private string SerialNumber { get; }
    }

    class Person
    {
        private string FirstName { get; }
        private string LastName { get; }
        private int PersonalID { get; }

        public Person(string _FirstName, string _LastName, int _PersonalID)
        {
            _FirstName = FirstName;
            _LastName = LastName;
            _PersonalID = PersonalID;
        }
    }

    class SoundSystem
    {
        private bool TurnOn { get; }//Ej klar med denna klassen
        private bool TurnOff { get; }
        private string VolumeUpp;
        private string VolumeDown;

        public SoundSystem(bool _TurnOn, bool _TurnOff) // Ej klar!
        {
            TurnOff = _TurnOff;
            TurnOn = _TurnOn;

        }

    }

    class LudicrousSpeed
    {

    }

}
