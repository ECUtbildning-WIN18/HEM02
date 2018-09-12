using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02
{
    class Engine
    {
        public string name = "Fet motor";

        public void StartEngine()  {Console.WriteLine("Engine started"); } //Start the engine


        public void StopEngine() { Console.WriteLine("Engine turned off"); } //Turn the engine off


        public int HorsePower { get; set; } = 300; //Horsepower, default 300


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
