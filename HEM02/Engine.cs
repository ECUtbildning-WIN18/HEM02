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

        private bool isRunning;

        public Engine(string type, int output, string serialNumber)
        {
            Type = type;
            Output = output;
            SerialNumber = serialNumber;
        }

        public int RevolutionsPerMinute { get; set; }

        public void IncreaseOutput()
        {
            if (isRunning)
                RevolutionsPerMinute += 10;
        }
        
        public void DecreaseOutput()
        {
            if (isRunning)
                RevolutionsPerMinute -= 10;
        }

        public void IncreaseOutput(bool isLudicrous)
        {
            if (isLudicrous)
            {
                RevolutionsPerMinute = 100000;
            }
        }

        public void DecreaseOutput(bool isLudicrous)
        {
            if (isLudicrous)
            {
                RevolutionsPerMinute = 0;
            }
        }
    

        public void StartEngine()
        {
            isRunning = true;
        }

        public void StopRunning()
        {
            isRunning = false;
        }

    
        public void GetEngineData()
        {
            Console.WriteLine();
        }
    }
}
