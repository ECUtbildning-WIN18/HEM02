using System;
namespace HEM02
{
    public class car
    {
        public string Name         { get; }

        public Engine Engine       { get; }
        public Person Owner        { get; }
        public SoundSystem Stereo  { get; }

        public car(string name, Engine engine, Person owner, SoundSystem stereo)
        {
            Name = name;
            Engine = engine;
            Owner = owner;
            Stereo = stereo;
        }
    }
}
