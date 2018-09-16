using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02.Classes
{
    class Engine
    {
        public string Type { get; }
        public int Output { get; }
        public string SerialNumber { get; }
        //Att göra
        //Its running bool, start engine.. få igång motorn
        //Gör samma för entretaiment eller soundsystem
        //Göra public metoder med if-satser

        public Engine(string type, int output, string serialNumber)
        {
            Type = type;
            Output = output;
            SerialNumber = serialNumber;
        }
    }
}
