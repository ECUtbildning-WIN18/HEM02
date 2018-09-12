using System;
namespace HEM02
{
    public class Person
    {
        String FirstName        { get; }
        String LastName         { get; }
        DateTime DateOfBirth    { get; }
        bool ValidLicense       { get; }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            firstName = FirstName;
            lastName = LastName;
            dateOfBirth = DateOfBirth;
        }

        public Person(string firstName, string lastName, DateTime dateOfBirth, bool validLicense)
        {
            firstName = FirstName;
            lastName = LastName;
            dateOfBirth = DateOfBirth;
            validLicense = ValidLicense;
        }
    }
}
