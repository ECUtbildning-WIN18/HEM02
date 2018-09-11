using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02.classer
{
    class Person
    {
        public string firstName { get; }
        public string lastName { get; }

        public Person(string _firstName, string _lastName)
        {
            firstName = _firstName;
            lastName = _lastName;
        }
    }
}
