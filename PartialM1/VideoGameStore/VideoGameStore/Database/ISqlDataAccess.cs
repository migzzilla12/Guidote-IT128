namespace VideoGameStore.Database
{
    public interface ISqlDataAccess
    {
        List<T> LoadData<T, U>(string sqlStatement, U Parameters, string connectionStringName, bool isStoredProcedure);
        void SaveData<T>(string sqlStatement, T parameters, string connectionStringName, bool isStoredProcedure);
    }
}