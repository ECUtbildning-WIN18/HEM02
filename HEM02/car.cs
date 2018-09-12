using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02
{
    class Car
    {


        public string Brand { get; }
        public string Model { get; }

        public Engine _engine { get; }
        public Owner _owner { get; }
        public SoundSys _soundSys { get; }

        
        public Car(string brand,string model,Engine engine, Owner owner, SoundSys soundSys)
        {
            Brand = brand;
            Model = model;
            _engine = engine;
            _owner = owner;
            _soundSys = soundSys;
                

        }

        




        
    }

        


}
