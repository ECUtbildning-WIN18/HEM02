using System;
namespace HEM02
{
    class Program
    {
        static void Main(string[] args)
        {
            Sound sound = new Sound();
            Engine engine = new Engine();
            Car car = new Car(engine, "Åke Larsson");

            sound.StartMusic(); 
            sound.StopMusic();

            engine.SuperSpeed(); // Adds 3000 horsepower

            car.UpgradeCar(); // changes brand to volvo instead of fiat
            car.GetBrand(); // retrieves the value of brand

            Console.WriteLine(car.serialNumber); 
            
            Console.WriteLine(engine.HorsePower);

            Console.ReadLine();
            
        }

      
   }
   
        
        

        /*public Customer(string FirstName, string LastName, int SocialSecurityNumber)
        Robert Kund = new Robert("John", "Doe", 8409424923);*/

    


}
