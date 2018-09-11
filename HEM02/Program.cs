using System;
namespace HEM02
{
    class Program
    {
        static void Main(string[] args)
        {
            Sound _sound = new Sound();
            Engine _engine = new Engine();

            _sound.StartMusic();
            _sound.StopMusic();

            Console.WriteLine($"Current engine stats: " + _engine.SerialNumber + " with " + _engine.HorsePower+" hk");
            _engine.SuperSpeed();
            Console.WriteLine(_engine.HorsePower);
        }

      
   }
   
        
        

        /*public Customer(string FirstName, string LastName, int SocialSecurityNumber)
        Robert Kund = new Robert("John", "Doe", 8409424923);*/

    


}
