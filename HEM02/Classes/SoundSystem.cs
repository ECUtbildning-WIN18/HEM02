using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02.Classes
{
    class SoundSystem
    {
        public bool TurnOn { get; }//Ej klar med denna klassen
        public bool TurnOff { get; }
        private string VolumeUp;
        private string VolumeDown;

        public SoundSystem(bool turnOn, bool turnOff) // Ej klar!
        {
            TurnOff = turnOff;
            TurnOn = turnOn;
        }
    }
}
