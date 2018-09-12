using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02
{
    class Engine
    {
        

        public string Type { get; }
        public string SerialNumber { get; }
        public bool LudicrousSpeed​ { get; }
        public int Speed = 0;

        public Engine(string type, string serialnumber, int speed)
        {
            Type = type;
            
            SerialNumber = serialnumber;
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

                        Speed = 30;

                        break;

                    case 50:
                        Speed = 50;

                        break;

                    case 90:

                        Speed = 90;

                        break;

                    case 110:

                        Speed = 90;

                        break;

                    case 1000:

                        Console.WriteLine("Vill du köra med LudicrousSpeed?");
                        string svar = Console.ReadLine();

                        if (svar == "y")
                        {
                            
                            
                        }
                        else if (svar == "n")
                        {
                            Console.WriteLine("Du kommer snart till speedMeny");
                            
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
