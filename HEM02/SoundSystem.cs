using System;
namespace HEM02
{
    public class SoundSystem
    {
        float Volume { get; }
        float Bass { get; }
        float Treble { get; }
        bool Power { get; }

        public SoundSystem(float volume, float bass, float treble, bool power)
        {
            volume = Volume;
            bass = Bass;
            treble = Treble;
            power = Power;
        }
    }
}
