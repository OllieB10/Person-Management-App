using System;

namespace PersonModel
{
    public interface IPerson
    {
        int PersonId { get; set; }
        DateTime DateOfBirth { get; set; }
        string EmailAddress { get; set; }
        string FirstName { get; set; }
        string Gender { get; set; }
        string LastName { get; set; }
    }
}