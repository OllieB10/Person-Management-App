
using PersonModel;
using System.Collections.Generic;

namespace DataAccess
{
    public class DataManager : IDataManager
    {
        private readonly IDatabaseConnection _connectionString;

        private readonly IDatabaseOperations _databaseOperations;

        public DataManager(IDatabaseConnection connection, IDatabaseOperations databaseOperations)
        {
            _connectionString = connection;
            _databaseOperations = databaseOperations;      
        }

        public List<Person> GetPeople()
        {
            string sql = "SELECT PersonId, FirstName, LastName, DateOfBirth, EmailAddress, Gender FROM People";

            List<Person> people = _databaseOperations.GetData<Person, dynamic>(sql, new { }, _connectionString.GetConnectionString());

            return people;
        }

        public void CreatePerson(IPerson person)
        {
            string sql = "INSERT INTO People (FirstName, LastName, DateOfBirth, EmailAddress, Gender) VALUES (@FirstName, @LastName, @DateOfBirth, @EmailAddress, @Gender)";
            _databaseOperations.SaveData(sql, new { person.FirstName, person.LastName, person.DateOfBirth, person.EmailAddress, person.Gender }, _connectionString.GetConnectionString());
        }

        public void DeletePerson(IPerson person)
        {
            string sql = "DELETE FROM People WHERE PersonId = @PersonId";

            _databaseOperations.DeleteSingleRow(sql, new { person.PersonId}, _connectionString.GetConnectionString());
        }

        public void UpdatePerson(IPerson person)
        {
            string sql = "UPDATE People SET FirstName = @FirstName, LastName = @LastName, DateOfBirth = @DateOfBirth, EmailAddress = @EmailAddress, Gender = @Gender WHERE PersonId = @PersonId";

            _databaseOperations.UpdateRecord(sql, new { person.PersonId, person.FirstName, person.LastName, person.DateOfBirth, person.EmailAddress, person.Gender}, _connectionString.GetConnectionString());
        }
    }
}
