using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace HEM02
{
    class Engine
    {


        public string Type { get; }
        public string SerialNumber { get; }
        
        public int Speed = 0;

        public Engine(string type, string serialnumber, int Speed)
        {
            Type = type;
            
            SerialNumber = serialnumber;
        }
        public void LudicrousSpeed()
        {
            Console.WriteLine();
        }
        


        public void Acceleration()
        {
            bool speedMenu = true;

            while (speedMenu)
            {
                Console.WriteLine("Hur snabbt vill du köra? ");

                Int32.TryParse(Console.ReadLine(), out int speedTal);

                switch (speedTal)
                {
                    case 30:
                        Console.WriteLine("Speed 30kmh");
                        Speed = 30;

                        break;

                    case 50:
                        Console.WriteLine("Speed 50kmh");
                        Speed = 50;

                        break;

                    case 90:
                        Console.WriteLine("Speed 90kmh");
                        Speed = 90;

                        break;

                    case 110:

                        Console.WriteLine("Speed 110kmh");
                        Speed = 90;

                        break;

                    case 1000:

                        Console.WriteLine("Vill du köra med LudicrousSpeed?");
                        string svar = Console.ReadLine();

                        if (svar == "y")
                        {
                            Console.WriteLine("LudicrousSpeed Speed On");
                            Speed = 1079252848;

                        }
                        else if (svar == "n")
                        {
                            Console.WriteLine("Du kommer snart till speedMeny");
                            Thread.Sleep(2000);
                            
                        }
                        
                        break;

                    default:
                        Console.WriteLine(" ");
                        break;
                }

            }

        }

        
    }
}
