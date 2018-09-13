using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02.Domain
{
    class Person
    {
        public string FirstName { get; }
        public string LastName { get; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
