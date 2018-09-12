using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02.Classes
{
    class Audio
    {
        public bool Switch { get; set; }
        public double Volume { get; set; }

        public void OnOff()
        {
            Switch = !Switch;

        }
        public void IncreaseVolume()
        {
            Volume = Volume + 5;


        }
        public void DecreaseVolume()
        {
            Volume = Volume - 5;
        }

    }
}
