using System;
using System.Collections.Generic;
using System.Text;

namespace HEM02
{
    class Owner
    {
        public string FirstName { get; }
        public string LastName { get; }

        public Owner(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }
    }
}
