using System;
namespace HEM02
{
    public class SoundSystem
    {
        public float Volume    { get; }
        public float Bass      { get; }
        public float Treble    { get; }
        public bool Power      { get; }

        public SoundSystem(float volume, float bass, float treble, bool power)
        {
            Volume = volume;
            Bass = bass;
            Treble = treble;
            Power = power;
        }
    }
}
