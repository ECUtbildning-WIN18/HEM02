using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02.Classes
{
    class Engine
    {
        public string type;
        public int output = 0;
        public string serialNumber;
        public bool battery;
        public int speed = 0;
        public int accelerate()

        {
            speed = +10;
            return speed;
        }

        public int Break()
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
