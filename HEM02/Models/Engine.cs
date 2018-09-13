using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02.Models
{
    class Engine
    {
        public string Type { get; }
        public int Output { get; set; }
        public string SerialNumber { get;  }
        
        public Engine(string type, int output, string serialNumber)
        {
            Type = type;
            Output = output;
            SerialNumber = serialNumber;
        }

        public void LudicrousSpeed(bool ludo = false)
        {
            int Lspeed;
            Lspeed = 100;

            if (ludo == true)
            {
                Output = Output + Lspeed;
            }
        }       
    }
}
