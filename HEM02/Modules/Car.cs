using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02.Modules
{
    class Car
    {
        private string brand { get; }
        private string model { get; }
        public Engine engine { get; }
        public Person owner { get; }

        public Car (string _brand, string _model, Engine _engine, Person _owner)
        {
            brand = _brand;
            model = _model;
            engine = _engine;
            owner = _owner;
        }

        public string SoundSystem (bool onOff)
        {
            if (onOff == true)
            {
                return "Radio is on ~ ";
            } else
            {
                return "Radio is off";
            }
        }
    }
}
