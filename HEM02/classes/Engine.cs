using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02.classes
{
    class Engine
    {
        
        private bool engineOn;

        public void HorsePower()
        {
            Console.WriteLine(" över 9000");
        }
        public void TurnON()
        {
            Console.WriteLine("engine is turned on");
            engineOn = true;
        }
       public void LudicrousSpeed()
        {
            if (engineOn == true)
                Console.WriteLine("*** Ludicrous speed Engaged *** Nu går det fort som satan");
            else
                Console.WriteLine("starta motorn först");
        }
        public void TurnOff()
        {
            Console.WriteLine("Engine is turned off");
            engineOn = false;
        }
        
    }
}
