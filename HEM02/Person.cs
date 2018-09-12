using System;
namespace HEM02
{
    public class Person
    {
        public string FirstName        { get; }
        public string LastName         { get; }
        public DateTime DateOfBirth    { get; }
        public bool ValidLicense       { get; }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public Person(string firstName, string lastName, DateTime dateOfBirth, bool validLicense)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            ValidLicense = validLicense;
        }
    }
}
