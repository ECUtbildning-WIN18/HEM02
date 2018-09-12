using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02
{
    class Engine
    {
        public string Type { get; }
        public int Output { get; }
        public string SerialNumber { get; }

        public Engine(string type, int output, string serialNumber)
        {
            Type = type;
            Output = output;
            SerialNumber = serialNumber;
        }

        public void GetEngineData()
        {
            Console.WriteLine();
        }
    }
}
