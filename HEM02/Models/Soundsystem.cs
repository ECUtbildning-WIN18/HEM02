using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02.Models
{
    class Soundsystem
    {
        public bool OnOff { get; set; }

        public Soundsystem(bool onOff = false)
        {
            OnOff = onOff;
        }
    }
}
