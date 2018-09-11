using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02.classer
{
    class Engine
    {
        public string type { get; }
        public string outPut { get; }
        public string serialNumber { get; }
        public bool battery { get; }
        private int speed = 0;

        public int Accelerate()
        {
            speed = +10;
            return speed;
        }

        public int Decelerate()
        {
            speed = -10;
            return speed;
        }

        public int LudicrousSpeed()
        {
            speed = int.MaxValue;
            return speed;
        }

    }
}
