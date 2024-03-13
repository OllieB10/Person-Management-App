using System;

namespace PersonModel
{
    public class Person : IPerson
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EmailAddress { get; set; }
        public string Gender { get; set; }
        public string FullName => $"{FirstName} {LastName}";
    }
}
