using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02
{
    class Car
    {
        private string Brand { get; set; }

        private string Color { get; set; }

        public int serialNumber { get; }

        public Person Owner { get; } 

        public Engine Engine { get;  }      

        public Car(Engine engine, Person owner)
        {
            Brand = "Fiat Uno";
            Color = "Unicorn yellow"; 
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
 