using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02.classer
{
    class Engine
    {
        public string Type { get; }
        public string OutPut { get; }
        public string SerialNumber { get; }
        public bool Battery { get; set; }
        public int Speed { get; set; }
        private int speed = 0;

        public int Accelerate()
        {
            Console.WriteLine("Wroom Wroom");
            speed +=10;
            return speed;
        }

        public int Decelerate()
        {
            Console.WriteLine("BREAK!!");
            speed -=10;
            return speed;
        }

        public int LudicrousSpeed()
        {
            Console.WriteLine("No-no-no, light speed is too slow! Yes, we're gonna have to go right to... Ludicrous speed!");
            speed = int.MaxValue;
            return speed;
        }

    }
}
