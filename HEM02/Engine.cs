using System;
namespace HEM02
{
    public class Engine
    {
        string Model            { get; }
        int Serial              { get; }
        DateTime CreationDate   { get; }
        bool LudicrousSpeed     { get; }
        bool EngineEnabled      { get; }

        public Engine(string model, int serial, DateTime creationDate, bool ludicrousSpeed)
        {
            model = Model;
            serial = Serial;
            creationDate = CreationDate;
            ludicrousSpeed = LudicrousSpeed;
        }

        public Engine(string model, int serial, DateTime creationDate, bool ludicrousSpeed, bool engineEnabled)
        {
            model = Model;
            serial = Serial;
            creationDate = CreationDate;
            ludicrousSpeed = LudicrousSpeed;
            engineEnabled = EngineEnabled;
        }
    }
}
