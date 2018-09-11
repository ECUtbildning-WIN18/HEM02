using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02
{
    class test123
    {
        public static void DoSomething()
        {
            ExerciseClass olle = new ExerciseClass("Olle", 230957);
            olle.PrintName();
        }
        
        
        
    }
    class ExerciseClass
    {
        public int Age { get;}
        public string Name { get; }

        
        public ExerciseClass(string name, int age)
        {
            Age = age;
            Name = name;
        }

        public void PrintName()
        {
            Console.WriteLine("Jag heter {0}",Name);
        }

    }
}
