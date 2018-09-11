/*class Engine // create new engine. Input serialnumber, type(string) and output in Kw(int). Use for association with Car.
{
    public int SerialNumber { get; }
    public string Type { get; }
 


    public Engine(int serialNumber, string type,)
    {
        SerialNumber = serialNumber;
        Type = type;
       

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

        }*/