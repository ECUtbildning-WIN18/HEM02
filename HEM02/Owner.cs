using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02
{
    class Owner
    {
        public string FirstName { get; }
        public string LastName { get; }


        public Owner (string firstName, string lastName )
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
