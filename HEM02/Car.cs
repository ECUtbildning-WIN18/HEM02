using System;
namespace HEM02
{
    public class Car
    {
        public string Name         { get; }

        public Engine Engine       { get; }
        public Person Owner        { get; }
        public SoundSystem Stereo  { get; }

        public Car(string name, Engine engine, Person owner, SoundSystem stereo)
        {
            Name = name;
            Engine = engine;
            Owner = owner;
            Stereo = stereo;
        }
    }
}
