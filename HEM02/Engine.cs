using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02
{
    class Engine
    {
        public string Name { get; } = "Fet motor";

        public void StartEngine()
        {
            Console.WriteLine("Engine started");
        } 

        public void StopEngine()
        {
            Console.WriteLine("Engine turned off");
        } 

        public int HorsePower { get; set; } = 300; 

        public void SuperSpeed()  //SuperSpeed = adds 3000 to horsepower
        {
            for (int i = 0; i < 3000; i++)
            {
              HorsePower++;

                if (HorsePower >= 3300)
                {
                    Console.WriteLine("Super speed activated!");
                }
            }
        }
    }
}
