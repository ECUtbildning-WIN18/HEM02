using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02
{
    class Person
    {
        public string Firstname { get; }
        public string Lastname { get; }
        public string Fullname { get { return Firstname + " " + Lastname; } }

        public Person(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        public string GetOwner()
        {
            return Firstname + Lastname;
        }
    }

    
}
