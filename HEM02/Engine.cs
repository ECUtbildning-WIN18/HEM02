using System;
namespace HEM02
{
    public class Engine
    {
        public string Model            { get; }
        public int Serial              { get; }
        public DateTime CreationDate   { get; }
        public bool LudicrousSpeed     { get; }
        public bool EngineEnabled      { get; }

        public Engine(string model, int serial, DateTime creationDate, bool ludicrousSpeed)
        {
            Model = model;
            Serial = serial;
            CreationDate = creationDate;
            LudicrousSpeed = ludicrousSpeed;
        }

        public Engine(string model, int serial, DateTime creationDate, bool ludicrousSpeed, bool engineEnabled)
        {
            Model = model;
            Serial = serial;
            CreationDate = creationDate;
            LudicrousSpeed = ludicrousSpeed;
            EngineEnabled = engineEnabled;
        }

        public void BigBoiSpeed()
        {
            if (LudicrousSpeed)
            {
                Console.WriteLine("Once this baby hits 88 miles per hour, you're gonna see some serious sh*t");
            } else
            {
                Console.WriteLine("Not enabled yet, sorry my dude");
            }
        }
    }
}
