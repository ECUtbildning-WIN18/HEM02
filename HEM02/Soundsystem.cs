using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02
{
    class Soundsystem
    {
        private bool isOn = false;

        public bool IsOn { get => isOn; set => isOn = value; }

        public void TurnOnMusic()
        {
            IsOn = true;
        }

        public void TurnOffMusic()
        {
            IsOn = false;
        }

        public string SoundSystemStatus()
        {
            if (IsOn) { return "Music is ON!"; }
            else return "Music is OFF!";
        }

    }
}
