using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02
{
    class Engine
    {
        string randomSerial;

        public int HorsePower { get; set; } = 300;
        public string SerialNumber { get; set; } = "Unknown serial";

        public void SuperSpeed()
        {
            for (int i = 0; i < 3000; i++)
            {
              HorsePower++;
            }
           
        }
        



    }
}
