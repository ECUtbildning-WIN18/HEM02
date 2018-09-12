using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02
{
    class Car
    {
        private string Brand;
        private string Color;   

        public readonly int serialNumber;

        public string Owner { get; set; } = "No owner";

        public Engine Engine { get;  }      // {get} = Samma som readonly?

        public Car(Engine engine, string owner)
        {
            Brand = "Fiat Uno";
            Color = "Unicorn yellow"; //Default values for brand and color
            Engine = engine;
            Owner = owner;  
           

            Random random = new Random();
            serialNumber = random.Next(1, 2147483640);   // All new objects "Car" will get a random serial

        }

        public void UpgradeCar() 
        {
            this.Brand = "Supersonic Volvo"; 
            this.Color = "Kanelblå"; // Declared the default upgrade values for poor people

        }

        public string GetBrand()
        {
            return this.Brand; // Return brand for object
        }

  

      

    }
        
           
       

}
 