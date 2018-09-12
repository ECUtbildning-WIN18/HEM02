using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02
{
    class SoundSystem
    {
        public bool TurnedOn { get; set; }
        public int Volume { get; }

        public SoundSystem (bool turnedon, int volume)
        {
            TurnedOn = turnedon;
        }

    }
}
