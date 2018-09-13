using System;

namespace HEM02
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection;
            bool validation = false; //DISABLED BY DEFAULT
            bool valid = false; //DISABLED BY DEFAULT
            bool turbo = false; //DISABLED BY DEFAULT

            Console.WriteLine("\tWelcome to your new Tesla!");

            #region PREREQUISITES
            Console.WriteLine("\n\tShould license validation be enabled? 1-yes 2-no");
            int.TryParse(Console.ReadLine(), out selection);
            if (selection == 1)
            {
                validation = true;
            }
            else if (selection == 2)
            {
                validation = false;
            }
            else if (selection != 1 || selection != 2)
            {
                Console.WriteLine("\tYou didnt enter a valid option, program will now exit" +
                                      "\n\tPlease try again.");
                Environment.Exit(0);
            }

            Console.WriteLine("\t\nShould Ludicrous Speed be enabled? 1-yes 2-no");
            int.TryParse(Console.ReadLine(), out selection);
            if (selection == 1)
            {
                turbo = true;
            }
            else if (selection == 2)
            {
                turbo = false;
            }
            else if (selection != 1 || selection != 2)
            {
                Console.WriteLine("\tYou didnt enter a valid option, program will now exit" +
                                      "\n\tPlease try again.");
                Environment.Exit(0);
            }
            #endregion
            #region GATHER AND CREATE OWNER INFO
            Person owner;
            Console.WriteLine("\t\nPlease enter owner information");
            Console.Write("\t\nFirst name: ");
            string fn = Console.ReadLine();
            Console.Write("\t\nLast name: ");
            string ln = Console.ReadLine();
            Console.Write("\t\nDate of Birth (Format: YYYY/MM/DD): ");
            DateTime birth = new DateTime();
            if (DateTime.TryParse(Console.ReadLine(), out DateTime x))
            {
                birth = x;
            }
            else
            {
                Console.WriteLine("\t\nIncorrect date format entered, program will now exit");
                Environment.Exit(0);
            }
            if (validation)
            {
                Console.Write("\t\nIs your current license valid? 1-yes 2-no: ");
                int.TryParse(Console.ReadLine(), out int v);
                if (v == 1)
                {
                    valid = true;
                }
                else if (v == 2)
                {
                    valid = false;
                }
                else if (selection != 1 || selection != 2)
                {
                    Console.WriteLine("\tYou didnt enter a valid option, program will now exit" +
                                          "\n\tPlease try again.");
                    Environment.Exit(0);
                }
                //Creates owner and takes license vaidation info, based on previous choices
                owner = new Person(fn, ln, birth, valid);

            }
            else
            {
                //Creates owner without stating whether license is vaid, based on previous choices
                owner = new Person(fn, ln, birth);
            }
            #endregion
            #region CREATE ENGINE AND CHECK FOR VALIDATION IF NECCESSARY
            Engine engine;
            if (!validation)
            {
                engine = new Engine("Three", 3874632, DateTime.Now, turbo);
            }
            else
            {
                if (valid)
                {
                    engine = new Engine("Three", 3874632, DateTime.Now, turbo, true);
                }
                else
                {
                    engine = new Engine("Three", 3874632, DateTime.Now, turbo, false);
                }
            }
            #endregion
            #region CREATES SOUND SYSTEM
            SoundSystem stereo = new SoundSystem(0.5, 0.5, .5, true);
            #endregion
            #region CREATES THE CAR FINALLY
            Car tesla = new Car("Model S", engine, owner, stereo);
            #endregion

            tesla.Engine.BigBoiSpeed();
            
            Console.ReadLine();
        }
    }
}