using HEM02.Classes;
using System;

namespace HEM02
{
    class Program
    {
        static void Main(string[] args)
        {

            Person JeanGrey = new Person("Jean", "Grey", 198001018745);
            Engine monster = new Engine("Telepathic engine", 300, "666 - 666 - 666");
            Car DarkPhoenix = new Car("Tesla", "Model 3", monster, JeanGrey, null);

            Console.WriteLine();
        }
    }
}