using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02.classes
{
    class SoundSystem
    {
        public int volume;

        public void IncreaseVolume(int addedVolume)
        {
            volume += addedVolume;
            Console.WriteLine("Ökar volymen med {0}. Volymen är nu {1}!", addedVolume, volume);
        }
        public void DecreaseVolume(int decreasedVolume)
        {
            volume -= decreasedVolume;
            Console.WriteLine("Minskar volymen med {0}. Volymen är nu {1}!", decreasedVolume, volume);
        }
    }
}
