using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02.Domain
{
    class Engine
    {
        public string Type { get; }
        public int Output { get; set; }
        public string SerialNumber { get; }
        private bool IsRunning { get; set; }
        public int Accelerate { get; set; }
        //Constructor
        public Engine(string type, int output, string serialNumber)
        {
            Type = type;
            Output = output;
            SerialNumber = serialNumber;
        }
        //Method
        public void StartEngine()
        {

        }
        public void Accelerate()
        {
            if (IsRunning)
                Accelerate += 10;
        }
        public void LudicrousSpeed()
        {

        }
    }
}
