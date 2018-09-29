using HEM02.Domain;
using System;

namespace HEM02
{
    class Program
    {
        static void Main(string[] args)
        {
            var myPerson = new Person("John", "Doe");
            var myRadio = new SoundSystem("Bose", "273910");
            var myEngine = new Engine("Electric", 200, "9282819");
            var myCar = new Car("Tesla", "3", myEngine, myPerson, myRadio);

            myCar.StartButton();
            myCar.PlayMusic();
            myCar.Accelerate();
            myCar.TurnOffMusic();
            myCar.Brake();
            myCar.ButtonLSpeed();
            myCar.OffButton();
            myCar.StatusCheck();
        }
    }
}
