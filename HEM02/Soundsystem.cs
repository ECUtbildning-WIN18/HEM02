using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02
{
    class Soundsystem
    {
        public bool IsOn { get; set; } = false;
        public bool IsPlaying { get; set; } = false;

        public void TurnOnSoundSystem()
        {
            IsOn = true;
            Console.WriteLine("Soundsystem is ON!");
        
        }

        public void TurnOffSoundSystem()
        {
            IsOn = false;
            Console.WriteLine("Soundsystem is OFF!");
        }

        public void TurnOnMusic()
        {
            IsPlaying = true;
            Console.WriteLine("Music is ON!");
        }

        public void TurnOffMusic()
        {
            IsPlaying = false;
            Console.WriteLine("Music is OFF!");
        }
        
        public string SoundSystemStatus()
        {
            return IsPlaying ? "Music is ON!" : "Music is OFF!";

        }
    }
}
