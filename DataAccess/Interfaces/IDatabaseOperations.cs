using System.Collections.Generic;

namespace DataAccess
{
    public interface IDatabaseOperations
    {
        List<T> GetData<T, U>(string sqlStatement, U parameters, string connectionString);
        void SaveData<T>(string sqlStatement, T parameters, string connectionString);
        void DeleteSingleRow<T>(string sqlStatement, T parameters, string connectionString);
        void UpdateRecord<T>(string sqlStatement, T parameters, string connectionString);
    }
}