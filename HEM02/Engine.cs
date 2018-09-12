using System;
namespace HEM02
{
    public class Engine
    {
        string Model            { get; }
        int Serial              { get; }
        DateTime CreationDate   { get; }
        bool EngineEnabled      { get; }

        public Engine(string model, int serial, DateTime creationDate)
        {
            model = Model;
            serial = Serial;
            creationDate = CreationDate;
        }

        public Engine(string model, int serial, DateTime creationDate, bool engineEnabled)
        {
            model = Model;
            serial = Serial;
            creationDate = CreationDate;
            engineEnabled = EngineEnabled;
        }
    }
}
