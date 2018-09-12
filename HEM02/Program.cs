using System;

namespace HEM02
{
        class Program
    {

        static void Main(string[] args)
        {

            


            Owner Dawid = new Owner("Dawid", "Owizyc");
            Engine Model3Engine = new Engine("Hybrid", "123", 0);
            SoundSys TeslaGenelec = new SoundSys();
            Car Tesla = new Car("Tesla", "Model3", Model3Engine, Dawid,TeslaGenelec);
            

            Console.WriteLine("{0} {1}" , Tesla._owner.FirstName, Tesla._owner.LastName);
            Console.WriteLine("{0} {1}", Model3Engine.Type,Model3Engine.SerialNumber,Model3Engine.Speed);
            Console.WriteLine(TeslaGenelec.SpeakersPower);
            Tesla._engine.LudicrousSpeed();
            Tesla._engine.Acceleration();
            Tesla._soundSys.on();
            Tesla._soundSys.off();


            


            
            

            Console.ReadLine();
        }
    }
}
