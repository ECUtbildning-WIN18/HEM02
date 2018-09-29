using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02.Domain
{
    class Engine
    {
        public string Type { get; }
        public int Output { get; }
        public string SerialNumber { get; }
        int RevolutionsPerMinute { get; set; }

        public Engine(string type, int output, string serialNumber)
        {
            Type = type;
            Output = output;
            SerialNumber = serialNumber;
        }

        bool IsRunning;

        public void StartEngine()
        {
            RevolutionsPerMinute = 0;
            IsRunning = true;
        }

        public void StopEngine()
        {
            RevolutionsPerMinute = 0;
            IsRunning = false;
        }

        public void IncreaseOutput()
        {
            if(IsRunning)
            RevolutionsPerMinute += 100;
            Console.WriteLine("Vrrrooom!");
        }

        public void DecreaseOutput()
        {
            if(IsRunning)
            RevolutionsPerMinute -= 100;
            Console.WriteLine("Screech!");
        }

        public void LudicrousSpeed()
        {
            if (IsRunning)
                RevolutionsPerMinute = 3000000;
            Console.WriteLine("Faster than the speed of light!!!");
        }

        public void PrintEngineInfo()
        {
            Console.WriteLine("Type:" + Type);
            Console.WriteLine("Output:" + Output + "kw");
            Console.WriteLine("Serialnumber:" + SerialNumber);
        }
    }
}
