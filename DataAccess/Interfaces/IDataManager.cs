using PersonModel;
using System.Collections.Generic;

namespace DataAccess
{
    public interface IDataManager
    {
        List<Person> GetPeople();
        void CreatePerson(IPerson person);
        void DeletePerson(IPerson personId);
        void UpdatePerson(IPerson person);
    }
}