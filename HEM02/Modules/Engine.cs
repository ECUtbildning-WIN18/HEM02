using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02.Modules
{
    class Engine
    {

        private string Type { get; } 
        private int SerialNumber { get; }
        private int ludoPower = 80;
        private int standardOutput;
        public int Output { get; set; }

        public Engine (string type = "Electric", int _standardOutput = 180, int _serialNr = 123125)
        {
            Type = type;
            standardOutput = _standardOutput;
            SerialNumber = _serialNr;
        }

        public string CarOn(bool ignite)
        {
            if (ignite)
            {
                return "The car turns on";
            }
            else
            {
                return "The car turns off";
            }

        }

        public string Ludo (bool onOff)
        {
            if (onOff == true)
            {
                Output = standardOutput + ludoPower;

                return "Ludocris power is on: " + Output ;
            } else
            {
                Output = standardOutput;

                return "Ludocris power is off: " + Output;
            }
            
        }
    }
}
