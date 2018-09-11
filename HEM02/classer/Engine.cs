using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02.classer
{
    class Engine
    {
        public string Type { get; }
        public string Output { get; }
        public string SerialNumber { get; }
        public bool Battery { get; }
        public int Speed = 0;

        public int Accelerate()
        {
            Speed = +10;
            return Speed;
        }

        public int Decelerate()
        {
            Speed = -10;
            return Speed;
        }

        public int LudicrousSpeed()
        {
            Speed = int.MaxValue;
            return Speed;
        }

    }
}
