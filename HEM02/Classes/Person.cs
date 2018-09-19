using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02.Classes
{
    class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public long PersonalID { get; }

        public Person(string firstName, string lastName, long personalID)
        {
            firstName = FirstName;
            lastName = LastName;
            personalID = PersonalID;
        }
    }
}
