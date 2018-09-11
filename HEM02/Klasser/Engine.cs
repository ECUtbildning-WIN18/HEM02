using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02.Klasser
{
    class Engine
    {
        public string Type;
        public int Output;
        public string SerialNumber;
        public bool Battery;
        public int Speed = 0;
        public int Accelerate()

        {
            Speed = +10;
            return Speed;
        }

        public int Break()
        {
            Speed = -10;
            return Speed;
        }

        public int LudicrousSpeed()
        {
            Speed = 1000;
            return Speed;
        }
    }
}
