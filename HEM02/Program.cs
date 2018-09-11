using System;

namespace HEM02
{
    class SoundSystem // Add soundsystem. Sets 50W as default output. Associate with Car.
    {
        private int OutputW = 50; //System output in Watt
        
        public void PlayMusic() // Method for playing music.
        {
            bool playButton = false;
            while (playButton == true)
            {
                Console.WriteLine("Playing music");
            }
           
        }
    }
    class Engine // create new engine. Input serialnumber, type(string) and output in Kw(int). Use for association with Car.
    {
        public int SerialNumber { get; } 
        public string Type { get; }
        private int OutputKw;
        

        public Engine(int serialNumber, string type, int outputKw)
        {
            SerialNumber = serialNumber;
            Type = type;
            OutputKw = outputKw;
            
        }
        public void EngineStart() // Placeholder Method to start Engine
        {

        }
        public void EngineStop() // Placeholder Method to stop engine
        {
           
        }
        public void SpeedUp() // Method to increase Kw when a button is pushed.
        {
            Console.WriteLine("Do you want to get home in time for 'På spåret'? Y/N");
            string yes = Console.ReadLine();
            switch (yes)
            {
                case "y":
                    while (OutputKw < 500)
                    OutputKw++;
                    Console.WriteLine("Ludicrous Speed Activated");
                    break;
                case "n":
                    Console.Clear();
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


        public Engine _engine { get; }
        public Person _owner { get; }
        public SoundSystem _soundsystem { get; }

        public Car(string brand, string model, Engine engine, Person owner, SoundSystem soundsystem)
        {
            Brand = brand;
            Model = model;
            _engine = engine;
            _soundsystem = soundsystem;
            _owner = owner;
        }

    }
    
    class Program
    {
        

        }
        static void Main(string[] args)
        {
            Person _philip = new Person("Philip", "Englund");
            Engine tesla_engine = new Engine(124929, "Electric", 300);
            SoundSystem tesla_soundsystem = new SoundSystem();
            Car tesla = new Car("Tesla", "Model Beast", tesla_engine, _philip, tesla_soundsystem);
            tesla_engine.SpeedUp();
            
        }
    }
}
