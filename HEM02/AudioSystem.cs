using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02
{
    class AudioSystem
    {

        public string SoundSystem { get; }
        public bool SoundSystemOn { get; set; }

        public AudioSystem(string soundSystem)
        {
            SoundSystem = soundSystem;  
        }
        
        public void TurnOnMusic()
        {
            Console.WriteLine("You are rocking");
            SoundSystemOn = true;
        }

        public void TurnOffMusic()
        {
            Console.WriteLine("in space no one can hear you scream");
            SoundSystemOn = false;
        }

        

    }
}
