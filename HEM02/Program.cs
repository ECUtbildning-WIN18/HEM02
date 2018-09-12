using System;

namespace HEM02
{
    class SoundSystem // Add soundsystem. Sets 50W as default output. Associate with Car.
    {
        private int outputWatt = 50; //System output in Watt
        
           public void PlayMusic() // Method for playing music.
           {
               bool playButton = false;
               while (playButton)
               {
                Console.WriteLine("Playing music");
               }
           
           }
    }
    class Engine // create new engine. Input serialnumber, type(string) and output in Kw(int). Use for association with Car.
    {
        public int SerialNumber { get; } 
        public string Type { get; }
        private int outputKiloWatt;
        
           public Engine(int serialNumber, string type, int outputkilowatt)
           {
               SerialNumber = serialNumber;
               Type = type;
               outputKiloWatt = outputkilowatt;
            
           }

        public void SpeedUp() // Method to increase Kw when a button is pushed.
        {
            Console.WriteLine("Do you want to get home in time for 'På spåret'? y/n");
            string yes = Console.ReadLine();
            switch (yes)
            {
                case "y":
                    while (outputKiloWatt < 500)
                    outputKiloWatt++;
                    Console.WriteLine("Ludicrous Speed Activated");
                    break;
                case "n":
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Wrong choice, try again");
                    SpeedUp();
                    break;
            }
   
        }

    class Person // Adds person. Input First name and last name.

    {

        public string FirstName { get; } 
        public string LastName { get; }
        
        
           public Person(string firstName, string lastName)

           {
              FirstName = firstName;
              LastName = lastName;
           }
    }

    class Car // new car. Assign brand and model, associate Engine, Person and SoundSystem.
    {
        public string Brand { get; } 
        public string Model { get; }


          public Engine PowerSource { get; }
          public Person Owner { get; }
          public SoundSystem Radio { get; }

            public Car(string brand, string model, Engine engine, Person owner, SoundSystem soundsystem)
            {
               Brand = brand;
               Model = model;
               PowerSource = engine;
               Radio = soundsystem;
               Owner = owner;
            }
        
               public void Accelerate()
               {
                Console.WriteLine("Away we go!");
               }

               public void Brake()
               {
                Console.WriteLine("Slowing down...");
               }

    }
    
    class Program
    {
        

        }

        static void Main(string[] args)
        {
            Person philip = new Person("Philip", "Englund");
            Engine teslaEngine = new Engine(124929, "Electric", 300);
            SoundSystem teslaSoundSystem = new SoundSystem();
            Car tesla = new Car("Tesla", "Model Beast", teslaEngine, philip, teslaSoundSystem);
            tesla.Accelerate();
            teslaEngine.SpeedUp(); 
        }
    }
}
