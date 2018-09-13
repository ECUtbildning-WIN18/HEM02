using System;
namespace HEM02
{
    public class SoundSystem
    {
        public double Volume    { get; }
        public double Bass      { get; }
        public double Treble    { get; }
        public bool Power      { get; }

        public SoundSystem(double volume, double bass, double treble, bool power)
        {
            Volume = volume;
            Bass = bass;
            Treble = treble;
            Power = power;
        }
    }
}
